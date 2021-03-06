USE [master]
GO
/****** Object:  Database [ShoeShopManager]    Script Date: 7/15/2020 7:24:59 PM ******/
CREATE DATABASE [ShoeShopManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ASMDBI202', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ASMDBI202.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ASMDBI202_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\ASMDBI202_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ShoeShopManager] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShoeShopManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShoeShopManager] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShoeShopManager] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShoeShopManager] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShoeShopManager] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShoeShopManager] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShoeShopManager] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShoeShopManager] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShoeShopManager] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShoeShopManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShoeShopManager] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShoeShopManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShoeShopManager] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShoeShopManager] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShoeShopManager] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShoeShopManager] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShoeShopManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShoeShopManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShoeShopManager] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShoeShopManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShoeShopManager] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShoeShopManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShoeShopManager] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShoeShopManager] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShoeShopManager] SET  MULTI_USER 
GO
ALTER DATABASE [ShoeShopManager] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShoeShopManager] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShoeShopManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShoeShopManager] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ShoeShopManager] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ShoeShopManager', N'ON'
GO
USE [ShoeShopManager]
GO
/****** Object:  UserDefinedFunction [dbo].[countProductbyIDshop]    Script Date: 7/15/2020 7:24:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[countProductbyIDshop]( @Idshop nvarchar(5))
Returns nvarchar(10) as
begin 
Return
(
select 'p'+ CONVERT(nvarchar(10),(

select  CONVERT(int,@Idshop) *1000 + COUNT( pr.IDProduct)
from Products pr, Products_Shops ps

where pr.IDProduct =ps.IDProduct
	and ps.IDShops = @Idshop)))
	end
GO
/****** Object:  UserDefinedFunction [dbo].[PriceProduct]    Script Date: 7/15/2020 7:24:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[PriceProduct](@IdProduct nvarchar(30))
Returns int
as
begin 
Return (
select 
	case 
		when p.Discount = '50%' then p.Price/100 * 50
		when p.Discount = '60%' then p.Price/100 * 60
		END as 'giá sau khi giảm'
						
	from Products p
	where IDProduct = @IdProduct
			)
END

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 7/15/2020 7:24:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[CusPhone] [char](20) NOT NULL,
	[FullName] [nvarchar](15) NOT NULL,
	[Address] [nvarchar](30) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CusPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 7/15/2020 7:24:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[IdEmployee] [nvarchar](10) NOT NULL,
	[Password] [nvarchar](20) NULL,
	[NameEmployee] [nvarchar](50) NULL,
	[IDShops] [nvarchar](5) NULL,
	[AddressEmployee] [nvarchar](50) NULL,
	[SupervisorEmployee] [nvarchar](10) NULL,
	[NumberPhoneEmployee] [nvarchar](12) NULL,
	[Role] [nvarchar](10) NULL,
	[Status] [nvarchar](10) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[IdEmployee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Oderdetail]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oderdetail](
	[IDOrther] [int] NOT NULL,
	[IDProduct] [nvarchar](30) NOT NULL,
	[Price] [float] NULL,
	[Discount] [nvarchar](10) NULL,
	[Quantity] [int] NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Oderdetail_1] PRIMARY KEY CLUSTERED 
(
	[IDOrther] ASC,
	[IDProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orderproduct]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Orderproduct](
	[IDOrther] [int] NOT NULL,
	[CusPhone] [char](20) NULL,
	[IdEmployee] [nvarchar](10) NULL,
	[DateTimeOrther] [datetime] NULL,
	[PriceFinal] [float] NULL,
	[Quantity] [int] NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[IDOrther] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Productlines]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productlines](
	[IDProductlines] [nvarchar](30) NOT NULL,
	[NameProductlines] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Productlines] PRIMARY KEY CLUSTERED 
(
	[IDProductlines] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[IDProduct] [nvarchar](30) NOT NULL,
	[IDProductType] [nvarchar](30) NULL,
	[NameProduct] [nvarchar](30) NULL,
	[Size] [float] NULL,
	[Price] [int] NULL,
	[Discount] [nvarchar](10) NULL,
	[Quantity] [int] NULL,
	[Status] [nvarchar](30) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[IDProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products_Shops]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products_Shops](
	[IDShops] [nvarchar](5) NOT NULL,
	[IDProduct] [nvarchar](30) NOT NULL,
	[Status] [nvarchar](10) NULL,
 CONSTRAINT [PK_Products_Shops] PRIMARY KEY CLUSTERED 
(
	[IDShops] ASC,
	[IDProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[IDProductType] [nvarchar](30) NOT NULL,
	[IDProductlines] [nvarchar](30) NULL,
	[NameProductType] [nvarchar](50) NULL,
	[Quantity] [int] NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[IDProductType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shops]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shops](
	[IDShops] [nvarchar](5) NOT NULL,
	[NameShop] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Shops] PRIMARY KEY CLUSTERED 
(
	[IDShops] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplier](
	[IDSupplier] [nvarchar](30) NOT NULL,
	[NameSupplier] [nvarchar](30) NULL,
	[Phone] [char](20) NULL,
	[AddressSupplier] [nvarchar](120) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[IDSupplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[Cart]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[Cart](@IdOrther int)
Returns table as

Return (
select od.IDOrther , p.IDProduct,  p.NameProduct, p.Size 
		
	from Oderdetail od, Products p
	where od.IDOrther = @IdOrther
		and od.IDProduct = p.IDProduct
			)

GO
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'01023366544         ', N'lamvy25789', N'Tan Chau ')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'01233669587         ', N'hoangkiet', N'Q9')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'0123456789          ', N'ha', N'123')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'01255478789         ', N'vivuong1511', N'binh thạnh')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'01255778475         ', N'vuongkimuyen', N'Tan Chau')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'01255879596         ', N'lynhatthanh', N'Tan Chau')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'01255886979         ', N'hieucute', N'Q9')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'01255887415         ', N'minhtien11', N'Long AN ')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'01255887963         ', N'minh1210', N'20/120 Dong bac')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'01255998678         ', N'minhduc11', N'Long An ')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'02356998788         ', N'khoa2211', N'20/120 Dong bac')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'02366998958         ', N'nhi2547', N'Tan Chau')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'03698877547         ', N'toan1548', N'Q9')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'09155556738         ', N'Hoang', N'123 Le Loi')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'1                   ', N'1', N'1')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'11111111            ', N'111111111', N'111111111111')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'111111111           ', N'1111111111', N'111111111111111')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'123                 ', N'123', N'23')
INSERT [dbo].[Customer] ([CusPhone], [FullName], [Address]) VALUES (N'123123              ', N'f', N'f')
INSERT [dbo].[Employee] ([IdEmployee], [Password], [NameEmployee], [IDShops], [AddressEmployee], [SupervisorEmployee], [NumberPhoneEmployee], [Role], [Status]) VALUES (N'1', N'1', N'TranKhoa', N'1', N'1 Binh Hung Hoa', N'9', N'0901085027', N'Cashier', N'On')
INSERT [dbo].[Employee] ([IdEmployee], [Password], [NameEmployee], [IDShops], [AddressEmployee], [SupervisorEmployee], [NumberPhoneEmployee], [Role], [Status]) VALUES (N'2', N'2', N'Hoang', N'2', N'499 Quang Trung', N'9', N'0999887876', N'Admin', N'On')
INSERT [dbo].[Employee] ([IdEmployee], [Password], [NameEmployee], [IDShops], [AddressEmployee], [SupervisorEmployee], [NumberPhoneEmployee], [Role], [Status]) VALUES (N'9', N'9', N'Teacher Kiem ', N'1', N'9 yersin', NULL, N'090115408', N'Manager', N'On')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (100, N'p1039', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (101, N'p1036', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (102, N'p1002', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (102, N'p1003', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (103, N'p1004', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (104, N'p1005', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (105, N'p1006', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (106, N'p1007', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (107, N'p1008', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (108, N'p1009', 2450000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (108, N'p1010', 1500000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (108, N'p1011', 1500000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (109, N'p1011', 1500000, NULL, 2, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (109, N'p1012', 1500000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (110, N'p1014', 1500000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (111, N'p1018', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (112, N'p1019', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (113, N'p1020', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (114, N'p1023', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (115, N'p1012', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (116, N'p1007', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (117, N'p1023', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (118, N'p1029', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (119, N'p1034', 1100000, NULL, 2, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (120, N'p1025', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (121, N'p1034', 1100000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (122, N'p1004', 2400000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (122, N'p1005', 2250000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (123, N'p1004', 2400000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (125, N'p1004', 2400000, NULL, 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (155, N'p1000', 4500000, N'50', 50, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (156, N'p1000', 4500000, N'4500000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (156, N'p1011', 3000000, N'3000000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (156, N'p1013', 12000000, N'3000000', 4, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (157, N'p1000', 18000000, N'4500000', 4, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (157, N'p1002', 13500000, N'13500000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (157, N'p1004', 4800000, N'4800000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (157, N'p1019', 2400000, N'2400000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (157, N'p1033', 9600000, N'9600000', 4, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (157, N'p1034', 1500000, N'1500000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (157, N'p1040', 2400000, N'2400000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (158, N'p1000', 13500000, N'13500000', 3, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (158, N'p1001', 9000000, N'9000000', 2, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (159, N'p1000', 13500000, N'13500000', 3, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (160, N'p1000', 22500000, N'22500000', 5, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (160, N'p1001', 225000000, N'225000000', 10, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (161, N'p1000', 45000000, N'4500000', 10, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (162, N'p1000', 45000000, N'4500000', 10, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (163, N'p1000', 45000000, N'4500000', 10, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (164, N'p1000', 4500000, N'4500000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (166, N'p1000', 4500000, N'4500000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (167, N'p1000', 4500000, N'4500000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (167, N'p1002', 4700000, N'4700000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (168, N'p1002', 14100000, N'4700000', 3, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (169, N'p1002', 4700000, N'4700000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (169, N'p1004', 120000000, N'4800000', 25, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (169, N'p1005', 81000000, N'4500000', 18, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (170, N'p1002', 47000000, N'47000000', 10, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (170, N'p1003', 47000000, N'47000000', 10, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (171, N'p1000', 13500000, N'4500000', 3, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (172, N'p1003', 14100000, N'4700000', 3, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (172, N'p1009', 4700000, N'4700000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (173, N'p1002', 4700000, N'4700000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (173, N'p1003', 4700000, N'4700000', 1, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (174, N'p1012', 45000000, N'45000000', 15, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (175, N'p1003', 9400000, N'4700000', 2, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (175, N'p1004', 9600000, N'4800000', 2, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (176, N'p1002', 14100000, N'4700000', 3, N'Passed')
INSERT [dbo].[Oderdetail] ([IDOrther], [IDProduct], [Price], [Discount], [Quantity], [Status]) VALUES (176, N'p1003', 14100000, N'4700000', 3, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (100, N'01023366544         ', NULL, CAST(N'2020-03-08 08:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (101, N'01023366544         ', NULL, CAST(N'2010-04-02 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (102, N'01023366544         ', NULL, CAST(N'2020-03-10 09:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (103, N'01233669587         ', NULL, CAST(N'2019-06-03 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (104, N'01255778475         ', NULL, CAST(N'2019-09-12 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (105, N'01255778475         ', NULL, CAST(N'2019-06-07 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (106, N'01233669587         ', NULL, CAST(N'2019-10-05 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (107, N'01255778475         ', NULL, CAST(N'2020-03-03 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (108, N'01255778475         ', NULL, CAST(N'2019-08-01 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (109, N'01233669587         ', NULL, CAST(N'2019-01-10 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (110, N'01255778475         ', NULL, CAST(N'2019-07-10 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (111, N'01255887963         ', NULL, CAST(N'2020-01-02 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (112, N'01255887963         ', NULL, CAST(N'2019-10-03 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (113, N'01255778475         ', NULL, CAST(N'2019-03-06 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (114, N'01255887963         ', NULL, CAST(N'2019-08-08 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (115, N'01255778475         ', NULL, CAST(N'2019-07-06 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (116, N'02366998958         ', NULL, CAST(N'2019-04-08 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (117, N'02366998958         ', NULL, CAST(N'2019-05-02 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (118, N'02356998788         ', NULL, CAST(N'2019-08-01 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (119, N'02356998788         ', NULL, CAST(N'2019-01-05 00:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (120, N'01255478789         ', NULL, CAST(N'2020-03-10 09:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (121, N'01255478789         ', NULL, CAST(N'2020-03-10 09:00:00.000' AS DateTime), 1440000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (122, N'03698877547         ', NULL, CAST(N'2020-05-10 23:44:17.787' AS DateTime), 0, 0, N'onthecart')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (123, N'03698877547         ', NULL, CAST(N'2020-05-11 00:14:46.007' AS DateTime), 2400000, 1, N'onthecart')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (124, N'01255886979         ', NULL, CAST(N'2020-06-06 00:00:00.000' AS DateTime), 0, 0, N'onthecart')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (125, N'01255886979         ', NULL, CAST(N'2020-05-11 07:46:41.207' AS DateTime), 2400000, 1, N'onthecart')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (126, N'01023366544         ', N'1', CAST(N'2020-06-28 15:48:08.967' AS DateTime), 112254, 12544, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (127, N'01023366544         ', N'1', CAST(N'2020-06-28 15:55:04.583' AS DateTime), 112254, 12544, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (128, N'01023366544         ', N'1', CAST(N'2020-06-28 15:55:18.243' AS DateTime), 112254, 12544, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (129, N'01233669587         ', N'1', CAST(N'2020-06-28 16:25:56.360' AS DateTime), 1000000000, 10, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (130, N'01023366544         ', N'1', CAST(N'2020-06-28 16:26:15.153' AS DateTime), 112254, 12544, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (131, N'01233669587         ', N'1', CAST(N'2020-06-28 16:26:51.250' AS DateTime), 1000000000, 10, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (132, N'01023366544         ', N'1', CAST(N'2020-06-28 16:26:57.227' AS DateTime), 112254, 12544, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (133, N'01233669587         ', N'1', CAST(N'2020-06-28 16:30:48.750' AS DateTime), 1000000000, 10, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (134, N'01233669587         ', N'1', CAST(N'2020-06-28 16:37:27.017' AS DateTime), 1000000000, 10, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (135, N'01233669587         ', N'1', CAST(N'2020-06-28 16:46:59.800' AS DateTime), 1000000000, 10, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (136, N'01233669587         ', N'1', CAST(N'2020-06-28 17:45:27.353' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (137, N'01233669587         ', N'1', CAST(N'2020-06-28 17:45:33.720' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (138, N'01023366544         ', N'1', CAST(N'2020-06-29 12:07:24.613' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (139, N'01023366544         ', N'1', CAST(N'2020-06-29 12:07:47.363' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (140, N'01233669587         ', N'1', CAST(N'2020-06-29 12:14:49.490' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (141, N'01233669587         ', N'1', CAST(N'2020-06-29 12:17:24.577' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (142, N'01233669587         ', N'1', CAST(N'2020-06-29 12:19:04.470' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (143, N'01233669587         ', N'1', CAST(N'2020-06-29 12:19:20.470' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (144, N'01023366544         ', N'1', CAST(N'2020-06-29 12:33:48.420' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (145, N'01023366544         ', N'1', CAST(N'2020-06-29 12:34:52.283' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (146, N'01023366544         ', N'1', CAST(N'2020-06-29 13:04:42.243' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (147, N'01023366544         ', N'1', CAST(N'2020-06-29 13:06:21.060' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (148, N'03698877547         ', N'1', CAST(N'2020-06-29 13:13:57.963' AS DateTime), 0, 0, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (149, N'01233669587         ', N'1', CAST(N'2020-06-29 15:56:37.707' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (150, N'01233669587         ', N'1', CAST(N'2020-06-29 15:57:30.407' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (151, N'01233669587         ', N'1', CAST(N'2020-06-29 15:59:48.717' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (152, N'01233669587         ', N'1', CAST(N'2020-06-29 16:01:32.940' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (153, N'01233669587         ', N'1', CAST(N'2020-06-29 16:07:59.330' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (154, N'01233669587         ', N'1', CAST(N'2020-06-29 16:08:46.000' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (155, N'01233669587         ', N'1', CAST(N'2020-06-29 16:14:18.483' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (156, N'01023366544         ', N'1', CAST(N'2020-06-29 16:25:22.453' AS DateTime), 19500000, 12, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (157, N'01023366544         ', N'1', CAST(N'2020-06-29 16:27:58.877' AS DateTime), 52200000, 56, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (158, N'01023366544         ', N'1', CAST(N'2020-06-29 16:35:47.500' AS DateTime), 22500000, 8, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (159, N'01023366544         ', N'1', CAST(N'2020-06-29 16:38:33.523' AS DateTime), 13500000, 3, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (160, N'01023366544         ', N'1', CAST(N'2020-06-29 16:40:11.533' AS DateTime), 247500000, 20, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (161, N'01255478789         ', N'1', CAST(N'2020-06-29 17:02:28.653' AS DateTime), 45000000, 11, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (162, N'01255478789         ', N'1', CAST(N'2020-06-29 17:02:59.777' AS DateTime), 45000000, 11, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (163, N'01255478789         ', N'1', CAST(N'2020-06-29 17:03:28.477' AS DateTime), 45000000, 11, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (164, N'123123              ', N'1', CAST(N'2020-06-29 17:36:52.407' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (165, N'123                 ', N'1', CAST(N'2020-06-30 09:57:15.647' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (166, N'123                 ', N'1', CAST(N'2020-06-30 09:57:20.907' AS DateTime), 4500000, 1, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (167, N'123                 ', N'1', CAST(N'2020-06-30 09:57:25.950' AS DateTime), 9200000, 3, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (168, N'0123456789          ', N'1', CAST(N'2020-07-01 13:50:59.290' AS DateTime), 14100000, 6, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (169, N'0123456789          ', N'1', CAST(N'2020-07-01 14:03:10.180' AS DateTime), 205700000, 692, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (170, N'0123456789          ', N'1', CAST(N'2020-07-01 14:05:09.770' AS DateTime), 94000000, 722, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (171, N'01023366544         ', N'1', CAST(N'2020-07-05 14:51:34.930' AS DateTime), 6750000, 3, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (172, N'01023366544         ', N'1', CAST(N'2020-07-05 14:52:58.443' AS DateTime), 9400000, 4, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (173, N'01023366544         ', N'1', CAST(N'2020-07-05 14:54:28.410' AS DateTime), 5640000, 2, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (174, N'0123456789          ', N'1', CAST(N'2020-07-05 15:22:04.073' AS DateTime), 22500000, 15, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (175, N'0123456789          ', N'1', CAST(N'2020-07-07 14:46:18.940' AS DateTime), 9500000, 4, N'Passed')
INSERT [dbo].[Orderproduct] ([IDOrther], [CusPhone], [IdEmployee], [DateTimeOrther], [PriceFinal], [Quantity], [Status]) VALUES (176, N'0123456789          ', N'1', CAST(N'2020-07-07 14:47:19.223' AS DateTime), 14100000, 6, N'Passed')
INSERT [dbo].[Productlines] ([IDProductlines], [NameProductlines], [Quantity], [Status]) VALUES (N'FM', N'FeMale', 810, N'On')
INSERT [dbo].[Productlines] ([IDProductlines], [NameProductlines], [Quantity], [Status]) VALUES (N'M', N'Male', 479, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1000', N'ID102M', N'Ultraboost DNA “Yuan Xiao”', 40, 4500000, N'50', 997, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1001', N'ID102M', N'Ultraboost DNA “Yuan Xiao”', 41, 4500000, N'50', 1000, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1002', N'ID102M', N'Ultraboost DNA “Yuan Xiao”', 42, 4700000, N'50', 996, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1003', N'ID102M', N'Ultraboost DNA “Yuan Xiao”', 43, 4700000, N'50', 991, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1004', N'ID102M', N'Ultraboost DNA “Yuan Xiao”', 44, 4800000, N'50', 998, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1005', N'ID103FM', N'Ultraboost DNA “Yuan Xiao”', 39, 4500000, N'50', 1000, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1006', N'ID103FM', N'Ultraboost DNA “Yuan Xiao”', 38, 4500000, N'50', 1000, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1007', N'ID103FM', N'Ultraboost DNA “Yuan Xiao”', 36, 4500000, N'50', 1000, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1008', N'ID103FM', N'Ultraboost DNA “Yuan Xiao”', 35, 4600000, N'50', 1000, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1009', N'ID103FM', N'Ultraboost DNA “Yuan Xiao”', 34, 4700000, N'50', 999, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1010', N'ID100M', N'Adidas Dame 5 “All Skate”', 40, 3000000, N'50', 1000, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1011', N'ID100M', N'Adidas Dame 5 “All Skate”', 41, 3000000, N'50', 1000, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1012', N'ID100M', N'Adidas Dame 5 “All Skate”', 42, 3000000, N'50', 15, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1013', N'ID100M', N'Adidas Dame 5 “All Skate”', 43, 3000000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1014', N'ID101FM', N'Adidas Dame 5 “All Skate”', 39, 3000000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1015', N'ID101FM', N'Adidas Dame 5 “All Skate”', 38, 3000000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1016', N'ID101FM', N'Adidas Dame 5 “All Skate”', 37, 3000000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1017', N'ID101FM', N'Adidas Dame 5 “All Skate”', 36, 3000000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1018', N'ID102M', N'Stansmith “White”', 40, 2400000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1019', N'ID102M', N'Stansmith “White”', 41, 2400000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1020', N'ID102M', N'Stansmith “White”', 42, 2400000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1021', N'ID102M', N'Stansmith “White”', 43, 2400000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1022', N'ID103FM', N'Stansmith “White”', 39, 2400000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1023', N'ID103FM', N'Stansmith “White”', 38, 2400000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1024', N'ID103FM', N'Stansmith “White”', 37, 2400000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1025', N'ID103FM', N'Stansmith “White”', 36, 2400000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1026', N'ID104M', N'Alphabounce Slides', 40, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1027', N'ID104M', N'Alphabounce Slides', 41, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1028', N'ID104M', N'Alphabounce Slides', 42, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1029', N'ID104M', N'Alphabounce Slides', 43, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1030', N'ID104M', N'Alphabounce Slides', 44, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1031', N'ID105FM', N'Alphabounce Slides', 39, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1032', N'ID105FM', N'Alphabounce Slides', 38, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1033', N'ID105FM', N'Alphabounce Slides', 37, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1034', N'ID105FM', N'Alphabounce Slides', 36, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1035', N'ID105FM', N'Alphabounce Slides', 35, 1500000, N'50', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1036', N'ID102M', N'Ultraboost 20 “Cloud White”', 44, 5000000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1037', N'ID102M', N'Ultraboost 20 “Cloud White”', 44.5, 5000000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1038', N'ID103FM', N'Ultraboost 20 “Cloud White”', 37, 5000000, N'60', 30, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1039', N'ID103FM', N'Ultraboost 20 “Cloud White”', 37.5, 5000000, N'60', 29, N'On')
INSERT [dbo].[Products] ([IDProduct], [IDProductType], [NameProduct], [Size], [Price], [Discount], [Quantity], [Status]) VALUES (N'p1040', N'ID103FM', N'Ultraboost 20 “Cloud White”', 38, 5000000, N'60', 30, N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1000', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1001', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1002', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1003', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1004', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1005', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1006', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1007', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1008', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1009', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1010', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1011', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1012', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1013', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'1', N'p1040', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1014', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1015', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1016', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1017', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1018', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1019', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1020', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1021', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1022', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1023', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1024', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1025', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1026', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1027', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1028', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1029', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1030', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1031', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1032', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1033', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1034', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1035', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1036', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1037', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1038', N'On')
INSERT [dbo].[Products_Shops] ([IDShops], [IDProduct], [Status]) VALUES (N'2', N'p1039', N'On')
INSERT [dbo].[ProductTypes] ([IDProductType], [IDProductlines], [NameProductType], [Quantity], [Status]) VALUES (N'ID100M', N'M', N'BasketballMale', 1111, N'On')
INSERT [dbo].[ProductTypes] ([IDProductType], [IDProductlines], [NameProductType], [Quantity], [Status]) VALUES (N'ID101FM', N'FM', N'BasketballFeMale', 111, N'On')
INSERT [dbo].[ProductTypes] ([IDProductType], [IDProductlines], [NameProductType], [Quantity], [Status]) VALUES (N'ID102M', N'M', N'RunningMale', 1111, N'On')
INSERT [dbo].[ProductTypes] ([IDProductType], [IDProductlines], [NameProductType], [Quantity], [Status]) VALUES (N'ID103FM', N'FM', N'RunningFeMale', 1111, N'On')
INSERT [dbo].[ProductTypes] ([IDProductType], [IDProductlines], [NameProductType], [Quantity], [Status]) VALUES (N'ID104M', N'M', N'SlidesMale', 1111, N'On')
INSERT [dbo].[ProductTypes] ([IDProductType], [IDProductlines], [NameProductType], [Quantity], [Status]) VALUES (N'ID105FM', N'FM', N'SlidesFeMale1', 11111, N'On')
INSERT [dbo].[Shops] ([IDShops], [NameShop], [Address], [Status]) VALUES (N'1', N'Adidas Shop', N'123 Nguyen Kiem', N'On')
INSERT [dbo].[Shops] ([IDShops], [NameShop], [Address], [Status]) VALUES (N'2', N'Adidas Shop', N'456 Le Duan', N'On')
INSERT [dbo].[Supplier] ([IDSupplier], [NameSupplier], [Phone], [AddressSupplier]) VALUES (N'Adidas100VN', N'AdidasVN', N'19001508            ', N'On')
INSERT [dbo].[Supplier] ([IDSupplier], [NameSupplier], [Phone], [AddressSupplier]) VALUES (N'Adidas101CN', N'AdidasTQ', N'18534792            ', N'On')
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Employee] FOREIGN KEY([SupervisorEmployee])
REFERENCES [dbo].[Employee] ([IdEmployee])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Shops] FOREIGN KEY([IDShops])
REFERENCES [dbo].[Shops] ([IDShops])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Shops]
GO
ALTER TABLE [dbo].[Oderdetail]  WITH CHECK ADD  CONSTRAINT [FK_Oderdetail_Orderproduct] FOREIGN KEY([IDOrther])
REFERENCES [dbo].[Orderproduct] ([IDOrther])
GO
ALTER TABLE [dbo].[Oderdetail] CHECK CONSTRAINT [FK_Oderdetail_Orderproduct]
GO
ALTER TABLE [dbo].[Oderdetail]  WITH CHECK ADD  CONSTRAINT [FK_Oderdetail_Products] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Products] ([IDProduct])
GO
ALTER TABLE [dbo].[Oderdetail] CHECK CONSTRAINT [FK_Oderdetail_Products]
GO
ALTER TABLE [dbo].[Orderproduct]  WITH CHECK ADD  CONSTRAINT [FK_Orderproduct_Customer] FOREIGN KEY([CusPhone])
REFERENCES [dbo].[Customer] ([CusPhone])
GO
ALTER TABLE [dbo].[Orderproduct] CHECK CONSTRAINT [FK_Orderproduct_Customer]
GO
ALTER TABLE [dbo].[Orderproduct]  WITH CHECK ADD  CONSTRAINT [FK_Orderproduct_Employee] FOREIGN KEY([IdEmployee])
REFERENCES [dbo].[Employee] ([IdEmployee])
GO
ALTER TABLE [dbo].[Orderproduct] CHECK CONSTRAINT [FK_Orderproduct_Employee]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductTypes] FOREIGN KEY([IDProductType])
REFERENCES [dbo].[ProductTypes] ([IDProductType])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductTypes]
GO
ALTER TABLE [dbo].[Products_Shops]  WITH CHECK ADD  CONSTRAINT [FK_Products_Shops_Products] FOREIGN KEY([IDProduct])
REFERENCES [dbo].[Products] ([IDProduct])
GO
ALTER TABLE [dbo].[Products_Shops] CHECK CONSTRAINT [FK_Products_Shops_Products]
GO
ALTER TABLE [dbo].[Products_Shops]  WITH CHECK ADD  CONSTRAINT [FK_Products_Shops_Shops] FOREIGN KEY([IDShops])
REFERENCES [dbo].[Shops] ([IDShops])
GO
ALTER TABLE [dbo].[Products_Shops] CHECK CONSTRAINT [FK_Products_Shops_Shops]
GO
ALTER TABLE [dbo].[ProductTypes]  WITH CHECK ADD  CONSTRAINT [FK_ProductTypes_Productlines] FOREIGN KEY([IDProductlines])
REFERENCES [dbo].[Productlines] ([IDProductlines])
GO
ALTER TABLE [dbo].[ProductTypes] CHECK CONSTRAINT [FK_ProductTypes_Productlines]
GO
/****** Object:  StoredProcedure [dbo].[AddProductintoCart]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[AddProductintoCart] @idOrder int , @Idproduct  nvarchar(30), @quantity int,@Price float, @Discount nvarchar(10)

as
Begin 
	Insert into Oderdetail (IDOrther,IDProduct,Price,Quantity,Discount,Status)
	values ( @idOrder,@Idproduct,@Price,@quantity,@Discount,'Passed')
end
GO
/****** Object:  StoredProcedure [dbo].[createCustomer]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[createCustomer] @CusPhone char(20),@FullName nvarchar(15),@Address nvarchar(30)


as
begin 

		insert into Customer
		values(@CusPhone,@FullName,@Address)
end
GO
/****** Object:  StoredProcedure [dbo].[createoderdetail]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[createoderdetail] @IDOrther int,@IDProduct nvarchar(30),@Price float,@Discount nvarchar(10),@Quantity int
as
begin
	insert into Oderdetail
	values (@IDOrther,@IDProduct,@Price,@Discount,@Quantity,'Passed')
end
GO
/****** Object:  StoredProcedure [dbo].[createordert]    Script Date: 7/15/2020 7:25:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[createordert] @CusPhone char(20), @IdEmployee nvarchar(10), @PriceFinal float, @Quantity int
 
as
begin 
	declare @Id int 
	set @Id = (select COUNT (o.IDOrther)+100
	from
	 Orderproduct o
	)
	
	insert into Orderproduct 
	values (@Id,@CusPhone,@IdEmployee ,GETDATE(),@PriceFinal,@Quantity  ,'Passed')
	select @Id
end

GO
USE [master]
GO
ALTER DATABASE [ShoeShopManager] SET  READ_WRITE 
GO
