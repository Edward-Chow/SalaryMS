USE [master]
GO
/****** Object:  Database [SalaryDb]    Script Date: 2018/1/2 14:14:23 ******/
CREATE DATABASE [SalaryDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SalaryDb', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\SalaryDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SalaryDb_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\SalaryDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [SalaryDb] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SalaryDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SalaryDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SalaryDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SalaryDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SalaryDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SalaryDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [SalaryDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SalaryDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SalaryDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SalaryDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SalaryDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SalaryDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SalaryDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SalaryDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SalaryDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SalaryDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SalaryDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SalaryDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SalaryDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SalaryDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SalaryDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SalaryDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SalaryDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SalaryDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SalaryDb] SET  MULTI_USER 
GO
ALTER DATABASE [SalaryDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SalaryDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SalaryDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SalaryDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SalaryDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SalaryDb] SET QUERY_STORE = OFF
GO
USE [SalaryDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [SalaryDb]
GO
/****** Object:  Table [dbo].[工资表]    Script Date: 2018/1/2 14:14:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[工资表](
	[职工号] [int] NOT NULL,
	[日期] [datetime] NOT NULL,
	[基本工资] [money] NULL,
	[加班费] [money] NULL,
	[扣款] [money] NULL,
	[当月工资] [money] NULL,
 CONSTRAINT [PK_工资表] PRIMARY KEY NONCLUSTERED 
(
	[职工号] ASC,
	[日期] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[考勤情况]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[考勤情况](
	[职工号] [int] NOT NULL,
	[日期] [datetime] NOT NULL,
	[缺勤天数] [char](10) NULL,
	[请假天数] [char](10) NULL,
	[迟到天数] [char](10) NULL,
	[加班天数] [char](10) NULL,
 CONSTRAINT [PK_考勤情况] PRIMARY KEY NONCLUSTERED 
(
	[职工号] ASC,
	[日期] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[员工信息]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[员工信息](
	[职工号] [int] NOT NULL,
	[部门编号] [int] NULL,
	[职务] [nchar](10) NULL,
	[姓名] [varchar](20) NULL,
	[性别] [char](5) NULL,
	[年龄] [smallint] NULL,
	[学历] [char](5) NULL,
	[工龄] [smallint] NULL,
	[职称] [char](10) NULL,
	[银行卡号] [int] NULL,
 CONSTRAINT [PK_员工信息] PRIMARY KEY NONCLUSTERED 
(
	[职工号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[查询工资]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[查询工资]
AS
SELECT   dbo.工资表.职工号, dbo.员工信息.姓名, dbo.员工信息.性别, dbo.员工信息.年龄, dbo.员工信息.部门编号, 
                dbo.工资表.日期, dbo.工资表.基本工资, dbo.考勤情况.缺勤天数, dbo.考勤情况.请假天数, dbo.考勤情况.迟到天数, 
                dbo.考勤情况.加班天数, dbo.工资表.加班费, dbo.工资表.扣款, dbo.工资表.当月工资
FROM      dbo.员工信息 INNER JOIN
                dbo.工资表 ON dbo.员工信息.职工号 = dbo.工资表.员工信_职工号 INNER JOIN
                dbo.考勤情况 ON dbo.员工信息.职工号 = dbo.考勤情况.员工信_职工号
GO
/****** Object:  View [dbo].[查询员工信息]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[查询员工信息]
AS
SELECT   职工号, 部门编号, 姓名, 性别, 年龄, 学历, 工龄, 职称, 银行卡号
FROM      dbo.员工信息
GO
/****** Object:  Table [dbo].[部门信息]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[部门信息](
	[部门编号] [int] NOT NULL,
	[部门名称] [varchar](20) NULL,
 CONSTRAINT [PK_部门信息] PRIMARY KEY NONCLUSTERED 
(
	[部门编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[工龄工资]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[工龄工资](
	[工龄] [int] NOT NULL,
	[工资] [money] NULL,
 CONSTRAINT [PK_工龄工资] PRIMARY KEY CLUSTERED 
(
	[工龄] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[其他工资标准]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[其他工资标准](
	[迟到每天扣款] [money] NULL,
	[缺勤每天扣款] [money] NULL,
	[请假每天扣款] [money] NULL,
	[加班每天奖金] [money] NULL,
	[部门编号] [int] NOT NULL,
 CONSTRAINT [PK_其他工资标准] PRIMARY KEY CLUSTERED 
(
	[部门编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[系统用户]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[系统用户](
	[用户名] [int] NOT NULL,
	[名字] [varchar](20) NULL,
	[密码] [varchar](20) NULL,
	[部门名称] [varchar](20) NULL,
 CONSTRAINT [PK_系统用户] PRIMARY KEY NONCLUSTERED 
(
	[用户名] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[学历工资]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[学历工资](
	[学历] [nchar](10) NOT NULL,
	[工资] [money] NULL,
 CONSTRAINT [PK_学历工资] PRIMARY KEY CLUSTERED 
(
	[学历] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[职称工资]    Script Date: 2018/1/2 14:14:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[职称工资](
	[职称] [nchar](10) NOT NULL,
	[工资] [money] NULL,
 CONSTRAINT [PK_职称工资] PRIMARY KEY CLUSTERED 
(
	[职称] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [部门_FK]    Script Date: 2018/1/2 14:14:24 ******/
CREATE NONCLUSTERED INDEX [部门_FK] ON [dbo].[员工信息]
(
	[部门编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[工资表]  WITH CHECK ADD  CONSTRAINT [FK_工资表_职工号] FOREIGN KEY([职工号])
REFERENCES [dbo].[员工信息] ([职工号])
GO
ALTER TABLE [dbo].[工资表] CHECK CONSTRAINT [FK_工资表_职工号]
GO
ALTER TABLE [dbo].[考勤情况]  WITH CHECK ADD  CONSTRAINT [FK_考勤情况_职工信息] FOREIGN KEY([职工号])
REFERENCES [dbo].[员工信息] ([职工号])
GO
ALTER TABLE [dbo].[考勤情况] CHECK CONSTRAINT [FK_考勤情况_职工信息]
GO
ALTER TABLE [dbo].[其他工资标准]  WITH CHECK ADD  CONSTRAINT [FK_其他工资标准_部门信息] FOREIGN KEY([部门编号])
REFERENCES [dbo].[部门信息] ([部门编号])
GO
ALTER TABLE [dbo].[其他工资标准] CHECK CONSTRAINT [FK_其他工资标准_部门信息]
GO
ALTER TABLE [dbo].[系统用户]  WITH CHECK ADD  CONSTRAINT [FK_系统用户_职工号] FOREIGN KEY([用户名])
REFERENCES [dbo].[员工信息] ([职工号])
GO
ALTER TABLE [dbo].[系统用户] CHECK CONSTRAINT [FK_系统用户_职工号]
GO
ALTER TABLE [dbo].[员工信息]  WITH CHECK ADD  CONSTRAINT [FK_员工信息_部门_部门信息] FOREIGN KEY([部门编号])
REFERENCES [dbo].[部门信息] ([部门编号])
GO
ALTER TABLE [dbo].[员工信息] CHECK CONSTRAINT [FK_员工信息_部门_部门信息]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "工资表"
            Begin Extent = 
               Top = 6
               Left = 218
               Bottom = 146
               Right = 384
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "员工信息"
            Begin Extent = 
               Top = 6
               Left = 422
               Bottom = 146
               Right = 588
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "考勤情况"
            Begin Extent = 
               Top = 42
               Left = 42
               Bottom = 182
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 3
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'查询工资'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'查询工资'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "员工信息"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 146
               Right = 204
            End
            DisplayFlags = 280
            TopColumn = 6
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'查询员工信息'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'查询员工信息'
GO
USE [master]
GO
ALTER DATABASE [SalaryDb] SET  READ_WRITE 
GO
