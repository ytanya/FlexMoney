﻿using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FlexMoney.Application.Interfaces.Repositories;
using FlexMoney.Application.Interfaces.Services.Storage;
using FlexMoney.Application.Interfaces.Services.Storage.Provider;
using FlexMoney.Application.Interfaces.Serialization.Serializers;
using FlexMoney.Application.Serialization.JsonConverters;
using FlexMoney.Infrastructure.Repositories;
using FlexMoney.Infrastructure.Services.Storage;
using FlexMoney.Application.Serialization.Options;
using FlexMoney.Infrastructure.Services.Storage.Provider;
using FlexMoney.Application.Serialization.Serializers;

namespace FlexMoney.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructureMappings(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddTransient(typeof(IRepositoryAsync<,>), typeof(RepositoryAsync<,>))
                .AddTransient<IProductRepository, ProductRepository>()
                .AddTransient<IBrandRepository, BrandRepository>()
                .AddTransient<ITransactionRepository, TransactionRepository>()
                .AddTransient<IMemberLineRepository, MemberLineRepository>()
                .AddTransient<IDocumentRepository, DocumentRepository>()
                .AddTransient<IDocumentTypeRepository, DocumentTypeRepository>()
                .AddTransient<IMoneyLineRepository, MoneyLineRepository>()
                .AddTransient<IReportRepository, ReportRepository>()
                .AddTransient<IMemberRepository, MemberRepository>()
                .AddTransient<ITypeRepository, TypeRepository>()
                .AddTransient(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }

        public static IServiceCollection AddExtendedAttributesUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddTransient(typeof(IExtendedAttributeUnitOfWork<,,>), typeof(ExtendedAttributeUnitOfWork<,,>));
        }

        public static IServiceCollection AddServerStorage(this IServiceCollection services)
            => AddServerStorage(services, null);

        public static IServiceCollection AddServerStorage(this IServiceCollection services, Action<SystemTextJsonOptions> configure)
        {
            return services
                .AddScoped<IJsonSerializer, SystemTextJsonSerializer>()
                .AddScoped<IStorageProvider, ServerStorageProvider>()
                .AddScoped<IServerStorageService, ServerStorageService>()
                .AddScoped<ISyncServerStorageService, ServerStorageService>()
                .Configure<SystemTextJsonOptions>(configureOptions =>
                {
                    configure?.Invoke(configureOptions);
                    if (!configureOptions.JsonSerializerOptions.Converters.Any(c => c.GetType() == typeof(TimespanJsonConverter)))
                        configureOptions.JsonSerializerOptions.Converters.Add(new TimespanJsonConverter());
                });
        }
    }
}