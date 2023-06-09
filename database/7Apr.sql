USE [FlexMoneyDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AuditTrails]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuditTrails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](max) NULL,
	[Type] [nvarchar](max) NULL,
	[TableName] [nvarchar](max) NULL,
	[DateTime] [datetime2](7) NOT NULL,
	[OldValues] [nvarchar](max) NULL,
	[NewValues] [nvarchar](max) NULL,
	[AffectedColumns] [nvarchar](max) NULL,
	[PrimaryKey] [nvarchar](max) NULL,
 CONSTRAINT [PK_AuditTrails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Tax] [decimal](18, 2) NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChatHistory]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChatHistory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FromUserId] [nvarchar](450) NULL,
	[ToUserId] [nvarchar](450) NULL,
	[Message] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ChatHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentExtendedAttributes]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentExtendedAttributes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
	[EntityId] [int] NOT NULL,
	[Type] [tinyint] NOT NULL,
	[Key] [nvarchar](max) NOT NULL,
	[Text] [nvarchar](max) NULL,
	[Decimal] [decimal](18, 2) NULL,
	[DateTime] [datetime2](7) NULL,
	[Json] [nvarchar](max) NULL,
	[ExternalId] [nvarchar](max) NULL,
	[Group] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_DocumentExtendedAttributes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documents]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[IsPublic] [bit] NOT NULL,
	[URL] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
	[DocumentTypeId] [int] NOT NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentTypes]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_DocumentTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MemberLines]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MemberLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MemberId] [int] NOT NULL,
	[LineId] [int] NOT NULL,
	[Position] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
	[DeadSection] [int] NOT NULL,
 CONSTRAINT [PK_MemberLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[AccountNumber] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MoneyLines]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MoneyLines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[TypeId] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Money] [decimal](18, 2) NOT NULL,
	[Quantity] [int] NOT NULL,
	[OwnerId] [int] NOT NULL,
	[StatusId] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
	[CurrentSection] [int] NOT NULL,
 CONSTRAINT [PK_MoneyLines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Barcode] [nvarchar](max) NULL,
	[ImageDataURL] [text] NULL,
	[Description] [nvarchar](max) NULL,
	[Rate] [decimal](18, 2) NOT NULL,
	[BrandId] [int] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LineStatus] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[LineId] [int] NOT NULL,
	[TypeId] [int] NOT NULL,
	[Section] [int] NOT NULL,
	[CallerId] [int] NOT NULL,
	[Position] [int] NOT NULL,
	[Pay] [decimal](18, 2) NOT NULL,
	[Call] [decimal](18, 2) NOT NULL,
	[Earn] [decimal](18, 2) NOT NULL,
	[ThankMoney] [decimal](18, 2) NOT NULL,
	[RealEarn] [decimal](18, 2) NOT NULL,
	[Dead] [decimal](18, 2) NOT NULL,
	[Alive] [decimal](18, 2) NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Types]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Types](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Note] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_Types] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[AggregatedCounter]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[AggregatedCounter](
	[Key] [nvarchar](100) NOT NULL,
	[Value] [bigint] NOT NULL,
	[ExpireAt] [datetime] NULL,
 CONSTRAINT [PK_HangFire_CounterAggregated] PRIMARY KEY CLUSTERED 
(
	[Key] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[Counter]    Script Date: 4/7/2023 3:52:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[Counter](
	[Key] [nvarchar](100) NOT NULL,
	[Value] [int] NOT NULL,
	[ExpireAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[Hash]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[Hash](
	[Key] [nvarchar](100) NOT NULL,
	[Field] [nvarchar](100) NOT NULL,
	[Value] [nvarchar](max) NULL,
	[ExpireAt] [datetime2](7) NULL,
 CONSTRAINT [PK_HangFire_Hash] PRIMARY KEY CLUSTERED 
(
	[Key] ASC,
	[Field] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[Job]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[Job](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[StateId] [bigint] NULL,
	[StateName] [nvarchar](20) NULL,
	[InvocationData] [nvarchar](max) NOT NULL,
	[Arguments] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[ExpireAt] [datetime] NULL,
 CONSTRAINT [PK_HangFire_Job] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[JobParameter]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[JobParameter](
	[JobId] [bigint] NOT NULL,
	[Name] [nvarchar](40) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_HangFire_JobParameter] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[JobQueue]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[JobQueue](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[JobId] [bigint] NOT NULL,
	[Queue] [nvarchar](50) NOT NULL,
	[FetchedAt] [datetime] NULL,
 CONSTRAINT [PK_HangFire_JobQueue] PRIMARY KEY CLUSTERED 
(
	[Queue] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[List]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[List](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Key] [nvarchar](100) NOT NULL,
	[Value] [nvarchar](max) NULL,
	[ExpireAt] [datetime] NULL,
 CONSTRAINT [PK_HangFire_List] PRIMARY KEY CLUSTERED 
(
	[Key] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[Schema]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[Schema](
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_HangFire_Schema] PRIMARY KEY CLUSTERED 
(
	[Version] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[Server]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[Server](
	[Id] [nvarchar](200) NOT NULL,
	[Data] [nvarchar](max) NULL,
	[LastHeartbeat] [datetime] NOT NULL,
 CONSTRAINT [PK_HangFire_Server] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[Set]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[Set](
	[Key] [nvarchar](100) NOT NULL,
	[Score] [float] NOT NULL,
	[Value] [nvarchar](256) NOT NULL,
	[ExpireAt] [datetime] NULL,
 CONSTRAINT [PK_HangFire_Set] PRIMARY KEY CLUSTERED 
(
	[Key] ASC,
	[Value] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [HangFire].[State]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HangFire].[State](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[JobId] [bigint] NOT NULL,
	[Name] [nvarchar](20) NOT NULL,
	[Reason] [nvarchar](100) NULL,
	[CreatedAt] [datetime] NOT NULL,
	[Data] [nvarchar](max) NULL,
 CONSTRAINT [PK_HangFire_State] PRIMARY KEY CLUSTERED 
(
	[JobId] ASC,
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Identity].[RoleClaims]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Identity].[RoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Group] [nvarchar](max) NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_RoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Identity].[Roles]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Identity].[Roles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Identity].[UserClaims]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Identity].[UserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Identity].[UserLogins]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Identity].[UserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Identity].[UserRoles]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Identity].[UserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Identity].[Users]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Identity].[Users](
	[Id] [nvarchar](450) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[ProfilePictureDataUrl] [text] NULL,
	[CreatedOn] [datetime2](7) NOT NULL,
	[LastModifiedBy] [nvarchar](max) NULL,
	[LastModifiedOn] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[DeletedOn] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[RefreshToken] [nvarchar](max) NULL,
	[RefreshTokenExpiryTime] [datetime2](7) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [Identity].[UserTokens]    Script Date: 4/7/2023 3:52:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Identity].[UserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210413122110_initial', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210526094834_AddBlazorHeroRole', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210528104232_AddBlazorHeroRoleClaim', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210613102039_AddDocumentTypeAndExtendedAttribute', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230316061233_InitialCreate', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230325151630_test1', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230326071813_test5', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230326072142_test6', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230327093331_test7', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230327154933_section', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230330032755_test9', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230330065015_deadsection', N'5.0.7')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230331060559_report', N'5.0.7')
GO
SET IDENTITY_INSERT [dbo].[AuditTrails] ON 

INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-25T15:18:50.8946429' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-25T15:18:50.8652562Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"An","Note":null}', NULL, N'{"Id":1}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-25T15:19:05.2041803' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-25T15:19:05.1948694Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Ana Chau","Note":null}', NULL, N'{"Id":2}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (3, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-25T15:19:13.3068448' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-25T15:19:13.2912949Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Binh","Note":null}', NULL, N'{"Id":3}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (4, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-25T15:19:25.7914714' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-25T15:19:25.7757095Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Cam","Note":null}', NULL, N'{"Id":4}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (5, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-25T15:19:35.9056977' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-25T15:19:35.8918966Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Diem My","Note":null}', NULL, N'{"Id":5}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (6, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Type', CAST(N'2023-03-25T15:20:03.6999329' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-25T15:20:03.6802006Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Thang khui 15 tay","Note":null}', NULL, N'{"Id":1}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (7, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Type', CAST(N'2023-03-25T15:20:12.9685763' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-25T15:20:12.9588029Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Tuan khui T2","Note":null}', NULL, N'{"Id":2}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (8, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Type', CAST(N'2023-03-25T15:20:19.4865577' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-25T15:20:19.4751702Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Ngay 1 lan","Note":null}', NULL, N'{"Id":3}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (9, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Type', CAST(N'2023-03-25T15:20:27.8702789' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-25T15:20:27.8554422Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"3 ngay 1 lan","Note":null}', NULL, N'{"Id":4}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (10, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T07:22:59.9891606' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T14:22:53.167+07:00","CreatedOn":"2023-03-26T07:22:59.8765048Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Benh vien GD","OwnerId":0,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":5}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (11, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T07:38:43.8871201' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T14:38:33.127+07:00","CreatedOn":"2023-03-26T07:38:43.774027Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Hoi ban than","OwnerId":0,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":6}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (12, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T07:39:43.3104074' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T14:39:33.633+07:00","CreatedOn":"2023-03-26T07:39:43.3040938Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Benh vien GD","OwnerId":0,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":7}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (13, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T07:40:12.7919009' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T14:40:12.718+07:00","CreatedOn":"2023-03-26T07:40:12.785601Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Benh vien GD 1","OwnerId":0,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":8}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (14, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T07:41:02.5764980' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T14:40:57.043+07:00","CreatedOn":"2023-03-26T07:41:02.5697857Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Benh vien GD 2","OwnerId":0,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":9}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (15, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T07:45:35.3133893' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T14:43:40.551+07:00","CreatedOn":"2023-03-26T07:45:35.2024141Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Hoi ban than","OwnerId":0,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":10}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (16, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T07:51:10.1518927' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T14:50:52.697+07:00","CreatedOn":"2023-03-26T07:51:10.0425779Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Hoi ban than","OwnerId":2,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":11}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (17, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T07:52:42.6322581' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T14:52:20.23+07:00","CreatedOn":"2023-03-26T07:52:42.6036425Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Benh vien GD","OwnerId":2,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":12}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (18, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T07:58:57.0917535' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T14:58:47.057+07:00","CreatedOn":"2023-03-26T07:58:56.9656404Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Hoi ban than 1","OwnerId":3,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":13}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (19, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T08:01:16.6724360' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:01:06.55+07:00","CreatedOn":"2023-03-26T08:01:16.5571435Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":1000000.0,"Name":"Hoi ban than","OwnerId":2,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":14}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (20, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T08:02:43.2408351' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:02:27.833+07:00","CreatedOn":"2023-03-26T08:02:43.234764Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":1000000.0,"Name":"Hoi ban than 1","OwnerId":2,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":15}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (21, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T08:04:24.5407513' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:04:24.465+07:00","CreatedOn":"2023-03-26T08:04:24.5351178Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":1000000.0,"Name":"Hoi ban than 2","OwnerId":2,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":16}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (22, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T08:05:36.9528287' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:05:34.94+07:00","CreatedOn":"2023-03-26T08:05:36.9468235Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":1000000.0,"Name":"Hoi ban than 3","OwnerId":2,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":17}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (23, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T08:08:52.0980868' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:08:51.797+07:00","CreatedOn":"2023-03-26T08:08:51.9845635Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Benh vien GD 1","OwnerId":2,"Quantity":3,"StatusId":1,"TypeId":3}', NULL, N'{"Id":18}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (24, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:09:03.0526642' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:09:03.0074319Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":18,"MemberId":1,"Position":1}', NULL, N'{"Id":4}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (25, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:09:31.3481939' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:09:31.3413612Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":18,"MemberId":1,"Position":1}', NULL, N'{"Id":5}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (26, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:09:35.9541328' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:09:35.947981Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":18,"MemberId":2,"Position":1}', NULL, N'{"Id":6}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (27, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T08:12:53.0270060' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:12:52.672+07:00","CreatedOn":"2023-03-26T08:12:52.9035115Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Benh vien GD","OwnerId":2,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, N'{"Id":19}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (28, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:13:07.6263479' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:13:07.6144433Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":19,"MemberId":1,"Position":1}', NULL, N'{"Id":7}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (29, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:13:12.5258619' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:13:12.5203645Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":19,"MemberId":1,"Position":2}', NULL, N'{"Id":8}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (30, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:13:14.6344771' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:13:14.627683Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":19,"MemberId":2,"Position":1}', NULL, N'{"Id":9}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (31, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T08:17:48.2864595' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:17:48.208+07:00","CreatedOn":"2023-03-26T08:17:48.2803067Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":1000000.0,"Name":"Hoi ban than","OwnerId":3,"Quantity":8,"StatusId":1,"TypeId":3}', NULL, N'{"Id":20}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (32, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:17:54.6844672' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:17:54.676567Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"MemberId":3,"Position":1}', NULL, N'{"Id":10}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (33, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:17:54.7530818' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:17:54.7466449Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"MemberId":4,"Position":1}', NULL, N'{"Id":11}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (34, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:17:54.8274125' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:17:54.8219958Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"MemberId":4,"Position":2}', NULL, N'{"Id":12}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (35, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:17:54.9013401' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:17:54.8959496Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"MemberId":4,"Position":3}', NULL, N'{"Id":13}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (36, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:17:54.9701380' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:17:54.9668534Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"MemberId":4,"Position":4}', NULL, N'{"Id":14}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (37, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:17:55.0485723' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:17:55.0436103Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"MemberId":4,"Position":5}', NULL, N'{"Id":15}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (38, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:17:55.1255968' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:17:55.1164496Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"MemberId":4,"Position":6}', NULL, N'{"Id":16}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (39, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T08:17:55.1957400' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T08:17:55.189156Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"MemberId":4,"Position":7}', NULL, N'{"Id":17}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (40, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Transaction', CAST(N'2023-03-26T08:24:38.4748788' AS DateTime2), NULL, N'{"Alive":0.0,"Call":50000.0,"CallerId":4,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:24:38.166+07:00","CreatedOn":"2023-03-26T08:24:38.361252Z","Dead":7000000.00,"Earn":6650000.00,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"Pay":0.0,"Position":2,"RealEarn":6600000.00,"Section":1,"ThankMoney":50000.0,"TypeId":3}', NULL, N'{"Id":1}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (41, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Transaction', CAST(N'2023-03-26T08:26:22.1887757' AS DateTime2), NULL, N'{"Alive":0.0,"Call":100000.0,"CallerId":4,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:26:22.117+07:00","CreatedOn":"2023-03-26T08:26:22.1771904Z","Dead":6000000.00,"Earn":6300000.00,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":20,"Pay":0.0,"Position":1,"RealEarn":6250000.00,"Section":2,"ThankMoney":50000.0,"TypeId":3}', NULL, N'{"Id":2}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (42, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-03-26T14:25:17.7071960' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:12:52.672","CreatedOn":"2023-03-26T08:12:52.9035115","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.00,"Name":"Benh vien GD","OwnerId":2,"Quantity":3,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":19}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (43, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-03-26T14:25:22.8057101' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T15:17:48.208","CreatedOn":"2023-03-26T08:17:48.2803067","LastModifiedBy":null,"LastModifiedOn":null,"Money":1000000.00,"Name":"Hoi ban than","OwnerId":3,"Quantity":8,"StatusId":1,"TypeId":3}', NULL, NULL, N'{"Id":20}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (44, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:26:31.8784186' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:26:31.8642718Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Hang","Note":null}', NULL, N'{"Id":6}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (45, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:26:36.8497013' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:26:36.8429845Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Hung","Note":null}', NULL, N'{"Id":7}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (46, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:26:40.5611647' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:26:40.5541252Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Lam PHa","Note":null}', NULL, N'{"Id":8}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (47, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Update', N'Member', CAST(N'2023-03-26T14:26:48.0879430' AS DateTime2), N'{"Name":"Lam PHa"}', N'{"Name":"Lam Pha"}', N'["Name"]', N'{"Id":8}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (48, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:26:55.8264988' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:26:55.817568Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Mong Cam","Note":null}', NULL, N'{"Id":9}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (49, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:01.7581220' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:01.7473885Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Nang","Note":null}', NULL, N'{"Id":10}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (50, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:15.3499171' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:15.3412282Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Nguoi la","Note":null}', NULL, N'{"Id":11}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (51, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:21.1633260' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:21.1522866Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Ni Ni","Note":null}', NULL, N'{"Id":12}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (52, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:27.2107488' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:27.2018264Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Phuong Nguyen","Note":null}', NULL, N'{"Id":13}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (53, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:34.2658215' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:34.2575436Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Sieu thi mini","Note":null}', NULL, N'{"Id":14}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (54, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:40.0459991' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:40.0388571Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Truc Linh","Note":null}', NULL, N'{"Id":15}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (55, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:44.9475171' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:44.9388826Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Truong An","Note":null}', NULL, N'{"Id":16}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (56, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:49.3486693' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:49.3433257Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Tu","Note":null}', NULL, N'{"Id":17}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (57, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:51.7482882' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:51.7417639Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Tuan","Note":null}', NULL, N'{"Id":18}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (58, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-03-26T14:27:59.3780852' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:27:59.3689967Z","LastModifiedBy":null,"LastModifiedOn":null,"Name":"Yen Linh","Note":null}', NULL, N'{"Id":19}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (59, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T14:29:47.5142235' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T21:29:47.292+07:00","CreatedOn":"2023-03-26T14:29:47.4936584Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":500000.0,"Name":"Line 1","OwnerId":5,"Quantity":8,"StatusId":1,"TypeId":3}', NULL, N'{"Id":21}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (60, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:29:47.7451422' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:29:47.7297108Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":21,"MemberId":1,"Position":1}', NULL, N'{"Id":18}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (61, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:29:48.1495080' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:29:48.1419638Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":21,"MemberId":2,"Position":1}', NULL, N'{"Id":19}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (62, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:29:48.2811624' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:29:48.26945Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":21,"MemberId":3,"Position":1}', NULL, N'{"Id":20}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (63, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:29:48.4232545' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:29:48.4156426Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":21,"MemberId":4,"Position":1}', NULL, N'{"Id":21}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (64, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:29:48.6388077' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:29:48.6329571Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":21,"MemberId":5,"Position":1}', NULL, N'{"Id":22}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (65, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:29:48.7466660' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:29:48.7407605Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":21,"MemberId":5,"Position":2}', NULL, N'{"Id":23}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (66, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:29:48.8646715' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:29:48.8585231Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":21,"MemberId":5,"Position":3}', NULL, N'{"Id":24}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (67, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:29:48.9859725' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:29:48.9802826Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":21,"MemberId":6,"Position":1}', NULL, N'{"Id":25}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (68, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T14:33:28.3266077' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T21:33:28.205+07:00","CreatedOn":"2023-03-26T14:33:28.3203858Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":700000.0,"Name":"Line 2","OwnerId":5,"Quantity":10,"StatusId":1,"TypeId":3}', NULL, N'{"Id":22}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (69, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:28.4123071' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:28.4014853Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":1,"Position":1}', NULL, N'{"Id":26}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (70, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:28.4997146' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:28.4930659Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":5,"Position":1}', NULL, N'{"Id":27}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (71, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:28.5891238' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:28.5787653Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":6,"Position":1}', NULL, N'{"Id":28}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (72, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:28.6791204' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:28.6705378Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":8,"Position":1}', NULL, N'{"Id":29}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (73, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:28.7711687' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:28.7651184Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":10,"Position":1}', NULL, N'{"Id":30}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (74, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:28.8721082' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:28.8663696Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":10,"Position":2}', NULL, N'{"Id":31}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (75, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:28.9692138' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:28.9622119Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":11,"Position":1}', NULL, N'{"Id":32}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (76, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:29.0690246' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:29.0622126Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":12,"Position":1}', NULL, N'{"Id":33}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (77, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:29.1877744' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:29.1765595Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":12,"Position":3}', NULL, N'{"Id":34}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (78, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:33:29.2865292' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:33:29.2752217Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":22,"MemberId":12,"Position":4}', NULL, N'{"Id":35}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (79, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T14:34:59.4258368' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T21:34:59.308+07:00","CreatedOn":"2023-03-26T14:34:59.4156264Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":1200000.0,"Name":"Line 3","OwnerId":6,"Quantity":10,"StatusId":1,"TypeId":2}', NULL, N'{"Id":23}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (80, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:34:59.5141770' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:34:59.5071915Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":1,"Position":1}', NULL, N'{"Id":36}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (81, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:34:59.6157550' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:34:59.6086792Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":2,"Position":1}', NULL, N'{"Id":37}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (82, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:34:59.7152186' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:34:59.7077273Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":4,"Position":1}', NULL, N'{"Id":38}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (83, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:34:59.8418535' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:34:59.8341862Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":4,"Position":2}', NULL, N'{"Id":39}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (84, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:34:59.9512328' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:34:59.9461007Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":5,"Position":1}', NULL, N'{"Id":40}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (85, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:35:00.0535253' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:35:00.0480739Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":7,"Position":1}', NULL, N'{"Id":41}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (86, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:35:00.1617617' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:35:00.1543947Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":13,"Position":1}', NULL, N'{"Id":42}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (87, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:35:00.2800356' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:35:00.2736917Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":13,"Position":3}', NULL, N'{"Id":43}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (88, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:35:00.3762751' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:35:00.3688974Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":14,"Position":1}', NULL, N'{"Id":44}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (89, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:35:00.5009400' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:35:00.4942153Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":23,"MemberId":15,"Position":1}', NULL, N'{"Id":45}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (90, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T14:37:24.7776778' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T21:37:24.681+07:00","CreatedOn":"2023-03-26T14:37:24.7727135Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Line 4","OwnerId":15,"Quantity":12,"StatusId":1,"TypeId":1}', NULL, N'{"Id":24}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (91, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:24.8944666' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:24.8883151Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":2,"Position":1}', NULL, N'{"Id":46}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (92, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:24.9837076' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:24.9775577Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":3,"Position":1}', NULL, N'{"Id":47}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (93, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:25.0946920' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:25.0872022Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":3,"Position":2}', NULL, N'{"Id":48}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (94, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:25.1884794' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:25.1826196Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":5,"Position":1}', NULL, N'{"Id":49}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (95, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:25.2858463' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:25.2795951Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":7,"Position":1}', NULL, N'{"Id":50}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (96, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:25.3933742' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:25.3870337Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":8,"Position":1}', NULL, N'{"Id":51}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (97, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:25.4896692' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:25.4830615Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":11,"Position":1}', NULL, N'{"Id":52}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (98, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:25.5979659' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:25.5910801Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":12,"Position":1}', NULL, N'{"Id":53}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (99, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:25.7059464' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:25.6975507Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":13,"Position":1}', NULL, N'{"Id":54}')
GO
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (100, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:25.8074671' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:25.7989141Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":15,"Position":1}', NULL, N'{"Id":55}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (101, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:25.9148788' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:25.9088125Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":15,"Position":3}', NULL, N'{"Id":56}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (102, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:37:26.0145606' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:37:26.0081291Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":24,"MemberId":16,"Position":1}', NULL, N'{"Id":57}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (103, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T14:38:41.1427858' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T21:38:41.03+07:00","CreatedOn":"2023-03-26T14:38:41.1336657Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":10000000.0,"Name":"Line 5","OwnerId":1,"Quantity":6,"StatusId":1,"TypeId":3}', NULL, N'{"Id":25}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (104, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:38:41.2278308' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:38:41.219954Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":25,"MemberId":1,"Position":1}', NULL, N'{"Id":58}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (105, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:38:41.3225469' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:38:41.317915Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":25,"MemberId":2,"Position":1}', NULL, N'{"Id":59}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (106, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:38:41.4161228' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:38:41.4076513Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":25,"MemberId":3,"Position":1}', NULL, N'{"Id":60}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (107, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:38:41.5205543' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:38:41.511605Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":25,"MemberId":4,"Position":1}', NULL, N'{"Id":61}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (108, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:38:41.6195992' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:38:41.6127835Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":25,"MemberId":6,"Position":1}', NULL, N'{"Id":62}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (109, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:38:41.7335101' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:38:41.7225221Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":25,"MemberId":5,"Position":1}', NULL, N'{"Id":63}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (110, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T14:39:54.3109746' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T21:39:54.213+07:00","CreatedOn":"2023-03-26T14:39:54.3000273Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Line 6","OwnerId":4,"Quantity":7,"StatusId":1,"TypeId":2}', NULL, N'{"Id":26}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (111, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:39:54.4028983' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:39:54.3958824Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":26,"MemberId":2,"Position":1}', NULL, N'{"Id":64}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (112, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:39:54.4914983' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:39:54.4816131Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":26,"MemberId":4,"Position":1}', NULL, N'{"Id":65}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (113, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:39:54.6029360' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:39:54.5928947Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":26,"MemberId":4,"Position":2}', NULL, N'{"Id":66}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (114, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:39:54.7054113' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:39:54.6984786Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":26,"MemberId":4,"Position":3}', NULL, N'{"Id":67}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (115, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:39:54.8036838' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:39:54.7956207Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":26,"MemberId":7,"Position":1}', NULL, N'{"Id":68}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (116, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:39:54.8950173' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:39:54.8885471Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":26,"MemberId":7,"Position":4}', NULL, N'{"Id":69}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (117, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:39:54.9893291' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:39:54.9836735Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":26,"MemberId":10,"Position":1}', NULL, N'{"Id":70}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (118, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T14:41:26.0204145' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T21:41:25.911+07:00","CreatedOn":"2023-03-26T14:41:26.0109648Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":4000000.0,"Name":"Line 7","OwnerId":5,"Quantity":12,"StatusId":1,"TypeId":1}', NULL, N'{"Id":27}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (119, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.1055267' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.0988975Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":5,"Position":1}', NULL, N'{"Id":71}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (120, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.2091493' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.1992126Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":9,"Position":1}', NULL, N'{"Id":72}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (121, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.2962220' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.2918905Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":9,"Position":2}', NULL, N'{"Id":73}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (122, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.3867183' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.3807452Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":9,"Position":3}', NULL, N'{"Id":74}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (123, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.4916891' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.4844527Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":12,"Position":1}', NULL, N'{"Id":75}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (124, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.5815904' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.5724691Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":12,"Position":4}', NULL, N'{"Id":76}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (125, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.6887640' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.6805625Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":14,"Position":1}', NULL, N'{"Id":77}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (126, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.7852571' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.7779222Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":15,"Position":1}', NULL, N'{"Id":78}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (127, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.8886714' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.8818833Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":15,"Position":5}', NULL, N'{"Id":79}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (128, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:26.9924743' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:26.9819015Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":16,"Position":1}', NULL, N'{"Id":80}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (129, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:27.0926189' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:27.0858353Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":18,"Position":1}', NULL, N'{"Id":81}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (130, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:41:27.1960557' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:41:27.187488Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"MemberId":19,"Position":1}', NULL, N'{"Id":82}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (131, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-03-26T14:43:45.0710500' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-26T21:43:44.973+07:00","CreatedOn":"2023-03-26T14:43:45.061748Z","LastModifiedBy":null,"LastModifiedOn":null,"Money":1000000.0,"Name":"Line 8","OwnerId":1,"Quantity":15,"StatusId":1,"TypeId":3}', NULL, N'{"Id":28}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (132, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:45.1526937' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:45.1430195Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":5,"Position":1}', NULL, N'{"Id":83}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (133, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:45.2568629' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:45.2505679Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":6,"Position":1}', NULL, N'{"Id":84}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (134, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:45.3690295' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:45.3611859Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":7,"Position":1}', NULL, N'{"Id":85}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (135, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:45.4755378' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:45.4687714Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":9,"Position":1}', NULL, N'{"Id":86}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (136, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:45.5717007' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:45.5605882Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":9,"Position":2}', NULL, N'{"Id":87}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (137, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:45.6772722' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:45.6700804Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":10,"Position":1}', NULL, N'{"Id":88}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (138, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:45.7898659' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:45.7778906Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":10,"Position":3}', NULL, N'{"Id":89}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (139, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:45.8979772' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:45.8903836Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":10,"Position":4}', NULL, N'{"Id":90}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (140, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:46.0006020' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:45.9920472Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":10,"Position":5}', NULL, N'{"Id":91}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (141, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:46.1113714' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:46.1047939Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":12,"Position":1}', NULL, N'{"Id":92}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (142, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:46.2153886' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:46.2072065Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":12,"Position":6}', NULL, N'{"Id":93}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (143, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:46.3316312' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:46.3226499Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":13,"Position":1}', NULL, N'{"Id":94}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (144, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:46.4273109' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:46.4195186Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":13,"Position":7}', NULL, N'{"Id":95}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (145, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:46.5411940' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:46.5314814Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":17,"Position":1}', NULL, N'{"Id":96}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (146, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-03-26T14:43:46.6432249' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-03-26T14:43:46.6331533Z","LastModifiedBy":null,"LastModifiedOn":null,"LineId":28,"MemberId":13,"Position":8}', NULL, N'{"Id":97}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (147, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Transaction', CAST(N'2023-03-31T10:26:19.9263488' AS DateTime2), NULL, N'{"Alive":0.0,"Call":700000.0,"CallerId":14,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-03-31T17:26:19.651+07:00","CreatedOn":"2023-03-31T10:26:19.8210905Z","Dead":48000000.00,"Earn":36300000.00,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":27,"Pay":0.0,"Position":1,"RealEarn":36100000.00,"Section":0,"ThankMoney":200000.0,"TypeId":1}', NULL, N'{"Id":9}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (148, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-04-05T06:31:46.9399916' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-05T06:31:46.6035966Z","IsDeleted":false,"LastModifiedBy":null,"LastModifiedOn":null,"Name":"Thao","Note":null}', NULL, N'{"Id":20}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (149, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'Member', CAST(N'2023-04-05T06:31:57.8818917' AS DateTime2), N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-05T06:31:46.6035966","IsDeleted":false,"LastModifiedBy":null,"LastModifiedOn":null,"Name":"Thao","Note":null}', NULL, NULL, N'{"Id":20}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (150, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-04-05T06:33:06.1599885' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-05T06:33:06.141856Z","IsDeleted":false,"LastModifiedBy":null,"LastModifiedOn":null,"Name":"Thao","Note":null}', NULL, N'{"Id":21}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (151, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'Member', CAST(N'2023-04-05T06:34:02.2731370' AS DateTime2), N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-05T06:33:06.141856","IsDeleted":false,"LastModifiedBy":null,"LastModifiedOn":null,"Name":"Thao","Note":null}', NULL, NULL, N'{"Id":21}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (152, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-04-05T06:34:52.5686704' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-05T06:34:52.550602Z","IsDeleted":false,"LastModifiedBy":null,"LastModifiedOn":null,"Name":"Thao","Note":null}', NULL, N'{"Id":22}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (153, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-04-05T06:36:04.2293477' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-05T06:36:04.2116614Z","IsDeleted":false,"LastModifiedBy":null,"LastModifiedOn":null,"Name":"Thao 1","Note":null}', NULL, N'{"Id":23}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (154, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'Member', CAST(N'2023-04-05T06:41:49.0629973' AS DateTime2), NULL, N'{"AccountNumber":null,"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-05T06:41:48.7950494Z","IsDeleted":false,"LastModifiedBy":null,"LastModifiedOn":null,"Name":"Thao","Note":null}', NULL, N'{"Id":24}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (155, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-05T06:43:13.0748178' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-05T13:43:12.828+07:00","CreatedOn":"2023-04-05T06:43:13.0412315Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, N'{"Id":29}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (156, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-05T06:43:13.3576871' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-05T06:43:13.3287121Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":29,"MemberId":1,"Position":1}', NULL, N'{"Id":98}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (157, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T02:48:15.1579657' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T02:48:15.0666541Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":29,"MemberId":2,"Position":1}', NULL, N'{"Id":99}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (158, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T03:45:06.1406585' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T03:45:06.0305154Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":29,"MemberId":2,"Position":2}', NULL, N'{"Id":100}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (159, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T04:00:10.6821273' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T04:00:10.5732002Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":29,"MemberId":2,"Position":1}', NULL, N'{"Id":101}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (160, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T04:00:13.0930398' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T04:00:13.0890704Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":29,"MemberId":2,"Position":2}', NULL, N'{"Id":102}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (161, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T04:13:00.6399104' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T04:13:00.5426471Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":29,"MemberId":2,"Position":1}', NULL, N'{"Id":103}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (162, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T04:13:03.1569470' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T04:13:03.139475Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":29,"MemberId":2,"Position":2}', NULL, N'{"Id":104}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (163, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T04:13:05.5037954' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T04:13:05.498366Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":29,"MemberId":2,"Position":3}', NULL, N'{"Id":105}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (164, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:14:12.1968342' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-05T13:43:12.828","CreatedOn":"2023-04-05T06:43:13.0412315","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, NULL, N'{"Id":29}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (165, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:16:50.8729789' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:16:50.75+07:00","CreatedOn":"2023-04-06T04:16:50.851869Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, N'{"Id":30}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (166, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:16:50.9155693' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:16:50.75","CreatedOn":"2023-04-06T04:16:50.851869","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, NULL, N'{"Id":30}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (167, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:17:44.9226379' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:17:44.841+07:00","CreatedOn":"2023-04-06T04:17:44.9071268Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, N'{"Id":31}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (168, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:17:44.9588201' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:17:44.841","CreatedOn":"2023-04-06T04:17:44.9071268","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, NULL, N'{"Id":31}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (169, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:18:50.5804246' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:18:50.491+07:00","CreatedOn":"2023-04-06T04:18:50.5680311Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, N'{"Id":32}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (170, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:18:50.6293914' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:18:50.491","CreatedOn":"2023-04-06T04:18:50.5680311","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, NULL, N'{"Id":32}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (171, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:19:00.1082167' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:19:00.02+07:00","CreatedOn":"2023-04-06T04:19:00.0925985Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, N'{"Id":33}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (172, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:19:00.1420658' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:19:00.02","CreatedOn":"2023-04-06T04:19:00.0925985","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, NULL, N'{"Id":33}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (173, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:19:15.8453794' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:19:15.75+07:00","CreatedOn":"2023-04-06T04:19:15.8271598Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, N'{"Id":34}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (174, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:19:15.8844563' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:19:15.75","CreatedOn":"2023-04-06T04:19:15.8271598","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":3}', NULL, NULL, N'{"Id":34}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (175, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:25:34.2344202' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:23:00.092+07:00","CreatedOn":"2023-04-06T04:25:34.1893034Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":2,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":35}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (176, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:25:38.5535080' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:23:00.092","CreatedOn":"2023-04-06T04:25:34.1893034","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":2,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":35}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (177, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:32:13.1802764' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:32:10.123+07:00","CreatedOn":"2023-04-06T04:32:13.1657308Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":36}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (178, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:32:13.2209964' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:32:10.123","CreatedOn":"2023-04-06T04:32:13.1657308","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":36}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (179, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:35:19.6838486' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:33:24.219+07:00","CreatedOn":"2023-04-06T04:35:19.6259813Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":2,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":37}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (180, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:35:33.2257725' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:33:24.219","CreatedOn":"2023-04-06T04:35:19.6259813","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":2,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":37}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (181, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:40:21.6129042' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:40:14.595+07:00","CreatedOn":"2023-04-06T04:40:21.4732545Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":38}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (182, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:40:37.7371573' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:40:14.595","CreatedOn":"2023-04-06T04:40:21.4732545","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":38}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (183, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:42:18.8861134' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:42:15.82+07:00","CreatedOn":"2023-04-06T04:42:18.8711116Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":39}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (184, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:42:18.9284397' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:42:15.82","CreatedOn":"2023-04-06T04:42:18.8711116","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":39}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (185, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:43:58.9082364' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:43:57.442+07:00","CreatedOn":"2023-04-06T04:43:58.7919673Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":40}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (186, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:43:59.0162454' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:43:57.442","CreatedOn":"2023-04-06T04:43:58.7919673","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":40}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (187, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:55:31.3656874' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:55:18.921+07:00","CreatedOn":"2023-04-06T04:55:31.2646353Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":41}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (188, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:55:31.4663370' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:55:18.921","CreatedOn":"2023-04-06T04:55:31.2646353","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":41}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (189, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:56:40.3596679' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:56:39.095+07:00","CreatedOn":"2023-04-06T04:56:40.2477519Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":42}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (190, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:56:40.4563966' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:56:39.095","CreatedOn":"2023-04-06T04:56:40.2477519","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":42}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (191, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T04:59:15.3292265' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:59:10.679+07:00","CreatedOn":"2023-04-06T04:59:15.1700514Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":43}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (192, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T04:59:26.3803621' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T11:59:10.679","CreatedOn":"2023-04-06T04:59:15.1700514","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 9","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":43}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (193, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T05:00:25.4344391' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T12:00:22.923+07:00","CreatedOn":"2023-04-06T05:00:25.3268832Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 10","OwnerId":2,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":44}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (194, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T05:00:25.5268778' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T12:00:22.923","CreatedOn":"2023-04-06T05:00:25.3268832","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 10","OwnerId":2,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":44}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (195, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T05:04:09.6926336' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T12:04:08.235+07:00","CreatedOn":"2023-04-06T05:04:09.5849692Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 10","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":45}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (196, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T05:04:11.1249314' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T05:04:11.1070384Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":45,"MemberId":1,"Position":1}', NULL, N'{"Id":120}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (197, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T05:04:53.0846918' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T05:04:53.0675257Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":45,"MemberId":2,"Position":1}', NULL, N'{"Id":121}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (198, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T05:04:54.2554225' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T05:04:54.2412458Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":45,"MemberId":3,"Position":1}', NULL, N'{"Id":122}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (199, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T05:15:41.8033561' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T05:15:41.7060641Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":45,"MemberId":6,"Position":1}', NULL, N'{"Id":123}')
GO
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (200, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T05:16:18.0950323' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T05:16:18.0567275Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":45,"MemberId":6,"Position":1}', NULL, N'{"Id":124}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (201, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T05:16:20.4771165' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T05:16:20.4713409Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":45,"MemberId":6,"Position":2}', NULL, N'{"Id":125}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (203, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Update', N'BlazorHeroUser', CAST(N'2023-04-06T05:41:31.4883014' AS DateTime2), N'{"ConcurrencyStamp":"4abcb749-6317-4b95-a703-02716db95451","LastModifiedOn":"2023-04-04T05:42:11.2664677","RefreshToken":"1Q5g5oXPnNR+JbeHIouO1lNOTU9C1/vY58KdqaMmmPc="}', N'{"ConcurrencyStamp":"3f7bc155-7dd4-4303-9c75-34ac9448f327","LastModifiedOn":"2023-04-06T05:41:31.4759919Z","RefreshToken":"xVM2r1/10Xi94ucTd6/WoPg9l7e901WgrlYwjquSS/I="}', N'["ConcurrencyStamp","LastModifiedOn","RefreshToken"]', N'{"Id":"4645a327-8081-4604-b7e4-a9dbfd3557f9"}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (205, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T08:18:48.5734845' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T15:18:47.405+07:00","CreatedOn":"2023-04-06T08:18:48.4596088Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 11","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":46}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (206, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T08:20:08.8146945' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T15:20:07.548+07:00","CreatedOn":"2023-04-06T08:20:08.8089835Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 12","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":47}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (207, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T08:20:14.6122135' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T08:20:14.6062045Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":47,"MemberId":1,"Position":1}', NULL, N'{"Id":126}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (208, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T08:21:13.3863739' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T15:21:12.313+07:00","CreatedOn":"2023-04-06T08:21:13.3776273Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 13","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":48}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (209, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MemberLine', CAST(N'2023-04-06T08:21:20.5892327' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedOn":"2023-04-06T08:21:20.5728397Z","DeadSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"LineId":48,"MemberId":2,"Position":1}', NULL, N'{"Id":127}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (210, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Create', N'MoneyLine', CAST(N'2023-04-06T08:34:15.8932084' AS DateTime2), NULL, N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T15:34:14.711+07:00","CreatedOn":"2023-04-06T08:34:15.7829006Z","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.0,"Name":"Line 14","OwnerId":0,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, N'{"Id":49}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (211, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T08:34:30.1634252' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T15:34:14.711","CreatedOn":"2023-04-06T08:34:15.7829006","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 14","OwnerId":0,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":49}')
INSERT [dbo].[AuditTrails] ([Id], [UserId], [Type], [TableName], [DateTime], [OldValues], [NewValues], [AffectedColumns], [PrimaryKey]) VALUES (212, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Delete', N'MoneyLine', CAST(N'2023-04-06T08:37:33.7725738' AS DateTime2), N'{"CreatedBy":"4645a327-8081-4604-b7e4-a9dbfd3557f9","CreatedDate":"2023-04-06T15:21:12.313","CreatedOn":"2023-04-06T08:21:13.3776273","CurrentSection":0,"LastModifiedBy":null,"LastModifiedOn":null,"Money":0.00,"Name":"Line 13","OwnerId":1,"Quantity":0,"StatusId":1,"TypeId":1}', NULL, NULL, N'{"Id":48}')
SET IDENTITY_INSERT [dbo].[AuditTrails] OFF
GO
SET IDENTITY_INSERT [dbo].[MemberLines] ON 

INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (18, 1, 21, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:29:47.7297108' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (19, 2, 21, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:29:48.1419638' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (20, 3, 21, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:29:48.2694500' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (21, 4, 21, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:29:48.4156426' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (22, 5, 21, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:29:48.6329571' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (23, 5, 21, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:29:48.7407605' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (24, 5, 21, 3, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:29:48.8585231' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (25, 6, 21, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:29:48.9802826' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (26, 1, 22, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:28.4014853' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (27, 5, 22, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:28.4930659' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (28, 6, 22, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:28.5787653' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (29, 8, 22, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:28.6705378' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (30, 10, 22, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:28.7651184' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (31, 10, 22, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:28.8663696' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (32, 11, 22, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:28.9622119' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (33, 12, 22, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:29.0622126' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (34, 12, 22, 3, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:29.1765595' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (35, 12, 22, 4, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:29.2752217' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (36, 1, 23, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:34:59.5071915' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (37, 2, 23, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:34:59.6086792' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (38, 4, 23, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:34:59.7077273' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (39, 4, 23, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:34:59.8341862' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (40, 5, 23, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:34:59.9461007' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (41, 7, 23, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:35:00.0480739' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (42, 13, 23, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:35:00.1543947' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (43, 13, 23, 3, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:35:00.2736917' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (44, 14, 23, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:35:00.3688974' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (45, 15, 23, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:35:00.4942153' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (46, 2, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:24.8883151' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (47, 3, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:24.9775577' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (48, 3, 24, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:25.0872022' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (49, 5, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:25.1826196' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (50, 7, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:25.2795951' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (51, 8, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:25.3870337' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (52, 11, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:25.4830615' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (53, 12, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:25.5910801' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (54, 13, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:25.6975507' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (55, 15, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:25.7989141' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (56, 15, 24, 3, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:25.9088125' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (57, 16, 24, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:26.0081291' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (58, 1, 25, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:38:41.2199540' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (59, 2, 25, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:38:41.3179150' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (60, 3, 25, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:38:41.4076513' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (61, 4, 25, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:38:41.5116050' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (62, 6, 25, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:38:41.6127835' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (63, 5, 25, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:38:41.7225221' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (64, 2, 26, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:39:54.3958824' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (65, 4, 26, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:39:54.4816131' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (66, 4, 26, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:39:54.5928947' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (67, 4, 26, 3, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:39:54.6984786' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (68, 7, 26, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:39:54.7956207' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (69, 7, 26, 4, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:39:54.8885471' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (70, 10, 26, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:39:54.9836735' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (71, 5, 27, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.0988975' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (72, 9, 27, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.1992126' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (73, 9, 27, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.2918905' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (74, 9, 27, 3, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.3807452' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (75, 12, 27, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.4844527' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (76, 12, 27, 4, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.5724691' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (77, 14, 27, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.6805625' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (78, 15, 27, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.7779222' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (79, 15, 27, 5, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.8818833' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (80, 16, 27, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.9819015' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (81, 18, 27, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:27.0858353' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (82, 19, 27, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:27.1874880' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (83, 5, 28, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.1430195' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (84, 6, 28, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.2505679' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (85, 7, 28, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.3611859' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (86, 9, 28, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.4687714' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (87, 9, 28, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.5605882' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (88, 10, 28, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.6700804' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (89, 10, 28, 3, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.7778906' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (90, 10, 28, 4, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.8903836' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (91, 10, 28, 5, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.9920472' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (92, 12, 28, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:46.1047939' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (93, 12, 28, 6, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:46.2072065' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (94, 13, 28, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:46.3226499' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (95, 13, 28, 7, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:46.4195186' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (96, 17, 28, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:46.5314814' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (97, 13, 28, 8, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:46.6331533' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (124, 6, 45, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-06T05:16:18.0567275' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (125, 6, 45, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-06T05:16:20.4713409' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MemberLines] ([Id], [MemberId], [LineId], [Position], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [DeadSection]) VALUES (126, 1, 47, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-06T08:20:14.6062045' AS DateTime2), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[MemberLines] OFF
GO
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (1, N'An', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:18:50.8652562' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (2, N'Ana Chau', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:19:05.1948694' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (3, N'Binh', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:19:13.2912949' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (4, N'Cam', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:19:25.7757095' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (5, N'Diem My', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:19:35.8918966' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (6, N'Hang', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:26:31.8642718' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (7, N'Hung', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:26:36.8429845' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (8, N'Lam Pha', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:26:40.5541252' AS DateTime2), N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:26:48.0876979' AS DateTime2), 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (9, N'Mong Cam', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:26:55.8175680' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (10, N'Nang', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:01.7473885' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (11, N'Nguoi la', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:15.3412282' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (12, N'Ni Ni', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:21.1522866' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (13, N'Phuong Nguyen', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:27.2018264' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (14, N'Sieu thi mini', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:34.2575436' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (15, N'Truc Linh', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:40.0388571' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (16, N'Truong An', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:44.9388826' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (17, N'Tu', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:49.3433257' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (18, N'Tuan', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:51.7417639' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (19, N'Yen Linh', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:27:59.3689967' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (22, N'Thao', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-05T06:34:52.5506020' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (23, N'Thao 1', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-05T06:36:04.2116614' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[Members] ([Id], [Name], [AccountNumber], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted]) VALUES (24, N'Thao', NULL, NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-05T06:41:48.7950494' AS DateTime2), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[Members] OFF
GO
SET IDENTITY_INSERT [dbo].[MoneyLines] ON 

INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (21, CAST(N'2023-03-26T21:29:47.2920000' AS DateTime2), 3, N'Line 1', CAST(500000.00 AS Decimal(18, 2)), 8, 5, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:29:47.4936584' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (22, CAST(N'2023-03-26T21:33:28.2050000' AS DateTime2), 3, N'Line 2', CAST(700000.00 AS Decimal(18, 2)), 10, 5, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:33:28.3203858' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (23, CAST(N'2023-03-26T21:34:59.3080000' AS DateTime2), 2, N'Line 3', CAST(1200000.00 AS Decimal(18, 2)), 10, 6, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:34:59.4156264' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (24, CAST(N'2023-03-26T21:37:24.6810000' AS DateTime2), 1, N'Line 4', CAST(4000000.00 AS Decimal(18, 2)), 12, 15, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:37:24.7727135' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (25, CAST(N'2023-03-26T21:38:41.0300000' AS DateTime2), 3, N'Line 5', CAST(10000000.00 AS Decimal(18, 2)), 6, 1, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:38:41.1336657' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (26, CAST(N'2023-03-26T21:39:54.2130000' AS DateTime2), 2, N'Line 6', CAST(4000000.00 AS Decimal(18, 2)), 7, 4, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:39:54.3000273' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (27, CAST(N'2023-03-26T21:41:25.9110000' AS DateTime2), 1, N'Line 7', CAST(4000000.00 AS Decimal(18, 2)), 12, 5, 2, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:41:26.0109648' AS DateTime2), NULL, NULL, 1)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (28, CAST(N'2023-03-26T21:43:44.9730000' AS DateTime2), 3, N'Line 8', CAST(1000000.00 AS Decimal(18, 2)), 15, 1, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-26T14:43:45.0617480' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (45, CAST(N'2023-04-06T12:04:08.2350000' AS DateTime2), 1, N'Line 10', CAST(0.00 AS Decimal(18, 2)), 0, 1, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-06T05:04:09.5849692' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (46, CAST(N'2023-04-06T15:18:47.4050000' AS DateTime2), 1, N'Line 11', CAST(0.00 AS Decimal(18, 2)), 0, 1, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-06T08:18:48.4596088' AS DateTime2), NULL, NULL, 0)
INSERT [dbo].[MoneyLines] ([Id], [CreatedDate], [TypeId], [Name], [Money], [Quantity], [OwnerId], [StatusId], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [CurrentSection]) VALUES (47, CAST(N'2023-04-06T15:20:07.5480000' AS DateTime2), 1, N'Line 12', CAST(0.00 AS Decimal(18, 2)), 0, 1, 1, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-06T08:20:08.8089835' AS DateTime2), NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[MoneyLines] OFF
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([Id], [LineStatus], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (1, N'New', N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:18:50.8946429' AS DateTime2), NULL, NULL)
INSERT [dbo].[Status] ([Id], [LineStatus], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (2, N'In Processing', N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:18:50.8946429' AS DateTime2), NULL, NULL)
INSERT [dbo].[Status] ([Id], [LineStatus], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (3, N'Closed', N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:19:05.2041803' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
SET IDENTITY_INSERT [dbo].[Transactions] ON 

INSERT [dbo].[Transactions] ([Id], [CreatedDate], [LineId], [TypeId], [Section], [CallerId], [Position], [Pay], [Call], [Earn], [ThankMoney], [RealEarn], [Dead], [Alive], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (36, CAST(N'2023-04-04T15:49:56.1266667' AS DateTime2), 21, 3, 1, 1, 1, CAST(0.00 AS Decimal(18, 2)), CAST(100000.00 AS Decimal(18, 2)), CAST(2800000.00 AS Decimal(18, 2)), CAST(10000.00 AS Decimal(18, 2)), CAST(2790000.00 AS Decimal(18, 2)), CAST(3500000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-04T08:49:57.5333333' AS DateTime2), NULL, NULL)
INSERT [dbo].[Transactions] ([Id], [CreatedDate], [LineId], [TypeId], [Section], [CallerId], [Position], [Pay], [Call], [Earn], [ThankMoney], [RealEarn], [Dead], [Alive], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (37, CAST(N'2023-04-06T17:04:24.0466667' AS DateTime2), 27, 1, 1, 15, 1, CAST(0.00 AS Decimal(18, 2)), CAST(1200000.00 AS Decimal(18, 2)), CAST(30800000.00 AS Decimal(18, 2)), CAST(400000.00 AS Decimal(18, 2)), CAST(30400000.00 AS Decimal(18, 2)), CAST(44000000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-06T10:04:29.7766667' AS DateTime2), NULL, NULL)
INSERT [dbo].[Transactions] ([Id], [CreatedDate], [LineId], [TypeId], [Section], [CallerId], [Position], [Pay], [Call], [Earn], [ThankMoney], [RealEarn], [Dead], [Alive], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (38, CAST(N'2023-04-06T17:16:22.0433333' AS DateTime2), 23, 2, 1, 1, 1, CAST(0.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), CAST(200000.00 AS Decimal(18, 2)), CAST(40000.00 AS Decimal(18, 2)), CAST(160000.00 AS Decimal(18, 2)), CAST(10800000.00 AS Decimal(18, 2)), CAST(0.00 AS Decimal(18, 2)), N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-04-06T10:16:22.1633333' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Transactions] OFF
GO
SET IDENTITY_INSERT [dbo].[Types] ON 

INSERT [dbo].[Types] ([Id], [Name], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (1, N'Thang khui 15 tay', NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:20:03.6802006' AS DateTime2), NULL, NULL)
INSERT [dbo].[Types] ([Id], [Name], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (2, N'Tuan khui T2', NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:20:12.9588029' AS DateTime2), NULL, NULL)
INSERT [dbo].[Types] ([Id], [Name], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (3, N'Ngay 1 lan', NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:20:19.4751702' AS DateTime2), NULL, NULL)
INSERT [dbo].[Types] ([Id], [Name], [Note], [CreatedBy], [CreatedOn], [LastModifiedBy], [LastModifiedOn]) VALUES (4, N'3 ngay 1 lan', NULL, N'4645a327-8081-4604-b7e4-a9dbfd3557f9', CAST(N'2023-03-25T15:20:27.8554422' AS DateTime2), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Types] OFF
GO
INSERT [HangFire].[Schema] ([Version]) VALUES (7)
GO
INSERT [HangFire].[Server] ([Id], [Data], [LastHeartbeat]) VALUES (N'laptop074:10368:fc30f6d2-4901-4e76-80c3-6a20dcfd78f4', N'{"WorkerCount":20,"Queues":["default"],"StartedAt":"2023-04-07T08:46:15.5373806Z"}', CAST(N'2023-04-07T08:47:15.990' AS DateTime))
INSERT [HangFire].[Server] ([Id], [Data], [LastHeartbeat]) VALUES (N'laptop074:16464:a0a92639-1bc0-43de-9a4e-8d7997dc5686', N'{"WorkerCount":20,"Queues":["default"],"StartedAt":"2023-04-07T08:38:43.1429939Z"}', CAST(N'2023-04-07T08:43:13.890' AS DateTime))
INSERT [HangFire].[Server] ([Id], [Data], [LastHeartbeat]) VALUES (N'laptop074:6112:36d3e851-eb2d-4005-bb5c-5663096a7e92', N'{"WorkerCount":20,"Queues":["default"],"StartedAt":"2023-04-07T08:44:01.805163Z"}', CAST(N'2023-04-07T08:44:32.480' AS DateTime))
GO
SET IDENTITY_INSERT [Identity].[RoleClaims] ON 

INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (1, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Products.View', NULL, CAST(N'2023-03-25T15:17:45.7468412' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (2, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Products.Create', NULL, CAST(N'2023-03-25T15:17:45.8365278' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (3, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Products.Edit', NULL, CAST(N'2023-03-25T15:17:45.8510200' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (4, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Products.Delete', NULL, CAST(N'2023-03-25T15:17:45.8665399' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (5, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Products.Export', NULL, CAST(N'2023-03-25T15:17:45.8824674' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (6, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Products.Search', NULL, CAST(N'2023-03-25T15:17:45.8990398' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (7, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Brands.View', NULL, CAST(N'2023-03-25T15:17:45.9282715' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (8, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Brands.Create', NULL, CAST(N'2023-03-25T15:17:45.9462826' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (9, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Brands.Edit', NULL, CAST(N'2023-03-25T15:17:45.9647273' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (10, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Brands.Delete', NULL, CAST(N'2023-03-25T15:17:45.9829933' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (11, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Brands.Export', NULL, CAST(N'2023-03-25T15:17:46.0016058' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (12, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Brands.Search', NULL, CAST(N'2023-03-25T15:17:46.0274107' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (13, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Types.View', NULL, CAST(N'2023-03-25T15:17:46.0429023' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (14, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Types.Create', NULL, CAST(N'2023-03-25T15:17:46.0588077' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (15, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Types.Edit', NULL, CAST(N'2023-03-25T15:17:46.0761727' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (16, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Types.Delete', NULL, CAST(N'2023-03-25T15:17:46.0924616' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (17, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Types.Export', NULL, CAST(N'2023-03-25T15:17:46.1087430' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (18, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Types.Search', NULL, CAST(N'2023-03-25T15:17:46.1238655' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (19, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Documents.View', NULL, CAST(N'2023-03-25T15:17:46.1414842' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (20, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Documents.Create', NULL, CAST(N'2023-03-25T15:17:46.1596002' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (21, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Documents.Edit', NULL, CAST(N'2023-03-25T15:17:46.1795623' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (22, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Documents.Delete', NULL, CAST(N'2023-03-25T15:17:46.1971207' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (23, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Documents.Search', NULL, CAST(N'2023-03-25T15:17:46.2115802' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (24, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentTypes.View', NULL, CAST(N'2023-03-25T15:17:46.2543540' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (25, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentTypes.Create', NULL, CAST(N'2023-03-25T15:17:46.2691441' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (26, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentTypes.Edit', NULL, CAST(N'2023-03-25T15:17:46.2843410' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (27, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentTypes.Delete', NULL, CAST(N'2023-03-25T15:17:46.3002610' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (28, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentTypes.Export', NULL, CAST(N'2023-03-25T15:17:46.3145630' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (29, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentTypes.Search', NULL, CAST(N'2023-03-25T15:17:46.3290799' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (30, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentExtendedAttributes.View', NULL, CAST(N'2023-03-25T15:17:46.3445757' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (31, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentExtendedAttributes.Create', NULL, CAST(N'2023-03-25T15:17:46.3615134' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (32, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentExtendedAttributes.Edit', NULL, CAST(N'2023-03-25T15:17:46.3821061' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (33, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentExtendedAttributes.Delete', NULL, CAST(N'2023-03-25T15:17:46.4027220' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (34, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentExtendedAttributes.Export', NULL, CAST(N'2023-03-25T15:17:46.4219573' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (35, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.DocumentExtendedAttributes.Search', NULL, CAST(N'2023-03-25T15:17:46.4377747' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (36, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Users.View', NULL, CAST(N'2023-03-25T15:17:46.4532216' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (37, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Users.Create', NULL, CAST(N'2023-03-25T15:17:46.4682130' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (38, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Users.Edit', NULL, CAST(N'2023-03-25T15:17:46.4841052' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (39, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Users.Delete', NULL, CAST(N'2023-03-25T15:17:46.4994121' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (40, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Users.Export', NULL, CAST(N'2023-03-25T15:17:46.5149161' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (41, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Users.Search', NULL, CAST(N'2023-03-25T15:17:46.5320610' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (42, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Roles.View', NULL, CAST(N'2023-03-25T15:17:46.5496046' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (43, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Roles.Create', NULL, CAST(N'2023-03-25T15:17:46.5656955' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (44, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Roles.Edit', NULL, CAST(N'2023-03-25T15:17:46.5832457' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (45, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Roles.Delete', NULL, CAST(N'2023-03-25T15:17:46.6036478' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (46, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Roles.Search', NULL, CAST(N'2023-03-25T15:17:46.6243580' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (47, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.RoleClaims.View', NULL, CAST(N'2023-03-25T15:17:46.6465518' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (48, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.RoleClaims.Create', NULL, CAST(N'2023-03-25T15:17:46.6622078' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (49, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.RoleClaims.Edit', NULL, CAST(N'2023-03-25T15:17:46.6790977' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (50, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.RoleClaims.Delete', NULL, CAST(N'2023-03-25T15:17:46.6960908' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (51, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.RoleClaims.Search', NULL, CAST(N'2023-03-25T15:17:46.7123320' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (52, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Communication.Chat', NULL, CAST(N'2023-03-25T15:17:46.7267585' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (53, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Preferences.ChangeLanguage', NULL, CAST(N'2023-03-25T15:17:46.7402066' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (54, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Dashboards.View', NULL, CAST(N'2023-03-25T15:17:46.7581596' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (55, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Hangfire.View', NULL, CAST(N'2023-03-25T15:17:46.7869780' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (56, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.AuditTrails.View', NULL, CAST(N'2023-03-25T15:17:46.8061093' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (57, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.AuditTrails.Export', NULL, CAST(N'2023-03-25T15:17:46.8237048' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (58, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.AuditTrails.Search', NULL, CAST(N'2023-03-25T15:17:46.8440965' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (59, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Members.View', NULL, CAST(N'2023-03-25T15:17:46.8642322' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (60, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Members.Create', NULL, CAST(N'2023-03-25T15:17:46.8821869' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (61, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Members.Edit', NULL, CAST(N'2023-03-25T15:17:46.9073163' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (62, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Members.Delete', NULL, CAST(N'2023-03-25T15:17:46.9250287' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (63, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Members.Export', NULL, CAST(N'2023-03-25T15:17:46.9417710' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (64, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Members.Search', NULL, CAST(N'2023-03-25T15:17:46.9576435' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (65, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MemberLines.View', NULL, CAST(N'2023-03-25T15:17:46.9762927' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (66, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MemberLines.Create', NULL, CAST(N'2023-03-25T15:17:46.9969231' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (67, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MemberLines.Edit', NULL, CAST(N'2023-03-25T15:17:47.0154372' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (68, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MemberLines.Delete', NULL, CAST(N'2023-03-25T15:17:47.0324998' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (69, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MemberLines.Export', NULL, CAST(N'2023-03-25T15:17:47.0520791' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (70, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MemberLines.Search', NULL, CAST(N'2023-03-25T15:17:47.0715854' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (71, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MoneyLines.View', NULL, CAST(N'2023-03-25T15:17:47.0947400' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (72, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MoneyLines.Create', NULL, CAST(N'2023-03-25T15:17:47.1177098' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (73, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MoneyLines.Edit', NULL, CAST(N'2023-03-25T15:17:47.1371959' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (74, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MoneyLines.Delete', NULL, CAST(N'2023-03-25T15:17:47.1639458' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (75, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MoneyLines.Export', NULL, CAST(N'2023-03-25T15:17:47.1864412' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (76, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.MoneyLines.Search', NULL, CAST(N'2023-03-25T15:17:47.2067502' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (77, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Transactions.View', NULL, CAST(N'2023-03-25T15:17:47.2273392' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (78, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Transactions.Create', NULL, CAST(N'2023-03-25T15:17:47.2501426' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (79, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Transactions.Edit', NULL, CAST(N'2023-03-25T15:17:47.2729204' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (80, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Transactions.Delete', NULL, CAST(N'2023-03-25T15:17:47.2956379' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (81, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Transactions.Export', NULL, CAST(N'2023-03-25T15:17:47.3200458' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (82, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Transactions.Search', NULL, CAST(N'2023-03-25T15:17:47.3463070' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (83, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Reports.View', NULL, CAST(N'2023-03-31T01:45:31.3513014' AS DateTime2), NULL, NULL, NULL, NULL)
INSERT [Identity].[RoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue], [CreatedBy], [CreatedOn], [Description], [Group], [LastModifiedBy], [LastModifiedOn]) VALUES (84, N'e048e89f-b173-45f3-8782-3489f220b509', N'Permission', N'Permissions.Reports.Export', NULL, CAST(N'2023-04-06T10:02:50.0821177' AS DateTime2), NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [Identity].[RoleClaims] OFF
GO
INSERT [Identity].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedBy], [CreatedOn], [Description], [LastModifiedBy], [LastModifiedOn]) VALUES (N'44274ba1-2da7-4481-b216-50a606804eda', N'Basic', N'BASIC', N'45900779-cf9b-450f-97b5-dfb8094065ee', NULL, CAST(N'2023-03-25T15:17:47.3898230' AS DateTime2), N'Basic role with default permissions', NULL, NULL)
INSERT [Identity].[Roles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [CreatedBy], [CreatedOn], [Description], [LastModifiedBy], [LastModifiedOn]) VALUES (N'e048e89f-b173-45f3-8782-3489f220b509', N'Administrator', N'ADMINISTRATOR', N'209374e8-58ca-44bd-a381-af33a6e2296c', NULL, CAST(N'2023-03-25T15:17:44.4757639' AS DateTime2), N'Administrator role with full permissions', NULL, CAST(N'2023-04-06T10:02:50.0822752' AS DateTime2))
GO
INSERT [Identity].[UserRoles] ([UserId], [RoleId]) VALUES (N'a0824a62-73a0-4eba-9329-df84dd49342a', N'44274ba1-2da7-4481-b216-50a606804eda')
INSERT [Identity].[UserRoles] ([UserId], [RoleId]) VALUES (N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'e048e89f-b173-45f3-8782-3489f220b509')
GO
INSERT [Identity].[Users] ([Id], [FirstName], [LastName], [CreatedBy], [ProfilePictureDataUrl], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted], [DeletedOn], [IsActive], [RefreshToken], [RefreshTokenExpiryTime], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4645a327-8081-4604-b7e4-a9dbfd3557f9', N'Mukesh', N'Murugan', NULL, NULL, CAST(N'2023-03-25T15:17:45.2997101' AS DateTime2), NULL, CAST(N'2023-04-06T10:35:02.3518088' AS DateTime2), 0, NULL, 1, N'K29WyZXkMbyZg2689ExSogy+//E9Ym6kWebTZ5YFR+8=', CAST(N'2023-04-13T17:35:02.3224663' AS DateTime2), N'mukesh', N'MUKESH', N'mukesh@blazorhero.com', N'MUKESH@BLAZORHERO.COM', 1, N'AQAAAAEAACcQAAAAEK3eMED54nfcTmErTvMNVjhdj9ATon4CEpP1cq+o8xGQ0+FThgAbnFdAjfC330Ba4w==', N'6MECFAAPLRPVQMIKLP7WN65DEZEGSASY', N'a10d5c73-a580-4c67-987c-9a4485a60ea0', NULL, 1, 0, NULL, 1, 0)
INSERT [Identity].[Users] ([Id], [FirstName], [LastName], [CreatedBy], [ProfilePictureDataUrl], [CreatedOn], [LastModifiedBy], [LastModifiedOn], [IsDeleted], [DeletedOn], [IsActive], [RefreshToken], [RefreshTokenExpiryTime], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a0824a62-73a0-4eba-9329-df84dd49342a', N'John', N'Doe', NULL, NULL, CAST(N'2023-03-25T15:17:47.4454910' AS DateTime2), NULL, CAST(N'2023-03-25T15:17:47.4797115' AS DateTime2), 0, NULL, 1, NULL, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'johndoe', N'JOHNDOE', N'john@blazorhero.com', N'JOHN@BLAZORHERO.COM', 1, N'AQAAAAEAACcQAAAAEKBEIBqjMRH4QKhHI7kfO1mvYdz+2s/AVbXjpppjQSLqaSQ2pWC7fdf/nMoQFhnNmA==', N'L64NRWCCUA2IYZ3S3PS2CXG3TBDOOMYP', N'acf8082d-da81-4535-9090-3e13f4112d4d', NULL, 1, 0, NULL, 1, 0)
GO
ALTER TABLE [dbo].[Documents] ADD  DEFAULT ((0)) FOR [DocumentTypeId]
GO
ALTER TABLE [dbo].[MemberLines] ADD  DEFAULT ((0)) FOR [DeadSection]
GO
ALTER TABLE [dbo].[Members] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[MoneyLines] ADD  DEFAULT ((0)) FOR [CurrentSection]
GO
ALTER TABLE [Identity].[RoleClaims] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedOn]
GO
ALTER TABLE [Identity].[Roles] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedOn]
GO
ALTER TABLE [dbo].[ChatHistory]  WITH CHECK ADD  CONSTRAINT [FK_ChatHistory_Users_FromUserId] FOREIGN KEY([FromUserId])
REFERENCES [Identity].[Users] ([Id])
GO
ALTER TABLE [dbo].[ChatHistory] CHECK CONSTRAINT [FK_ChatHistory_Users_FromUserId]
GO
ALTER TABLE [dbo].[ChatHistory]  WITH CHECK ADD  CONSTRAINT [FK_ChatHistory_Users_ToUserId] FOREIGN KEY([ToUserId])
REFERENCES [Identity].[Users] ([Id])
GO
ALTER TABLE [dbo].[ChatHistory] CHECK CONSTRAINT [FK_ChatHistory_Users_ToUserId]
GO
ALTER TABLE [dbo].[DocumentExtendedAttributes]  WITH CHECK ADD  CONSTRAINT [FK_DocumentExtendedAttributes_Documents_EntityId] FOREIGN KEY([EntityId])
REFERENCES [dbo].[Documents] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DocumentExtendedAttributes] CHECK CONSTRAINT [FK_DocumentExtendedAttributes_Documents_EntityId]
GO
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD  CONSTRAINT [FK_Documents_DocumentTypes_DocumentTypeId] FOREIGN KEY([DocumentTypeId])
REFERENCES [dbo].[DocumentTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Documents] CHECK CONSTRAINT [FK_Documents_DocumentTypes_DocumentTypeId]
GO
ALTER TABLE [dbo].[MemberLines]  WITH CHECK ADD  CONSTRAINT [FK_MemberLines_Members_MemberId] FOREIGN KEY([MemberId])
REFERENCES [dbo].[Members] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberLines] CHECK CONSTRAINT [FK_MemberLines_Members_MemberId]
GO
ALTER TABLE [dbo].[MemberLines]  WITH CHECK ADD  CONSTRAINT [FK_MemberLines_MoneyLines_LineId] FOREIGN KEY([LineId])
REFERENCES [dbo].[MoneyLines] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MemberLines] CHECK CONSTRAINT [FK_MemberLines_MoneyLines_LineId]
GO
ALTER TABLE [dbo].[MoneyLines]  WITH CHECK ADD  CONSTRAINT [FK_MoneyLines_Types_TypeId] FOREIGN KEY([TypeId])
REFERENCES [dbo].[Types] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MoneyLines] CHECK CONSTRAINT [FK_MoneyLines_Types_TypeId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Brands_BrandId] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Brands_BrandId]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Members_CallerId] FOREIGN KEY([CallerId])
REFERENCES [dbo].[Members] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Members_CallerId]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_MoneyLines_LineId] FOREIGN KEY([LineId])
REFERENCES [dbo].[MoneyLines] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_MoneyLines_LineId]
GO
ALTER TABLE [HangFire].[JobParameter]  WITH CHECK ADD  CONSTRAINT [FK_HangFire_JobParameter_Job] FOREIGN KEY([JobId])
REFERENCES [HangFire].[Job] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [HangFire].[JobParameter] CHECK CONSTRAINT [FK_HangFire_JobParameter_Job]
GO
ALTER TABLE [HangFire].[State]  WITH CHECK ADD  CONSTRAINT [FK_HangFire_State_Job] FOREIGN KEY([JobId])
REFERENCES [HangFire].[Job] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [HangFire].[State] CHECK CONSTRAINT [FK_HangFire_State_Job]
GO
ALTER TABLE [Identity].[RoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_RoleClaims_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [Identity].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Identity].[RoleClaims] CHECK CONSTRAINT [FK_RoleClaims_Roles_RoleId]
GO
ALTER TABLE [Identity].[UserClaims]  WITH CHECK ADD  CONSTRAINT [FK_UserClaims_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [Identity].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Identity].[UserClaims] CHECK CONSTRAINT [FK_UserClaims_Users_UserId]
GO
ALTER TABLE [Identity].[UserLogins]  WITH CHECK ADD  CONSTRAINT [FK_UserLogins_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [Identity].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Identity].[UserLogins] CHECK CONSTRAINT [FK_UserLogins_Users_UserId]
GO
ALTER TABLE [Identity].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [Identity].[Roles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Identity].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Roles_RoleId]
GO
ALTER TABLE [Identity].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [Identity].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Identity].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_Users_UserId]
GO
ALTER TABLE [Identity].[UserTokens]  WITH CHECK ADD  CONSTRAINT [FK_UserTokens_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [Identity].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [Identity].[UserTokens] CHECK CONSTRAINT [FK_UserTokens_Users_UserId]
GO
/****** Object:  StoredProcedure [dbo].[AllMemberReport]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AllMemberReport]
AS
BEGIN
    SELECT m.Name,
		SUM(CASE WHEN t.CallerId = ml.MemberId and t.Position = ml.Position THEN t.Earn ELSE 0 END) AS Earn, 
		SUM(CASE WHEN t.CallerId <> ml.MemberId AND ml.DeadSection = 0 THEN mo.Money - t.Call
				WHEN t.CallerId <> ml.MemberId AND ml.DeadSection<> t.Section THEN mo.Money ELSE 0 END) AS Pay,
		SUM(CASE WHEN t.CallerId = ml.MemberId AND t.Position = ml.Position THEN t.ThankMoney ELSE 0 END) AS ThankMoney,
		SUM(CASE WHEN t.Alive IS NULL THEN 0 ELSE t.Alive END) As Alive, 
		SUM(CASE WHEN t.CallerId = ml.MemberId AND t.Position = ml.Position THEN t.Dead ELSE 0 END) AS Dead
	FROM Members m
	JOIN MemberLines ml ON m.Id = ml.MemberId
	JOIN MoneyLines mo ON mo.Id = ml.LineId
	LEFT JOIN Transactions t ON mo.Id = t.LineId
	GROUP BY m.Name;
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteMember]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteMember]
	@Memberid int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   UPDATE Members
   SET IsDeleted = 1
   WHERE Id = @Memberid
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteMemberLines]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteMemberLines]
	@Lineid int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DELETE MemberLines WHERE LineId = @Lineid
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteTransaction]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteTransaction]
   @id int
AS
BEGIN
   SET NOCOUNT ON;

   DECLARE @callerid int, @position int, @lineid int
   -- Get CallerId and Position from Transactions table
   SELECT @callerid = CallerId, @position = Position, @lineid = LineId
   FROM Transactions
   WHERE Id = @id

   IF @@ROWCOUNT = 0
   BEGIN
      -- Handle error: record not found
      RETURN;
   END

   BEGIN TRANSACTION

   -- Delete records from Transaction
   DELETE FROM Transactions WHERE Id = @id
	
	-- Update data in MoneyLines
	UPDATE MoneyLines
   SET CurrentSection = CurrentSection-1
   WHERE Id = @lineid

   UPDATE MoneyLines
   SET StatusId = 1
   WHERE Id = @lineid AND CurrentSection = 0

   -- Update data in MemberLines
   UPDATE MemberLines
   SET DeadSection = 0
   WHERE LineId = @lineid AND MemberId = @callerid AND Position = @position

   IF @@ERROR <> 0
   BEGIN
	  ROLLBACK TRANSACTION
	  -- Handle the error
   END
   ELSE
   BEGIN
	  COMMIT TRANSACTION
   END
END

GO
/****** Object:  StoredProcedure [dbo].[GetReadyCallerByLineId]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetReadyCallerByLineId]
    @LineId INT
AS
BEGIN
    SELECT MemberLines.MemberId, Members.Name, MemberLines.Position,
	CASE
		WHEN EXISTS(SELECT CallerId FROM Transactions WHERE CallerId = MemberLines.MemberId and Position = MemberLines.Position and LineId = @Lineid) 
		THEN 1 ELSE 0 END AS IsDead
    FROM MemberLines
	join Members ON MemberLines.MemberId = Members.Id
	where MemberLines.LineId = @Lineid
	GROUP BY MemberLines.MemberId, Members.Name, MemberLines.Position
END
GO
/****** Object:  StoredProcedure [dbo].[GetTransactionInfoByLineId]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetTransactionInfoByLineId]
    @LineId INT
AS
BEGIN
	SELECT ty.Name As TypeName, mo.currentSection, mo.Money, SUM(t.ThankMoney) AS TotalThankMoney 
	FROM Transactions t
	JOIN MoneyLines mo on t.LineId = mo.Id
	JOIN Types ty on mo.TypeId = ty.Id
	WHERE t.LineId = @LineId
	GROUP BY ty.Name, mo.currentSection, mo.Money
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTransaction]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertTransaction]
   @createddate datetime,
   @lineid int,
   @typeid int,
   @section int,
   @callerid int,
   @position int,
   @pay decimal,
   @call decimal,
   @earn decimal,
   @thankmoney decimal,
   @realearn decimal,
   @dead decimal,
   @alive decimal,
   @createdby nvarchar(MAX),
   @createdon datetime2,
   @id int OUTPUT
AS
BEGIN
   SET NOCOUNT ON;

   BEGIN TRANSACTION

   -- Insert data into Transactions
   INSERT INTO Transactions(CreatedDate, LineId, TypeId, Section, CallerId, Position, Pay, Call, Earn, ThankMoney, RealEarn, Dead, Alive, CreatedBy, CreatedOn)
   VALUES (@createddate, @lineid, @typeid, @section, @callerid, @position, @pay, @call, @earn, @thankmoney, @realearn, @dead, @alive, @createdby, @createdon)

   -- Update data in Money Lines
   UPDATE MoneyLines
   SET StatusId = 2
   WHERE Id = @lineid AND StatusId = 1

   UPDATE MoneyLines
   SET CurrentSection = @section
   WHERE Id = @lineid

   -- Update data in MemberLines
   UPDATE MemberLines
   SET DeadSection = @section
   WHERE LineId = @lineid AND MemberId = @callerid AND Position = @position

   IF @@ERROR <> 0
   BEGIN
      ROLLBACK TRANSACTION
      -- Handle the error
   END
   ELSE
   BEGIN
      COMMIT TRANSACTION
	  SET @id= SCOPE_IDENTITY()
   END
END
GO
/****** Object:  StoredProcedure [dbo].[SingleMemberReport]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SingleMemberReport]
    @Memberid INT
AS
BEGIN
     SELECT ml.LineId, 
       ml.MemberId,
	   m.CreatedDate,
	   m.Name,
	   m.currentSection,
       SUM(CASE WHEN t.CallerId = ml.MemberId AND t.Section = ml.DeadSection THEN t.Earn ELSE 0 END) AS Earn, 
       SUM(CASE WHEN t.CallerId <> ml.MemberId AND ml.DeadSection = 0
	   THEN m.Money - t.Call
	   WHEN t.CallerId <> ml.MemberId AND ml.DeadSection<> t.Section
	   THEN m.Money
	   ELSE
	   0 END) AS Pay
FROM   MemberLines ml 
       JOIN Transactions t 
         ON ml.LineId = t.LineId 
       JOIN MoneyLines m 
         ON ml.LineId = m.Id 
       JOIN Members me 
         ON t.CallerId = me.Id 
WHERE  ml.MemberId = @Memberid
GROUP  BY ml.LineId,
m.CreatedDate,
m.Name,
m.currentSection,
          ml.MemberId
HAVING SUM(CASE WHEN t.CallerId = ml.MemberId AND t.Section = ml.DeadSection THEN t.Earn ELSE 0 END) > 0 OR
       SUM(CASE WHEN t.CallerId <> ml.MemberId 
	   THEN m.Money - t.Call
	   WHEN t.CallerId <> ml.MemberId AND ml.DeadSection> t.Section
	   THEN m.Money
	   ELSE
	   0 END) > 0;

END
GO
/****** Object:  StoredProcedure [dbo].[ThankMoneyReport]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ThankMoneyReport]
    @Ownerid INT
AS
BEGIN
    SELECT m.CreatedDate, m.Name, m.Quantity, m.currentSection, 
		SUM(CASE WHEN t.ThankMoney Is NULL THEN 0 ELSE t.ThankMoney END) AS ThankMoney 
	FROM MoneyLines m
	LEFT JOIN Transactions t on m.Id = t.LineId 
	WHERE OwnerId = @Ownerid
	GROUP BY m.CreatedDate, m.Name, m.Quantity, m.currentSection;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTransaction]    Script Date: 4/7/2023 3:52:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateTransaction]
   @id int,
   @lineid int,
   @typeid int,
   @section int,
   @callerid int,
   @position int,
   @pay decimal,
   @call decimal,
   @earn decimal,
   @thankmoney decimal,
   @realearn decimal,
   @dead decimal,
   @alive decimal 
AS
BEGIN
   SET NOCOUNT ON;
   DECLARE @oldlineid int, @oldposition int, @oldcallerid int, @oldsection int
   -- Get CallerId and Position from Transactions table
   SELECT @oldlineid = LineId, @oldposition = Position, @oldcallerid = CallerId, @oldsection = Section
   FROM Transactions
   WHERE Id = @id

   BEGIN TRANSACTION

   -- Insert data into Transactions
   UPDATE Transactions
   SET LineId = @lineid, TypeId = @typeid, Section = @section, CallerId = @callerid, Position = @position, Pay = @pay, Call = @call, Earn = @earn, ThankMoney = @thankmoney, RealEarn = @realearn, Dead = @dead, Alive = @alive
   WHERE Id = @id

   -- Update data in Money Lines
   -- Update for new line
   UPDATE MoneyLines
   SET CurrentSection = @section, StatusId = 2
   WHERE Id = @lineid AND @lineid <> @oldlineid

   -- Update for old line
   UPDATE MoneyLines
   SET CurrentSection = @oldsection -1
   WHERE Id = @oldlineid AND @lineid <> @oldlineid

   UPDATE MoneyLines
   SET StatusId = 1
   WHERE Id = @oldlineid AND @lineid <> @oldlineid AND CurrentSection = 0

   -- Update data in MemberLines
   UPDATE MemberLines
   SET DeadSection = @section
   WHERE LineId = @lineid AND MemberId = @callerid AND Position = @position

   UPDATE MemberLines
   SET DeadSection = 0
   WHERE LineId = @oldlineid AND MemberId = @oldcallerid AND Position = @oldposition

   IF @@ERROR <> 0
   BEGIN
      ROLLBACK TRANSACTION
      -- Handle the error
   END
   ELSE
   BEGIN
      COMMIT TRANSACTION
	  SET @id= SCOPE_IDENTITY()
   END
END
GO
