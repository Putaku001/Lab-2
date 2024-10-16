USE [SistemaRentaAutos]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/10/2024 02:47:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](100) NOT NULL,
	[Apellido] [nvarchar](100) NOT NULL,
	[Licencia] [nvarchar](10) NOT NULL,
	[Telefono] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rentas]    Script Date: 10/10/2024 02:47:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rentas](
	[RentaID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NOT NULL,
	[VehiculoID] [int] NOT NULL,
	[FechaRenta] [datetime] NOT NULL,
	[HoraRenta] [time](7) NOT NULL,
	[FechaDevolucion] [datetime] NOT NULL,
	[HoraDevolucion] [time](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RentaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 10/10/2024 02:47:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[VehiculoID] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](50) NULL,
	[Modelo] [nvarchar](50) NULL,
	[Año] [int] NULL,
	[Disponibilidad] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VehiculoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rentas]  WITH CHECK ADD  CONSTRAINT [FK_Rentas_Clientes] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Clientes] ([ClienteID])
GO
ALTER TABLE [dbo].[Rentas] CHECK CONSTRAINT [FK_Rentas_Clientes]
GO
ALTER TABLE [dbo].[Rentas]  WITH CHECK ADD  CONSTRAINT [FK_Rentas_Vehiculos] FOREIGN KEY([VehiculoID])
REFERENCES [dbo].[Vehiculos] ([VehiculoID])
GO
ALTER TABLE [dbo].[Rentas] CHECK CONSTRAINT [FK_Rentas_Vehiculos]
GO
