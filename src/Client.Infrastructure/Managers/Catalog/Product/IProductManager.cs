﻿using FlexMoney.Application.Features.Products.Commands.AddEdit;
using FlexMoney.Application.Features.Products.Queries.GetAllPaged;
using FlexMoney.Application.Requests.Catalog;
using FlexMoney.Shared.Wrapper;
using System.Threading.Tasks;

namespace FlexMoney.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}