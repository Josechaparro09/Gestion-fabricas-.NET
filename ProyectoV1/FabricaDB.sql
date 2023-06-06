USE [FabricaDB]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 6/06/2023 6:16:55 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComprasMPrimas]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComprasMPrimas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [decimal](10, 2) NOT NULL,
	[FechaCompra] [datetime] NOT NULL,
	[Valor] [decimal](10, 2) NOT NULL,
	[IdMPrima] [int] NOT NULL,
 CONSTRAINT [PK_CMPrima] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesProduccion]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesProduccion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[FProduccion] [datetime] NOT NULL,
	[IdReceta] [int] NOT NULL,
 CONSTRAINT [PK_DP] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](15) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellido] [varchar](30) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[FIngreso] [datetime] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriasPrimas]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriasPrimas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[FechaCompra] [datetime] NOT NULL,
	[FechaExpiracion] [datetime] NOT NULL,
	[IdMedida] [int] NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_MPrimas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medidas]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medidas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ncorto] [varchar](5) NOT NULL,
	[NLargo] [varchar](30) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Medidas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MPrimaUtilizada]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MPrimaUtilizada](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CantUtilizada] [decimal](10, 2) NOT NULL,
	[IdMPrima] [int] NOT NULL,
	[Id_Receta] [int] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_MPrimaUtilizadas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plantas]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plantas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Plantas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Presentacion] [varchar](10) NOT NULL,
	[CostoProduccion] [decimal](10, 2) NOT NULL,
	[PrecioVenta] [decimal](10, 2) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[IdMedida] [int] NOT NULL,
	[Ganancia] [decimal](10, 2) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductosProducidos]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductosProducidos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Id_Receta] [int] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_PProducidos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Direccion] [varchar](30) NOT NULL,
	[FRegistro] [datetime] NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecetaProduccion]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecetaProduccion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockMateriasPrimas]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockMateriasPrimas](
	[StockMateriaPrimaID] [int] IDENTITY(1,1) NOT NULL,
	[MateriaPrimaID] [int] NULL,
	[Cantidad] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [PK_SMPirma] PRIMARY KEY CLUSTERED 
(
	[StockMateriaPrimaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockProductos]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockProductos](
	[StockProductoID] [int] IDENTITY(1,1) NOT NULL,
	[ProductoID] [int] NULL,
	[Cantidad] [int] NULL,
	[FechaActualizacion] [datetime] NULL,
 CONSTRAINT [CLUSTERED] PRIMARY KEY CLUSTERED 
(
	[StockProductoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 6/06/2023 6:16:56 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](20) NOT NULL,
	[NUsuario] [varchar](20) NOT NULL,
	[Contrasenia] [varchar](20) NOT NULL,
	[FRegistro] [datetime] NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 
GO
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (11, N'Vinagres', 1)
GO
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (12, N'Salsas', 1)
GO
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (13, N'Esencias', 1)
GO
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (14, N'asdasd', 0)
GO
INSERT [dbo].[Categorias] ([Id], [Nombre], [Estado]) VALUES (15, N'Salsas', 1)
GO
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[ComprasMPrimas] ON 
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (1, CAST(123.00 AS Decimal(10, 2)), CAST(N'2023-06-06T00:32:58.930' AS DateTime), CAST(500000.00 AS Decimal(10, 2)), 1013)
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (2, CAST(2500.00 AS Decimal(10, 2)), CAST(N'2023-06-06T02:50:46.143' AS DateTime), CAST(500000.00 AS Decimal(10, 2)), 1012)
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (3, CAST(2500.00 AS Decimal(10, 2)), CAST(N'2023-06-06T02:50:56.263' AS DateTime), CAST(500000.00 AS Decimal(10, 2)), 1013)
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (4, CAST(4545.00 AS Decimal(10, 2)), CAST(N'2023-06-06T02:56:13.167' AS DateTime), CAST(100000.00 AS Decimal(10, 2)), 1014)
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (5, CAST(4545.00 AS Decimal(10, 2)), CAST(N'2023-06-06T02:56:17.817' AS DateTime), CAST(100000.00 AS Decimal(10, 2)), 1015)
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (6, CAST(4545.00 AS Decimal(10, 2)), CAST(N'2023-06-06T02:56:20.723' AS DateTime), CAST(100000.00 AS Decimal(10, 2)), 1016)
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (7, CAST(4545.00 AS Decimal(10, 2)), CAST(N'2023-06-06T02:56:22.983' AS DateTime), CAST(100000.00 AS Decimal(10, 2)), 1017)
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (8, CAST(5.00 AS Decimal(10, 2)), CAST(N'2023-06-06T03:05:59.930' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), 1013)
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (9, CAST(120.00 AS Decimal(10, 2)), CAST(N'2023-06-06T05:16:35.313' AS DateTime), CAST(250000.00 AS Decimal(10, 2)), 1012)
GO
INSERT [dbo].[ComprasMPrimas] ([Id], [Cantidad], [FechaCompra], [Valor], [IdMPrima]) VALUES (10, CAST(250.00 AS Decimal(10, 2)), CAST(N'2023-06-06T05:46:51.020' AS DateTime), CAST(80000.00 AS Decimal(10, 2)), 1014)
GO
SET IDENTITY_INSERT [dbo].[ComprasMPrimas] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallesProduccion] ON 
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (11, 1, CAST(N'2023-06-05T20:25:46.793' AS DateTime), 12)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (12, 1, CAST(N'2023-06-05T20:26:11.787' AS DateTime), 12)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (13, 1, CAST(N'2023-06-05T20:26:20.447' AS DateTime), 12)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (14, 1, CAST(N'2023-06-05T20:26:58.163' AS DateTime), 12)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (15, 2, CAST(N'2023-06-05T23:20:00.920' AS DateTime), 14)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (16, 1, CAST(N'2023-06-05T23:24:17.643' AS DateTime), 14)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (17, 1, CAST(N'2023-06-05T23:25:30.917' AS DateTime), 14)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (18, 1, CAST(N'2023-06-05T23:26:35.363' AS DateTime), 14)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (19, 1, CAST(N'2023-06-05T23:27:05.437' AS DateTime), 14)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (20, 2, CAST(N'2023-06-05T23:27:23.047' AS DateTime), 14)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (21, 5, CAST(N'2023-06-05T23:27:43.443' AS DateTime), 14)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (22, 1, CAST(N'2023-06-06T02:57:17.500' AS DateTime), 15)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (23, 1, CAST(N'2023-06-06T02:57:21.410' AS DateTime), 16)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (24, 1, CAST(N'2023-06-06T03:07:00.600' AS DateTime), 15)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (25, 1, CAST(N'2023-06-06T05:15:19.110' AS DateTime), 15)
GO
INSERT [dbo].[DetallesProduccion] ([Id], [Cantidad], [FProduccion], [IdReceta]) VALUES (26, 2, CAST(N'2023-06-06T05:45:08.073' AS DateTime), 15)
GO
SET IDENTITY_INSERT [dbo].[DetallesProduccion] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 
GO
INSERT [dbo].[Empleados] ([Id], [Cedula], [Nombre], [Apellido], [Telefono], [FIngreso], [Estado]) VALUES (9, N'4565458715', N'Pedro', N' Martinez', N'3214568975', CAST(N'2023-06-03T22:49:00.697' AS DateTime), 1)
GO
INSERT [dbo].[Empleados] ([Id], [Cedula], [Nombre], [Apellido], [Telefono], [FIngreso], [Estado]) VALUES (10, N'10656642', N'Maria ', N'Perez', N'3215468565', CAST(N'2023-06-03T22:49:22.327' AS DateTime), 1)
GO
INSERT [dbo].[Empleados] ([Id], [Cedula], [Nombre], [Apellido], [Telefono], [FIngreso], [Estado]) VALUES (11, N'1066875671', N'Jose', N'Castro', N'3215478565', CAST(N'2023-06-03T22:49:49.400' AS DateTime), 1)
GO
INSERT [dbo].[Empleados] ([Id], [Cedula], [Nombre], [Apellido], [Telefono], [FIngreso], [Estado]) VALUES (12, N'49764737', N'Ruth', N'Velasquez', N'3124578565', CAST(N'2023-06-03T22:50:29.350' AS DateTime), 1)
GO
INSERT [dbo].[Empleados] ([Id], [Cedula], [Nombre], [Apellido], [Telefono], [FIngreso], [Estado]) VALUES (13, N'6546', N'54654', N'6446', N'651', CAST(N'2023-06-04T18:30:15.417' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[MateriasPrimas] ON 
GO
INSERT [dbo].[MateriasPrimas] ([Id], [Nombre], [FechaCompra], [FechaExpiracion], [IdMedida], [IdProveedor], [Estado]) VALUES (1012, N'Acido citrico', CAST(N'2023-06-03T22:56:35.427' AS DateTime), CAST(N'2023-09-14T22:56:07.000' AS DateTime), 2012, 1013, 1)
GO
INSERT [dbo].[MateriasPrimas] ([Id], [Nombre], [FechaCompra], [FechaExpiracion], [IdMedida], [IdProveedor], [Estado]) VALUES (1013, N'Sabor coco', CAST(N'2023-06-03T22:57:02.403' AS DateTime), CAST(N'2024-06-05T22:56:41.000' AS DateTime), 2012, 1015, 1)
GO
INSERT [dbo].[MateriasPrimas] ([Id], [Nombre], [FechaCompra], [FechaExpiracion], [IdMedida], [IdProveedor], [Estado]) VALUES (1014, N'Monoglutamato de sodio', CAST(N'2023-06-03T22:57:37.473' AS DateTime), CAST(N'2025-02-12T22:57:04.000' AS DateTime), 2012, 1014, 1)
GO
INSERT [dbo].[MateriasPrimas] ([Id], [Nombre], [FechaCompra], [FechaExpiracion], [IdMedida], [IdProveedor], [Estado]) VALUES (1015, N'Acido acetico', CAST(N'2023-06-03T22:58:22.653' AS DateTime), CAST(N'2024-05-14T22:57:39.000' AS DateTime), 2010, 1014, 1)
GO
INSERT [dbo].[MateriasPrimas] ([Id], [Nombre], [FechaCompra], [FechaExpiracion], [IdMedida], [IdProveedor], [Estado]) VALUES (1016, N'Sabor kola', CAST(N'2023-06-03T22:58:56.910' AS DateTime), CAST(N'2024-03-19T22:58:26.000' AS DateTime), 2012, 1015, 1)
GO
INSERT [dbo].[MateriasPrimas] ([Id], [Nombre], [FechaCompra], [FechaExpiracion], [IdMedida], [IdProveedor], [Estado]) VALUES (1017, N'Color caramelo', CAST(N'2023-06-03T22:59:42.123' AS DateTime), CAST(N'2024-06-04T22:59:02.000' AS DateTime), 2010, 1013, 1)
GO
INSERT [dbo].[MateriasPrimas] ([Id], [Nombre], [FechaCompra], [FechaExpiracion], [IdMedida], [IdProveedor], [Estado]) VALUES (1018, N'adsdas', CAST(N'2023-06-04T18:30:34.420' AS DateTime), CAST(N'2024-04-16T18:30:26.000' AS DateTime), 2011, 1013, 0)
GO
INSERT [dbo].[MateriasPrimas] ([Id], [Nombre], [FechaCompra], [FechaExpiracion], [IdMedida], [IdProveedor], [Estado]) VALUES (1019, N'Monoglutamato de sodio', CAST(N'2023-06-06T05:16:04.623' AS DateTime), CAST(N'2024-08-07T05:15:37.000' AS DateTime), 2012, 1014, 0)
GO
INSERT [dbo].[MateriasPrimas] ([Id], [Nombre], [FechaCompra], [FechaExpiracion], [IdMedida], [IdProveedor], [Estado]) VALUES (1020, N'Color azul ', CAST(N'2023-06-06T05:46:04.203' AS DateTime), CAST(N'2024-04-03T05:45:30.000' AS DateTime), 2011, 1015, 1)
GO
SET IDENTITY_INSERT [dbo].[MateriasPrimas] OFF
GO
SET IDENTITY_INSERT [dbo].[Medidas] ON 
GO
INSERT [dbo].[Medidas] ([Id], [Ncorto], [NLargo], [Estado]) VALUES (2010, N'Ml', N'Mililitro', 1)
GO
INSERT [dbo].[Medidas] ([Id], [Ncorto], [NLargo], [Estado]) VALUES (2011, N'L', N'Litro', 1)
GO
INSERT [dbo].[Medidas] ([Id], [Ncorto], [NLargo], [Estado]) VALUES (2012, N'Mg', N'Miligramo', 1)
GO
INSERT [dbo].[Medidas] ([Id], [Ncorto], [NLargo], [Estado]) VALUES (2013, N'Kg', N'Kilogramo', 1)
GO
INSERT [dbo].[Medidas] ([Id], [Ncorto], [NLargo], [Estado]) VALUES (2014, N'Cc', N'Centimetro cubico', 1)
GO
INSERT [dbo].[Medidas] ([Id], [Ncorto], [NLargo], [Estado]) VALUES (2015, N'asd', N'asd', 1)
GO
INSERT [dbo].[Medidas] ([Id], [Ncorto], [NLargo], [Estado]) VALUES (2016, N'asd', N'asd', 1)
GO
INSERT [dbo].[Medidas] ([Id], [Ncorto], [NLargo], [Estado]) VALUES (2017, N'Ml', N'Mililitro', 1)
GO
INSERT [dbo].[Medidas] ([Id], [Ncorto], [NLargo], [Estado]) VALUES (2018, N'Mg', N'Miligramo', 0)
GO
SET IDENTITY_INSERT [dbo].[Medidas] OFF
GO
SET IDENTITY_INSERT [dbo].[MPrimaUtilizada] ON 
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (2, CAST(22.00 AS Decimal(10, 2)), 1013, 5, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (3, CAST(654.00 AS Decimal(10, 2)), 1013, 5, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (4, CAST(100.00 AS Decimal(10, 2)), 1013, 6, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (5, CAST(55.00 AS Decimal(10, 2)), 1013, 8, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (6, CAST(6565.00 AS Decimal(10, 2)), 1015, 8, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (7, CAST(65.00 AS Decimal(10, 2)), 1014, 8, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (8, CAST(55.00 AS Decimal(10, 2)), 1014, 9, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (9, CAST(5656.00 AS Decimal(10, 2)), 1015, 9, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (10, CAST(5656.00 AS Decimal(10, 2)), 1014, 9, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (11, CAST(55.00 AS Decimal(10, 2)), 1013, 10, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (12, CAST(556.00 AS Decimal(10, 2)), 1017, 10, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (13, CAST(655.00 AS Decimal(10, 2)), 1014, 10, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (14, CAST(500.00 AS Decimal(10, 2)), 1014, 11, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (15, CAST(200.00 AS Decimal(10, 2)), 1012, 11, 0)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (16, CAST(250.00 AS Decimal(10, 2)), 1015, 11, 0)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (17, CAST(55.00 AS Decimal(10, 2)), 1013, 12, 0)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (18, CAST(65.00 AS Decimal(10, 2)), 1017, 12, 0)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (19, CAST(55.00 AS Decimal(10, 2)), 1013, 12, 0)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (20, CAST(6565.00 AS Decimal(10, 2)), 1013, 13, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (21, CAST(655.00 AS Decimal(10, 2)), 1014, 13, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (22, CAST(565.00 AS Decimal(10, 2)), 1014, 11, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (23, CAST(6565.00 AS Decimal(10, 2)), 1015, 11, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (26, CAST(1.00 AS Decimal(10, 2)), 1012, 12, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (27, CAST(1.00 AS Decimal(10, 2)), 1013, 12, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (28, CAST(1.00 AS Decimal(10, 2)), 1014, 12, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (29, CAST(1.00 AS Decimal(10, 2)), 1015, 12, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (30, CAST(100.00 AS Decimal(10, 2)), 1012, 14, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (31, CAST(100.00 AS Decimal(10, 2)), 1013, 14, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (32, CAST(250.00 AS Decimal(10, 2)), 1015, 15, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (33, CAST(250.00 AS Decimal(10, 2)), 1017, 15, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (34, CAST(250.00 AS Decimal(10, 2)), 1016, 16, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (35, CAST(100.00 AS Decimal(10, 2)), 1017, 16, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (36, CAST(100.00 AS Decimal(10, 2)), 1012, 16, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (37, CAST(56.00 AS Decimal(10, 2)), 1012, 17, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (38, CAST(50.00 AS Decimal(10, 2)), 1015, 17, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (39, CAST(500.00 AS Decimal(10, 2)), 1012, 18, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (40, CAST(100.00 AS Decimal(10, 2)), 1015, 18, 1)
GO
INSERT [dbo].[MPrimaUtilizada] ([Id], [CantUtilizada], [IdMPrima], [Id_Receta], [Estado]) VALUES (41, CAST(100.00 AS Decimal(10, 2)), 1017, 18, 1)
GO
SET IDENTITY_INSERT [dbo].[MPrimaUtilizada] OFF
GO
SET IDENTITY_INSERT [dbo].[Plantas] ON 
GO
INSERT [dbo].[Plantas] ([Id], [Nombre], [IdEmpleado], [Estado]) VALUES (7, N'Planta de vinagres', 9, 1)
GO
INSERT [dbo].[Plantas] ([Id], [Nombre], [IdEmpleado], [Estado]) VALUES (8, N'Planta de salsas', 11, 1)
GO
INSERT [dbo].[Plantas] ([Id], [Nombre], [IdEmpleado], [Estado]) VALUES (9, N'Planta de Esencias', 12, 1)
GO
INSERT [dbo].[Plantas] ([Id], [Nombre], [IdEmpleado], [Estado]) VALUES (10, N'asd', 9, 0)
GO
INSERT [dbo].[Plantas] ([Id], [Nombre], [IdEmpleado], [Estado]) VALUES (11, N'X', 11, 1)
GO
SET IDENTITY_INSERT [dbo].[Plantas] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (13, N'Vinagre de blanco 500ml', N'500', CAST(1000.00 AS Decimal(10, 2)), CAST(2000.00 AS Decimal(10, 2)), 11, 2010, CAST(1000.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (14, N'Vinagre de manzana 500ml', N'500', CAST(1250.00 AS Decimal(10, 2)), CAST(3500.00 AS Decimal(10, 2)), 11, 2010, CAST(2250.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (15, N'Salsa negra 900ml', N'900', CAST(1200.00 AS Decimal(10, 2)), CAST(2200.00 AS Decimal(10, 2)), 12, 2010, CAST(1000.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (16, N'Esencia de kola 500ml', N'500', CAST(1200.00 AS Decimal(10, 2)), CAST(3000.00 AS Decimal(10, 2)), 13, 2010, CAST(1800.00 AS Decimal(10, 2)), 1)
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (17, N'Esencia de coco 500ml', N'500', CAST(1200.00 AS Decimal(10, 2)), CAST(3250.00 AS Decimal(10, 2)), 13, 2010, CAST(2050.00 AS Decimal(10, 2)), 0)
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (18, N'Salsa de ajo 170ml', N'170', CAST(1200.00 AS Decimal(10, 2)), CAST(2000.00 AS Decimal(10, 2)), 12, 2010, CAST(800.00 AS Decimal(10, 2)), 0)
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (19, N'asd', N'500', CAST(1000.00 AS Decimal(10, 2)), CAST(2000.00 AS Decimal(10, 2)), 13, 2011, CAST(1000.00 AS Decimal(10, 2)), 0)
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (20, N'adasd', N'aads', CAST(1.00 AS Decimal(10, 2)), CAST(2.00 AS Decimal(10, 2)), 12, 2011, CAST(1.00 AS Decimal(10, 2)), 0)
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (21, N'asd', N'as', CAST(1111.00 AS Decimal(10, 2)), CAST(2222.00 AS Decimal(10, 2)), 12, 2011, CAST(1111.00 AS Decimal(10, 2)), 0)
GO
INSERT [dbo].[Productos] ([Id], [Nombre], [Presentacion], [CostoProduccion], [PrecioVenta], [IdCategoria], [IdMedida], [Ganancia], [Estado]) VALUES (22, N'Salsa de ajo ', N'170', CAST(1500.00 AS Decimal(10, 2)), CAST(2000.00 AS Decimal(10, 2)), 12, 2014, CAST(500.00 AS Decimal(10, 2)), 1)
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[ProductosProducidos] ON 
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (1, 5666, 15, 11, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (2, 1, 13, 12, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (3, 1, 14, 12, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (4, 1, 15, 12, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (5, 1, 16, 12, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (6, 100, 13, 14, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (7, 54, 15, 15, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (8, 53, 14, 15, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (9, 250, 16, 16, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (10, 320, 14, 17, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (11, 350, 22, 18, 1)
GO
INSERT [dbo].[ProductosProducidos] ([Id], [Cantidad], [IdProducto], [Id_Receta], [Estado]) VALUES (12, 250, 15, 18, 1)
GO
SET IDENTITY_INSERT [dbo].[ProductosProducidos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 
GO
INSERT [dbo].[Proveedores] ([Id], [Nombre], [Telefono], [Direccion], [FRegistro], [Estado]) VALUES (1012, N'La Tour SAS', N'3125452529', N'Cra 20 # 50c Novalito', CAST(N'2023-06-03T22:46:13.940' AS DateTime), 1)
GO
INSERT [dbo].[Proveedores] ([Id], [Nombre], [Telefono], [Direccion], [FRegistro], [Estado]) VALUES (1013, N'SIMPA SAS', N'3214568795', N'-', CAST(N'2023-06-03T22:46:43.447' AS DateTime), 1)
GO
INSERT [dbo].[Proveedores] ([Id], [Nombre], [Telefono], [Direccion], [FRegistro], [Estado]) VALUES (1014, N'GMP SAS', N'3005454578', N'-', CAST(N'2023-06-03T22:47:31.807' AS DateTime), 1)
GO
INSERT [dbo].[Proveedores] ([Id], [Nombre], [Telefono], [Direccion], [FRegistro], [Estado]) VALUES (1015, N'Sabores LTDA', N'3125465223', N'-', CAST(N'2023-06-03T22:48:05.280' AS DateTime), 1)
GO
INSERT [dbo].[Proveedores] ([Id], [Nombre], [Telefono], [Direccion], [FRegistro], [Estado]) VALUES (1016, N'asd', N'23165', N'asd', CAST(N'2023-06-04T18:29:37.447' AS DateTime), 0)
GO
INSERT [dbo].[Proveedores] ([Id], [Nombre], [Telefono], [Direccion], [FRegistro], [Estado]) VALUES (1017, N'Etiquetas ', N'321456789', N'-', CAST(N'2023-06-06T05:40:03.630' AS DateTime), 0)
GO
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[RecetaProduccion] ON 
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (1, N'Vinagre blanco 500ml', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (2, N'Tanda vinagre blanco 500ml', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (3, N'Ejemplo', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (4, N'asd', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (5, N'asdasd', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (6, N'asdads', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (7, N'Ejemplo', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (8, N'adsad', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (9, N'asdasd', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (10, N'dasd', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (11, N'Tanda Vinagre 500ml', 1)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (12, N'asdasd', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (13, N'asdasd', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (14, N'Prueba 111', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (15, N'Tanda Salsa negra 170ml', 1)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (16, N'Tanda Esencia de kol 500ml', 1)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (17, N'VInagre de manzana 500ml', 0)
GO
INSERT [dbo].[RecetaProduccion] ([Id], [Nombre], [Estado]) VALUES (18, N'Salsa de ajo 170 y salsa negra', 1)
GO
SET IDENTITY_INSERT [dbo].[RecetaProduccion] OFF
GO
SET IDENTITY_INSERT [dbo].[StockMateriasPrimas] ON 
GO
INSERT [dbo].[StockMateriasPrimas] ([StockMateriaPrimaID], [MateriaPrimaID], [Cantidad], [FechaActualizacion]) VALUES (1, 1012, 6520, CAST(N'2023-06-06T05:16:35.307' AS DateTime))
GO
INSERT [dbo].[StockMateriasPrimas] ([StockMateriaPrimaID], [MateriaPrimaID], [Cantidad], [FechaActualizacion]) VALUES (2, 1013, 7338, CAST(N'2023-06-06T03:05:59.900' AS DateTime))
GO
INSERT [dbo].[StockMateriasPrimas] ([StockMateriaPrimaID], [MateriaPrimaID], [Cantidad], [FechaActualizacion]) VALUES (3, 1014, 7295, CAST(N'2023-06-06T05:46:51.013' AS DateTime))
GO
INSERT [dbo].[StockMateriasPrimas] ([StockMateriaPrimaID], [MateriaPrimaID], [Cantidad], [FechaActualizacion]) VALUES (4, 1015, 3295, CAST(N'2023-06-06T05:45:08.150' AS DateTime))
GO
INSERT [dbo].[StockMateriasPrimas] ([StockMateriaPrimaID], [MateriaPrimaID], [Cantidad], [FechaActualizacion]) VALUES (5, 1016, 4295, CAST(N'2023-06-06T02:57:21.430' AS DateTime))
GO
INSERT [dbo].[StockMateriasPrimas] ([StockMateriaPrimaID], [MateriaPrimaID], [Cantidad], [FechaActualizacion]) VALUES (6, 1017, 3195, CAST(N'2023-06-06T05:45:08.173' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[StockMateriasPrimas] OFF
GO
SET IDENTITY_INSERT [dbo].[StockProductos] ON 
GO
INSERT [dbo].[StockProductos] ([StockProductoID], [ProductoID], [Cantidad], [FechaActualizacion]) VALUES (1, 13, 1000, CAST(N'2023-06-05T23:27:43.453' AS DateTime))
GO
INSERT [dbo].[StockProductos] ([StockProductoID], [ProductoID], [Cantidad], [FechaActualizacion]) VALUES (2, 15, 270, CAST(N'2023-06-06T05:45:08.107' AS DateTime))
GO
INSERT [dbo].[StockProductos] ([StockProductoID], [ProductoID], [Cantidad], [FechaActualizacion]) VALUES (3, 14, 265, CAST(N'2023-06-06T05:45:08.123' AS DateTime))
GO
INSERT [dbo].[StockProductos] ([StockProductoID], [ProductoID], [Cantidad], [FechaActualizacion]) VALUES (4, 16, 250, CAST(N'2023-06-06T02:57:21.420' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[StockProductos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (12, N'asd', N'Elchapaa', N'10656642', CAST(N'2023-05-21T20:39:07.283' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (13, N'Jose', N'asdasd', N'10656642', CAST(N'2023-05-21T20:49:35.493' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (14, N'Jose', N'Elchap', N'10656642', CAST(N'2023-05-21T20:56:59.003' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (15, N'Jose', N'Elchapaaaa', N'10656642', CAST(N'2023-05-21T20:58:20.213' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (16, N'asdasd', N'asdasdasd', N'123456', CAST(N'2023-05-21T21:01:55.740' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (17, N'asdasd', N'asdasdasdasd', N'123456', CAST(N'2023-05-21T21:04:39.017' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (18, N'Jose', N'aqwe', N'10656642', CAST(N'2023-05-21T21:10:45.030' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (19, N'jasdjadj', N'asdasdaaaa', N'123456', CAST(N'2023-05-21T21:16:20.787' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (20, N'Jose', N'Chapa', N'10656642', CAST(N'2023-05-23T13:45:18.177' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (21, N'Juan', N'Juan123', N'123456', CAST(N'2023-05-23T14:50:22.520' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (1021, N'Maria Camila', N'maria', N'10656642', CAST(N'2023-06-04T20:40:20.780' AS DateTime))
GO
INSERT [dbo].[Usuarios] ([Id], [Nombre], [NUsuario], [Contrasenia], [FRegistro]) VALUES (1022, N'Jose', N'jachaparro', N'10656642', CAST(N'2023-06-06T05:37:44.220' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[ComprasMPrimas]  WITH CHECK ADD  CONSTRAINT [FK_15] FOREIGN KEY([IdMPrima])
REFERENCES [dbo].[MateriasPrimas] ([Id])
GO
ALTER TABLE [dbo].[ComprasMPrimas] CHECK CONSTRAINT [FK_15]
GO
ALTER TABLE [dbo].[DetallesProduccion]  WITH CHECK ADD  CONSTRAINT [FK_12] FOREIGN KEY([IdReceta])
REFERENCES [dbo].[RecetaProduccion] ([Id])
GO
ALTER TABLE [dbo].[DetallesProduccion] CHECK CONSTRAINT [FK_12]
GO
ALTER TABLE [dbo].[MateriasPrimas]  WITH CHECK ADD  CONSTRAINT [FK_Medidas] FOREIGN KEY([IdMedida])
REFERENCES [dbo].[Medidas] ([Id])
GO
ALTER TABLE [dbo].[MateriasPrimas] CHECK CONSTRAINT [FK_Medidas]
GO
ALTER TABLE [dbo].[MateriasPrimas]  WITH CHECK ADD  CONSTRAINT [FK_Proveedores] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedores] ([Id])
GO
ALTER TABLE [dbo].[MateriasPrimas] CHECK CONSTRAINT [FK_Proveedores]
GO
ALTER TABLE [dbo].[MPrimaUtilizada]  WITH CHECK ADD  CONSTRAINT [FK_10] FOREIGN KEY([Id_Receta])
REFERENCES [dbo].[RecetaProduccion] ([Id])
GO
ALTER TABLE [dbo].[MPrimaUtilizada] CHECK CONSTRAINT [FK_10]
GO
ALTER TABLE [dbo].[MPrimaUtilizada]  WITH CHECK ADD  CONSTRAINT [FK_11] FOREIGN KEY([IdMPrima])
REFERENCES [dbo].[MateriasPrimas] ([Id])
GO
ALTER TABLE [dbo].[MPrimaUtilizada] CHECK CONSTRAINT [FK_11]
GO
ALTER TABLE [dbo].[Plantas]  WITH CHECK ADD  CONSTRAINT [FK_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([Id])
GO
ALTER TABLE [dbo].[Plantas] CHECK CONSTRAINT [FK_Empleado]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Categoria]
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD  CONSTRAINT [FK_Medida] FOREIGN KEY([IdMedida])
REFERENCES [dbo].[Medidas] ([Id])
GO
ALTER TABLE [dbo].[Productos] CHECK CONSTRAINT [FK_Medida]
GO
ALTER TABLE [dbo].[ProductosProducidos]  WITH CHECK ADD  CONSTRAINT [FK_11_1] FOREIGN KEY([Id_Receta])
REFERENCES [dbo].[RecetaProduccion] ([Id])
GO
ALTER TABLE [dbo].[ProductosProducidos] CHECK CONSTRAINT [FK_11_1]
GO
ALTER TABLE [dbo].[ProductosProducidos]  WITH CHECK ADD  CONSTRAINT [FK_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[ProductosProducidos] CHECK CONSTRAINT [FK_Producto]
GO
ALTER TABLE [dbo].[StockMateriasPrimas]  WITH CHECK ADD  CONSTRAINT [FK_StockMateriasPrimas_1] FOREIGN KEY([MateriaPrimaID])
REFERENCES [dbo].[MateriasPrimas] ([Id])
GO
ALTER TABLE [dbo].[StockMateriasPrimas] CHECK CONSTRAINT [FK_StockMateriasPrimas_1]
GO
ALTER TABLE [dbo].[StockProductos]  WITH CHECK ADD  CONSTRAINT [FK_StockProductos_1] FOREIGN KEY([ProductoID])
REFERENCES [dbo].[Productos] ([Id])
GO
ALTER TABLE [dbo].[StockProductos] CHECK CONSTRAINT [FK_StockProductos_1]
GO
