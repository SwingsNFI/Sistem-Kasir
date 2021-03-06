USE [master]
GO
/****** Object:  Database [KasirDatabase]    Script Date: 3/14/2021 15:03:29 ******/
CREATE DATABASE [KasirDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'KasirDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\KasirDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'KasirDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\KasirDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [KasirDatabase] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [KasirDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [KasirDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [KasirDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [KasirDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [KasirDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [KasirDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [KasirDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [KasirDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [KasirDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [KasirDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [KasirDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [KasirDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [KasirDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [KasirDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [KasirDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [KasirDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [KasirDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [KasirDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [KasirDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [KasirDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [KasirDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [KasirDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [KasirDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [KasirDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [KasirDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [KasirDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [KasirDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [KasirDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [KasirDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [KasirDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [KasirDatabase] SET QUERY_STORE = OFF
GO
USE [KasirDatabase]
GO
/****** Object:  Table [dbo].[TabelBarang]    Script Date: 3/14/2021 15:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabelBarang](
	[id_barang] [int] IDENTITY(1,1) NOT NULL,
	[nama_barang] [varchar](20) NULL,
	[harga_barang] [int] NULL,
	[jumlah_barang] [int] NULL,
	[ptpembuat_barang] [varchar](40) NULL,
	[tgl_barang] [date] NULL,
 CONSTRAINT [PK_TabelBarang] PRIMARY KEY CLUSTERED 
(
	[id_barang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabelDetailTransaksi]    Script Date: 3/14/2021 15:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabelDetailTransaksi](
	[id_transaksi] [int] NULL,
	[id_barang] [int] NULL,
	[nama_barang] [varchar](50) NULL,
	[harga_barang] [varchar](50) NULL,
	[jumlah_barang] [varchar](50) NULL,
	[diskon_harga] [int] NULL,
	[pajak_harga] [int] NULL,
	[total_harga] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabelDiskon]    Script Date: 3/14/2021 15:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabelDiskon](
	[id_diskon] [int] IDENTITY(1,1) NOT NULL,
	[nama_barang] [varchar](20) NULL,
	[jumlah_diskon] [int] NULL,
	[start_date] [date] NULL,
	[expired_date] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabelKaryawan]    Script Date: 3/14/2021 15:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabelKaryawan](
	[id_karyawan] [int] IDENTITY(1,1) NOT NULL,
	[password_karyawan] [varchar](20) NULL,
	[nama_karyawan] [varchar](40) NULL,
	[jabatan_karyawan] [varchar](6) NULL,
	[email_karyawan] [varchar](40) NULL,
	[telepon_karyawan] [varchar](15) NULL,
	[tgllahir_karyawan] [date] NULL,
	[jk_karyawan] [varchar](10) NULL,
	[Pertanyaan1] [varchar](40) NULL,
	[Jawaban1] [varchar](30) NULL,
	[Pertanyaan2] [varchar](40) NULL,
	[Jawaban2] [varchar](30) NULL,
 CONSTRAINT [PK_TabelKaryawan] PRIMARY KEY CLUSTERED 
(
	[id_karyawan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabelMasterTransaksi]    Script Date: 3/14/2021 15:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabelMasterTransaksi](
	[id_transaksi] [int] IDENTITY(1,1) NOT NULL,
	[subtotal_harga] [int] NULL,
	[total_harga] [int] NULL,
	[nominal_pembayaran] [int] NULL,
	[kembalian] [int] NULL,
	[tgl_transaksi] [datetime] NULL,
	[id_karyawan] [int] NULL,
	[nama_karyawan] [varchar](40) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TabelPajak]    Script Date: 3/14/2021 15:03:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabelPajak](
	[id_pajak] [int] IDENTITY(1,1) NOT NULL,
	[nickname_pajak] [varchar](10) NULL,
	[namapanjang_pajak] [varchar](35) NULL,
	[jumlah_pajak] [int] NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [KasirDatabase] SET  READ_WRITE 
GO
