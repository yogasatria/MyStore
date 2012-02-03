USE [master]
GO

/****** Object:  Database [MyStoreDB]    Script Date: 02/03/2012 17:24:57 ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'MyStoreDB')
DROP DATABASE [MyStoreDB]
GO

USE [master]
GO

/****** Object:  Database [MyStoreDB]    Script Date: 02/03/2012 17:24:57 ******/
CREATE DATABASE [MyStoreDB] ON  PRIMARY 
( NAME = N'MyStoreDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\MyStoreDB.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MyStoreDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\MyStoreDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [MyStoreDB] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyStoreDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MyStoreDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MyStoreDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MyStoreDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MyStoreDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MyStoreDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [MyStoreDB] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MyStoreDB] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [MyStoreDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MyStoreDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MyStoreDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MyStoreDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MyStoreDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MyStoreDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MyStoreDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MyStoreDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MyStoreDB] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MyStoreDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MyStoreDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MyStoreDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MyStoreDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MyStoreDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MyStoreDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MyStoreDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MyStoreDB] SET  READ_WRITE 
GO

ALTER DATABASE [MyStoreDB] SET RECOVERY FULL 
GO

ALTER DATABASE [MyStoreDB] SET  MULTI_USER 
GO

ALTER DATABASE [MyStoreDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MyStoreDB] SET DB_CHAINING OFF 
GO
