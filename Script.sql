USE [master]
GO
/****** Object:  Database [Biblioteca]    Script Date: 01/09/2024 6:33:19 ******/
CREATE DATABASE [Biblioteca]
-- --CONTAINMENT = NONE
-- --ON  PRIMARY 
--( NAME = N'Biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.KHRIZ\MSSQL\DATA\Biblioteca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
-- LOG ON 
--( NAME = N'Biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.KHRIZ\MSSQL\DATA\Biblioteca_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
-- WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
--GO
--ALTER DATABASE [Biblioteca] SET COMPATIBILITY_LEVEL = 160
--GO
--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [Biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
--end
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Biblioteca] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Biblioteca] SET RECOVERY FULL 
GO
ALTER DATABASE [Biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [Biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Biblioteca] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Biblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Biblioteca] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Biblioteca', N'ON'
GO
ALTER DATABASE [Biblioteca] SET QUERY_STORE = ON
GO
ALTER DATABASE [Biblioteca] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Biblioteca]
GO
/****** Object:  Table [dbo].[Credenciales]    Script Date: 01/09/2024 6:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credenciales](
	[id_crd] [int] NOT NULL,
	[cedula_usr] [int] NOT NULL,
	[usuario_crd] [nchar](25) NOT NULL,
	[contraseña_crd] [nchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_crd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Devoluciones]    Script Date: 01/09/2024 6:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devoluciones](
	[id_dl] [int] NOT NULL,
	[cedula_ltr] [int] NOT NULL,
	[isbn_lb] [nchar](17) NOT NULL,
	[fecha_prestamo] [nchar](10) NOT NULL,
	[fecha_devolucion_programada] [nchar](10) NOT NULL,
	[fecha_devolucion] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_dl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lectores]    Script Date: 01/09/2024 6:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lectores](
	[cedula_ltr] [int] NOT NULL,
	[nombres_ltr] [nchar](30) NOT NULL,
	[apellidos_ltr] [nchar](30) NOT NULL,
	[fecha_nacimiento_ltr] [nchar](10) NOT NULL,
	[direccion_domicilio_ltr] [nchar](200) NOT NULL,
	[correo_ltr] [nchar](60) NOT NULL,
	[sancion_ltr] [nchar](3) NOT NULL,
	[tiempo_scn_ltr] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[cedula_ltr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 01/09/2024 6:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[isbn_lb] [nchar](17) NOT NULL,
	[titulo_lb] [nchar](100) NOT NULL,
	[autor_es_lb] [nchar](100) NOT NULL,
	[editorial_lb] [nchar](30) NOT NULL,
	[genero_lb] [nchar](25) NOT NULL,
	[año_publicacion_lb] [nchar](4) NOT NULL,
	[cantidad_lb] [int] NOT NULL,
	[sinopsis_lb] [nchar](100) NOT NULL,
	[imagen_lb] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[isbn_lb] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logo]    Script Date: 01/09/2024 6:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logo](
	[id_imagen] [int] NOT NULL,
	[nombre_lg] [nchar](50) NOT NULL,
	[imagen_lg] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_imagen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimientos]    Script Date: 01/09/2024 6:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimientos](
	[id_mvt] [int] NOT NULL,
	[cedula_usr] [int] NOT NULL,
	[isbn_lb] [nchar](17) NOT NULL,
	[fecha_mvt] [nchar](10) NOT NULL,
	[hora_mvt] [nchar](8) NOT NULL,
	[descipcion_mvt] [nchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_mvt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prestamos]    Script Date: 01/09/2024 6:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestamos](
	[id_ptm] [int] NOT NULL,
	[cedula_ltr] [int] NOT NULL,
	[isbn_lb] [nchar](17) NOT NULL,
	[fecha_prestamo] [nchar](10) NOT NULL,
	[fecha_devolucio_programada] [nchar](10) NOT NULL,
	[estado_] [int] NOT NULL,
	[aviso_] [int] NOT NULL,
	[aviso_Pasado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ptm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 01/09/2024 6:33:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[cedula_usr] [int] NOT NULL,
	[nombres_usr] [nchar](30) NOT NULL,
	[apellidos_usr] [nchar](30) NOT NULL,
	[fecha_nacimiento_usr] [nchar](10) NOT NULL,
	[direccion_domicilio_usr] [nchar](200) NOT NULL,
	[correo_usr] [nchar](60) NOT NULL,
	[rol_usr] [nchar](25) NOT NULL,
	[estado_usr] [nchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cedula_usr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Credenciales]  WITH CHECK ADD FOREIGN KEY([cedula_usr])
REFERENCES [dbo].[Usuarios] ([cedula_usr])
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD FOREIGN KEY([cedula_ltr])
REFERENCES [dbo].[Lectores] ([cedula_ltr])
GO
ALTER TABLE [dbo].[Devoluciones]  WITH CHECK ADD FOREIGN KEY([isbn_lb])
REFERENCES [dbo].[Libros] ([isbn_lb])
GO
ALTER TABLE [dbo].[Movimientos]  WITH CHECK ADD FOREIGN KEY([cedula_usr])
REFERENCES [dbo].[Usuarios] ([cedula_usr])
GO
ALTER TABLE [dbo].[Movimientos]  WITH CHECK ADD FOREIGN KEY([isbn_lb])
REFERENCES [dbo].[Libros] ([isbn_lb])
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD FOREIGN KEY([cedula_ltr])
REFERENCES [dbo].[Lectores] ([cedula_ltr])
GO
ALTER TABLE [dbo].[Prestamos]  WITH CHECK ADD FOREIGN KEY([isbn_lb])
REFERENCES [dbo].[Libros] ([isbn_lb])
GO
USE [master]
GO
ALTER DATABASE [Biblioteca] SET  READ_WRITE 
GO
