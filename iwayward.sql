USE [master]
GO
/****** Object:  Database [iwayward]    Script Date: 2015/3/2 23:18:13 ******/
CREATE DATABASE [iwayward]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'iwayward', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\iwayward.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'iwayward_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\iwayward_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [iwayward] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [iwayward].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [iwayward] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [iwayward] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [iwayward] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [iwayward] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [iwayward] SET ARITHABORT OFF 
GO
ALTER DATABASE [iwayward] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [iwayward] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [iwayward] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [iwayward] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [iwayward] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [iwayward] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [iwayward] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [iwayward] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [iwayward] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [iwayward] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [iwayward] SET  DISABLE_BROKER 
GO
ALTER DATABASE [iwayward] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [iwayward] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [iwayward] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [iwayward] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [iwayward] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [iwayward] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [iwayward] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [iwayward] SET RECOVERY FULL 
GO
ALTER DATABASE [iwayward] SET  MULTI_USER 
GO
ALTER DATABASE [iwayward] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [iwayward] SET DB_CHAINING OFF 
GO
ALTER DATABASE [iwayward] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [iwayward] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'iwayward', N'ON'
GO
USE [iwayward]
GO
/****** Object:  Table [dbo].[AttentionIndustry]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AttentionIndustry](
	[UserID] [nvarchar](50) NULL,
	[IndID1] [int] NULL,
	[IndMark1] [varchar](max) NULL,
	[IndID2] [int] NULL,
	[IndMark2] [varchar](max) NULL,
	[IndID3] [int] NULL,
	[IndMark3] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CODE]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CODE](
	[CodeID] [varchar](32) NOT NULL,
	[CodeName] [varchar](100) NULL,
	[CodeFatherID] [varchar](32) NULL,
	[CodeIndex] [int] NULL,
	[CodeValue1] [varchar](50) NULL,
	[CodeValue2] [varchar](50) NULL,
	[CodeValue3] [varchar](50) NULL,
	[CodeMark] [varchar](1000) NULL,
 CONSTRAINT [PK_CODE] PRIMARY KEY CLUSTERED 
(
	[CodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[comments]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[comments](
	[commID] [int] NOT NULL,
	[serviceID] [int] NULL,
	[context] [varchar](max) NULL,
	[commDateTime] [nvarchar](50) NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_COMMENTS] PRIMARY KEY CLUSTERED 
(
	[commID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[companyTable]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[companyTable](
	[companyID] [int] NULL,
	[userID] [varchar](50) NULL,
	[companyName] [varchar](50) NULL,
	[companyType] [varchar](32) NULL,
	[companyCount] [int] NULL,
	[describe] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[industry]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[industry](
	[IndID] [int] NOT NULL,
	[IndName] [varchar](50) NULL,
	[IndChildID] [int] NULL,
	[IndChildName] [varchar](50) NULL,
 CONSTRAINT [PK_INDUSTRY] PRIMARY KEY CLUSTERED 
(
	[IndID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[jobTable]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[jobTable](
	[jobID] [int] NULL,
	[userID] [varchar](50) NULL,
	[companyID] [int] NULL,
	[position] [varchar](32) NULL,
	[beginTime] [varchar](50) NULL,
	[endTime] [varchar](50) NULL,
	[describe] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonnelRelationship]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonnelRelationship](
	[UserID] [nvarchar](50) NULL,
	[objType] [varchar](32) NULL,
	[GUserID] [nvarchar](50) NULL,
	[IndID] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[positionInfo]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[positionInfo](
	[posID] [int] NULL,
	[userID] [varchar](50) NULL,
	[companyID] [int] NULL,
	[posName] [varchar](50) NULL,
	[createTime] [varchar](50) NULL,
	[region] [int] NULL,
	[city] [int] NULL,
	[province] [int] NULL,
	[record] [varchar](32) NULL,
	[recruitment] [int] NULL,
	[range] [varchar](100) NULL,
	[posstate] [int] NULL,
	[posType] [varchar](max) NULL,
	[requirements] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[projectTable]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[projectTable](
	[projectID] [int] NULL,
	[userID] [varchar](50) NULL,
	[projectName] [varchar](50) NULL,
	[projectType] [varchar](32) NULL,
	[beginTime] [varchar](50) NULL,
	[endTime] [varchar](50) NULL,
	[describe] [varchar](max) NULL,
	[duties] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[regionTable]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[regionTable](
	[provinceID] [int] NULL,
	[provinceName] [varchar](32) NULL,
	[cityID] [int] NULL,
	[cityName] [varchar](32) NULL,
	[regionID] [int] NULL,
	[regionName] [varchar](32) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[resume]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[resume](
	[resumeID] [int] NULL,
	[userID] [varchar](50) NULL,
	[jobState] [varchar](32) NULL,
	[resumeState] [varchar](32) NULL,
	[myEdu] [varchar](32) NULL,
	[jobYear] [varchar](32) NULL,
	[toAddress] [varchar](max) NULL,
	[industry] [varchar](32) NULL,
	[position] [varchar](32) NULL,
	[salary] [varchar](32) NULL,
	[research] [varchar](max) NULL,
	[jobID] [int] NULL,
	[projectID] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[resumeJob]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[resumeJob](
	[resumeID] [int] NULL,
	[jobID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[resumePoject]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[resumePoject](
	[resumeID] [int] NULL,
	[pojectID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServiceInformation]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ServiceInformation](
	[ServicID] [int] NOT NULL,
	[UserID] [nvarchar](50) NULL,
	[title] [varchar](32) NULL,
	[serviceTyoe] [varchar](32) NULL,
	[IndID] [int] NULL,
	[sendTime] [nvarchar](50) NULL,
	[region] [varchar](100) NULL,
	[city] [varchar](100) NULL,
	[province] [varchar](100) NULL,
	[macrk] [varchar](100) NULL,
	[longitude] [decimal](32, 32) NULL,
	[latitude] [decimal](32, 32) NULL,
	[address] [nvarchar](max) NULL,
 CONSTRAINT [PK_SERVICEINFORMATION] PRIMARY KEY CLUSTERED 
(
	[ServicID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[servicepipei]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[servicepipei](
	[UserID] [nvarchar](50) NULL,
	[ServicID] [int] NULL,
	[PUserID] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[smgInfo]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[smgInfo](
	[smgID] [int] NOT NULL,
	[FromUserID] [nvarchar](50) NULL,
	[ToUserID] [nvarchar](50) NULL,
	[smgtype] [varchar](32) NULL,
	[smgContext] [varchar](max) NULL,
	[smgimg] [varchar](max) NULL,
	[smgvioe] [varchar](max) NULL,
	[fromTime] [nvarchar](50) NULL,
	[toTime] [nvarchar](50) NULL,
 CONSTRAINT [PK_SMGINFO] PRIMARY KEY CLUSTERED 
(
	[smgID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 2015/3/2 23:18:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[userID] [nvarchar](50) NOT NULL,
	[phone] [nvarchar](50) NULL,
	[headUrl] [varchar](100) NULL,
	[nickName] [varchar](50) NULL,
	[userName] [varchar](50) NULL,
	[age] [int] NULL,
	[sex] [int] NULL,
	[region] [varchar](100) NULL,
	[city] [varchar](100) NULL,
	[province] [varchar](100) NULL,
	[mail] [varchar](100) NULL,
	[qqNo] [int] NULL,
	[sinaID] [varchar](50) NULL,
	[tengID] [varchar](50) NULL,
	[baiduID] [varchar](50) NULL,
	[weixinID] [varchar](50) NULL,
	[weixinName] [varchar](100) NULL,
	[weixinTwo] [varchar](100) NULL,
	[professional] [varchar](100) NULL,
	[industry] [varchar](100) NULL,
	[position] [varchar](100) NULL,
	[erweima] [varchar](100) NULL,
	[zhuceTime] [nvarchar](50) NULL,
	[qianming] [varchar](500) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_USERINFO] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [iwayward] SET  READ_WRITE 
GO
