USE [master]
GO
/****** Object:  Database [ProiectPOO]    Script Date: 03.11.2023 00:23:55 ******/
CREATE DATABASE [ProiectPOO]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProiectPOO', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ProiectPOO.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProiectPOO_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ProiectPOO_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ProiectPOO] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProiectPOO].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProiectPOO] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProiectPOO] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProiectPOO] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProiectPOO] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProiectPOO] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProiectPOO] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProiectPOO] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProiectPOO] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProiectPOO] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProiectPOO] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProiectPOO] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProiectPOO] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProiectPOO] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProiectPOO] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProiectPOO] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProiectPOO] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProiectPOO] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProiectPOO] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProiectPOO] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProiectPOO] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProiectPOO] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProiectPOO] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProiectPOO] SET RECOVERY FULL 
GO
ALTER DATABASE [ProiectPOO] SET  MULTI_USER 
GO
ALTER DATABASE [ProiectPOO] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProiectPOO] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProiectPOO] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProiectPOO] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProiectPOO] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProiectPOO] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProiectPOO', N'ON'
GO
ALTER DATABASE [ProiectPOO] SET QUERY_STORE = ON
GO
ALTER DATABASE [ProiectPOO] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ProiectPOO]
GO
/****** Object:  Table [dbo].[cadre_didactice]    Script Date: 03.11.2023 00:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cadre_didactice](
	[nume] [varchar](15) NULL,
	[prenume] [varchar](15) NULL,
	[marca_angajat] [varchar](10) NULL,
	[titlu] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[catalog_note]    Script Date: 03.11.2023 00:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catalog_note](
	[nr_matricol_student] [varchar](10) NULL,
	[disciplina] [varchar](20) NULL,
	[nota] [varchar](3) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cicluri_invatamant]    Script Date: 03.11.2023 00:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cicluri_invatamant](
	[cod] [varchar](2) NULL,
	[tip] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[conturi]    Script Date: 03.11.2023 00:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[conturi](
	[username] [varchar](50) NULL,
	[parola] [varchar](20) NULL,
	[administrator] [varchar](20) NULL,
	[secretar] [varchar](20) NULL,
	[cadru_didactic] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[discipline]    Script Date: 03.11.2023 00:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[discipline](
	[an] [varchar](2) NULL,
	[semestru] [varchar](2) NULL,
	[cod] [varchar](10) NULL,
	[nume] [varchar](20) NULL,
	[acronim] [varchar](10) NULL,
	[credite] [varchar](2) NULL,
	[programa] [varchar](15) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[grupe]    Script Date: 03.11.2023 00:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupe](
	[C] [varchar](2) NULL,
	[F] [varchar](2) NULL,
	[P] [varchar](2) NULL,
	[A] [varchar](2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[programe_studii]    Script Date: 03.11.2023 00:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[programe_studii](
	[ciclu] [varchar](2) NULL,
	[cod] [varchar](2) NULL,
	[tip] [varchar](10) NULL,
	[ani] [varchar](2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studenti]    Script Date: 03.11.2023 00:23:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studenti](
	[nr_matricol] [varchar](20) NULL,
	[nume] [varchar](15) NULL,
	[prenume] [varchar](15) NULL,
	[initiala_tata] [varchar](10) NULL,
	[CNP] [varchar](13) NULL,
	[data_inscriere] [date] NULL,
	[ciclu_invataman] [varchar](10) NULL,
	[medie] [varchar](10) NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [ProiectPOO] SET  READ_WRITE 
GO
