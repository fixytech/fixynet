USE [master]
GO

/****** Object:  Database [fixynet]    Script Date: 31/8/2021 17:01:07 ******/
CREATE DATABASE [fixynet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'fixynet', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\fixynet.mdf' , SIZE = 78528KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'fixynet_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\fixynet_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [fixynet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [fixynet] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [fixynet] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [fixynet] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [fixynet] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [fixynet] SET ARITHABORT OFF 
GO

ALTER DATABASE [fixynet] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [fixynet] SET AUTO_SHRINK ON 
GO

ALTER DATABASE [fixynet] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [fixynet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [fixynet] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [fixynet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [fixynet] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [fixynet] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [fixynet] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [fixynet] SET  DISABLE_BROKER 
GO

ALTER DATABASE [fixynet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [fixynet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [fixynet] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [fixynet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [fixynet] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [fixynet] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [fixynet] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [fixynet] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [fixynet] SET  MULTI_USER 
GO

ALTER DATABASE [fixynet] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [fixynet] SET DB_CHAINING OFF 
GO

ALTER DATABASE [fixynet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [fixynet] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [fixynet] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [fixynet] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [fixynet] SET QUERY_STORE = OFF
GO

ALTER DATABASE [fixynet] SET  READ_WRITE 
GO


