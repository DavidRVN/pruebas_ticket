USE [master]
GO
/****** Object:  Database [ticket_prueba]    Script Date: 15/02/2022 1:36:42 p. m. ******/
CREATE DATABASE [ticket_prueba]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ticket_prueba', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ticket_prueba.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ticket_prueba_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ticket_prueba_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ticket_prueba] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ticket_prueba].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ticket_prueba] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ticket_prueba] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ticket_prueba] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ticket_prueba] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ticket_prueba] SET ARITHABORT OFF 
GO
ALTER DATABASE [ticket_prueba] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ticket_prueba] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ticket_prueba] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ticket_prueba] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ticket_prueba] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ticket_prueba] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ticket_prueba] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ticket_prueba] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ticket_prueba] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ticket_prueba] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ticket_prueba] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ticket_prueba] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ticket_prueba] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ticket_prueba] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ticket_prueba] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ticket_prueba] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ticket_prueba] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ticket_prueba] SET RECOVERY FULL 
GO
ALTER DATABASE [ticket_prueba] SET  MULTI_USER 
GO
ALTER DATABASE [ticket_prueba] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ticket_prueba] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ticket_prueba] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ticket_prueba] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ticket_prueba] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ticket_prueba] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ticket_prueba', N'ON'
GO
ALTER DATABASE [ticket_prueba] SET QUERY_STORE = OFF
GO
USE [ticket_prueba]
GO
/****** Object:  Table [dbo].[ticket]    Script Date: 15/02/2022 1:36:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ticket](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[fecha_creacion] [varchar](50) NOT NULL,
	[fecha_actualizacion] [varchar](50) NOT NULL,
	[estatus] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ticket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ticket_prueba] SET  READ_WRITE 
GO
