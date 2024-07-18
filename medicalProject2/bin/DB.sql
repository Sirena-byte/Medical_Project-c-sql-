/*    ==Параметры сценариев==

    Версия исходного сервера : SQL Server 2022 (16.0.1115)
    Выпуск исходного ядра СУБД : Выпуск Microsoft SQL Server Express Edition
    Тип исходного ядра СУБД : Изолированный SQL Server

    Версия целевого сервера : SQL Server 2022
    Выпуск целевого ядра СУБД : Выпуск Microsoft SQL Server Express Edition
    Тип целевого ядра СУБД : Изолированный SQL Server
*/
USE [master]
GO
/****** Object:  Database [medical_project_DB]    Script Date: 18.04.2024 6:38:54 ******/
CREATE DATABASE [medical_project_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'medical_project_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\medical_project_DB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'medical_project_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS01\MSSQL\DATA\medical_project_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [medical_project_DB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [medical_project_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [medical_project_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [medical_project_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [medical_project_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [medical_project_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [medical_project_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [medical_project_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [medical_project_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [medical_project_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [medical_project_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [medical_project_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [medical_project_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [medical_project_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [medical_project_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [medical_project_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [medical_project_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [medical_project_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [medical_project_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [medical_project_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [medical_project_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [medical_project_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [medical_project_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [medical_project_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [medical_project_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [medical_project_DB] SET  MULTI_USER 
GO
ALTER DATABASE [medical_project_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [medical_project_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [medical_project_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [medical_project_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [medical_project_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [medical_project_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [medical_project_DB] SET QUERY_STORE = ON
GO
ALTER DATABASE [medical_project_DB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [medical_project_DB]
GO
/****** Object:  Table [dbo].[doctors_profiles]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctors_profiles](
	[id_profile] [int] IDENTITY(1,1) NOT NULL,
	[profile_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__doctor_p__0981A576B2BC9701] PRIMARY KEY CLUSTERED 
(
	[id_profile] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[positions_job]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[positions_job](
	[id_position] [int] IDENTITY(1,1) NOT NULL,
	[name_position] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__position__D652893D3BC553A0] PRIMARY KEY CLUSTERED 
(
	[id_position] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visiting_sheets]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visiting_sheets](
	[id_sheet] [int] IDENTITY(1,1) NOT NULL,
	[date_of_visit] [date] NOT NULL,
	[id_patient] [int] NOT NULL,
	[id_doctor] [int] NOT NULL,
	[inspector] [text] NOT NULL,
	[body_temperature] [varchar](10) NOT NULL,
	[pressure] [varchar](50) NOT NULL,
	[diagnosis] [nvarchar](50) NOT NULL,
	[appointment] [nvarchar](120) NOT NULL,
 CONSTRAINT [PK__visiting__2CC648A43887022D] PRIMARY KEY CLUSTERED 
(
	[id_sheet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patients]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[id_patient] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[date_of_birth] [date] NOT NULL,
	[phone_num] [nvarchar](50) NOT NULL,
	[home_address] [nvarchar](50) NOT NULL,
	[pasport] [varchar](50) NOT NULL,
 CONSTRAINT [PK__patients] PRIMARY KEY CLUSTERED 
(
	[id_patient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[register]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[register](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[login_user] [varchar](50) NOT NULL,
	[password_user] [varchar](50) NOT NULL,
	[id_med] [int] NULL,
	[id_empl] [int] NULL,
 CONSTRAINT [PK_register] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[category]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[id_category] [int] IDENTITY(1,1) NOT NULL,
	[name_category] [varchar](50) NOT NULL,
 CONSTRAINT [PK_category_1] PRIMARY KEY CLUSTERED 
(
	[id_category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[specialisations_department]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[specialisations_department](
	[id_specialisation] [int] IDENTITY(1,1) NOT NULL,
	[name_specialisation] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_specialisations_department] PRIMARY KEY CLUSTERED 
(
	[id_specialisation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[departments]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departments](
	[id_department] [int] IDENTITY(1,1) NOT NULL,
	[hospital_id] [int] NOT NULL,
	[spec_id] [int] NOT NULL,
	[supervisor_id] [int] NOT NULL,
	[phone_num] [int] NOT NULL,
 CONSTRAINT [PK_departments] PRIMARY KEY CLUSTERED 
(
	[id_department] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[id_employee] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[surname] [nvarchar](50) NOT NULL,
	[position_job] [int] NOT NULL,
	[place_of_work] [int] NOT NULL,
	[doctor_profile] [int] NOT NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[id_employee] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medical_inst]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medical_inst](
	[id_inst] [int] IDENTITY(1,1) NOT NULL,
	[id_category] [int] NOT NULL,
	[name_inst] [nvarchar](50) NOT NULL,
	[address_inst] [nvarchar](50) NOT NULL,
	[phone_inst] [varchar](20) NOT NULL,
 CONSTRAINT [PK_medical_inst] PRIMARY KEY CLUSTERED 
(
	[id_inst] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_1]    Script Date: 18.04.2024 6:38:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_1]
AS
SELECT dbo.register.id_med
FROM     dbo.visiting_sheets INNER JOIN
                  dbo.patients ON dbo.visiting_sheets.id_patient = dbo.patients.id_patient INNER JOIN
                  dbo.category INNER JOIN
                  dbo.medical_inst ON dbo.category.id_category = dbo.medical_inst.id_category INNER JOIN
                  dbo.employees ON dbo.medical_inst.id_inst = dbo.employees.place_of_work INNER JOIN
                  dbo.positions_job ON dbo.employees.position_job = dbo.positions_job.id_position ON dbo.visiting_sheets.id_doctor = dbo.employees.id_employee CROSS JOIN
                  dbo.register CROSS JOIN
                  dbo.doctors_profiles CROSS JOIN
                  dbo.specialisations_department INNER JOIN
                  dbo.departments ON dbo.specialisations_department.id_specialisation = dbo.departments.spec_id
GO
SET IDENTITY_INSERT [dbo].[category] ON 

INSERT [dbo].[category] ([id_category], [name_category]) VALUES (1, N'поликлиника')
INSERT [dbo].[category] ([id_category], [name_category]) VALUES (2, N'больница')
INSERT [dbo].[category] ([id_category], [name_category]) VALUES (3, N'аптека')
INSERT [dbo].[category] ([id_category], [name_category]) VALUES (4, N'лаборатория')
INSERT [dbo].[category] ([id_category], [name_category]) VALUES (5, N'none')
INSERT [dbo].[category] ([id_category], [name_category]) VALUES (6, N'test')
SET IDENTITY_INSERT [dbo].[category] OFF
GO
SET IDENTITY_INSERT [dbo].[doctors_profiles] ON 

INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (1, N'гинеколог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (2, N'проктолог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (3, N'офтальмолог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (4, N'оторинголог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (5, N'психиатр')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (6, N'психотерапевт')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (7, N'нарколог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (8, N'кардиолог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (9, N'уролог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (10, N'пульмонолог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (11, N'')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (12, N'терапевт')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (13, N'травматолог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (14, N'эндокринолог')
INSERT [dbo].[doctors_profiles] ([id_profile], [profile_name]) VALUES (15, N'хирург')
SET IDENTITY_INSERT [dbo].[doctors_profiles] OFF
GO
SET IDENTITY_INSERT [dbo].[employees] ON 

INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (1, N'Кирилов', N'Антон', N'Петрович', 2, 3, 1)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (2, N'Воронина', N'Вера', N'Станиславовна', 2, 3, 4)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (10, N'Иванов', N'Виктор', N'Сергеевич', 2, 5, 3)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (11, N'Зайцев', N'Кирилл', N'Станиславович', 13, 7, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (12, N'Попов', N'Владимир', N'Александрович', 3, 9, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (13, N'Власов', N'Николай', N'Александрович', 2, 9, 8)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (14, N'Нестерова', N'Алла', N'Ильинична', 6, 3, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (15, N'Петренко', N'Елизавета', N'Николаевна', 4, 5, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (17, N'Яковлева', N'Нина', N'Степановна', 14, 7, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (18, N'Леонов', N'Кирилл', N'Егорович', 2, 5, 15)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (19, N'Петренко', N'Алла', N'Сергеевна', 13, 9, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (20, N'Валетко', N'Антон', N'Васильевич', 5, 5, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (21, N'Якименко', N'Виктория', N'Игоревна', 8, 3, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (22, N'Раевская', N'Наталья', N'Максимовна', 3, 6, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (26, N'Логинова', N'Полина', N'Юрьевна', 14, 12, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (27, N'Галуза', N'Вероника', N'Петровна', 2, 3, 13)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (28, N'Яковлев', N'Денис', N'Васильевич', 2, 3, 19)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (29, N'Ромашова', N'Светлана', N'Александровна', 2, 3, 17)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (30, N'Воронова', N'Татьяна', N'Романовна', 9, 16, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (31, N'Логунова', N'Василиса', N'Валерьевна', 13, 3, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (32, N'Люхта', N'Ирина', N'Львовна', 2, 3, 8)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (33, N'Сафронов', N'Валентан', N'Евгеньевич', 2, 3, 7)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (34, N'Филимонова', N'Алла', N'Олеговна', 2, 3, 12)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (35, N'Якута', N'Елена', N'Сергеевна', 4, 3, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (36, N'Фролова', N'Татьяна', N'Владимировна', 7, 3, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (37, N'Вершулова', N'Ольга', N'Федоровна', 2, 3, 15)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (38, N'Чапковская', N'Ольга', N'Ивановна', 2, 3, 3)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (39, N'Филимонов', N'Кирилл', N'Станиславович', 11, 3, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (40, N'Протасова', N'Елена', N'Игоревна', 12, 12, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (41, N'Валетко', N'Иван', N'Родионович', 11, 5, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (42, N'Крюкова', N'Вероника', N'Игоревна', 11, 6, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (43, N'Кошкина', N'Наталья', N'Семеновна', 12, 7, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (44, N'Урбановаич', N'Виктор', N'Викторович', 11, 8, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (45, N'Ппротасов', N'Константин', N'Андреевич', 11, 9, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (46, N'Лосик', N'Анна', N'Анатольевна', 11, 10, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (47, N'Лютиков', N'Петр', N'Афанасьевич', 2, 3, 15)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (48, N'Катков', N'Станислав', N'Викторович', 1, 3, 11)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (50, N'Воронова', N'Наталья', N'Федоровна', 2, 3, 13)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (51, N'Уваров', N'Евгений', N'Петрович', 2, 3, 8)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (53, N'Крюкова', N'Алла', N'Романовна', 2, 3, 8)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (58, N'Семенова', N'Анна', N'Денисовна', 2, 3, 15)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (60, N'Давыдов', N'Дмитрий', N'Дмитриевич', 2, 3, 12)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (62, N'Яковлев', N'Максим', N'Павлович', 2, 3, 12)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (64, N'Якута', N'Павел', N'Владимирович', 2, 3, 3)
INSERT [dbo].[employees] ([id_employee], [first_name], [last_name], [surname], [position_job], [place_of_work], [doctor_profile]) VALUES (65, N'Вершулов', N'Никита', N'Иванович', 2, 3, 15)
SET IDENTITY_INSERT [dbo].[employees] OFF
GO
SET IDENTITY_INSERT [dbo].[medical_inst] ON 

INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (3, 2, N'Городская клиническая больница №1', N'Первомайская-48', N'+375 29 456-45-45')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (5, 2, N'Городская клиническая больница №3', N'Кропоткина-8', N'+375 33 256-56-47')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (6, 1, N'Городская поликлиника №1', N'Плеханова-59', N'+375 44 245-56-89')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (7, 3, N'Аптека №1', N'Чайковского-45', N'+375 25 478-89-63')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (8, 2, N'Городская больница №1', N'Никольская-17', N'+375 29 555-89-89')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (9, 1, N'Городская поликлиника №2', N'Рокосовского-16', N'+375 25 455-45-45')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (10, 1, N'Городская поликлиника №3', N'Ленина-156', N'+375 33 452-45-45')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (12, 3, N'Аптека №3', N'Чкалова-15', N'(375) 29-455-78-98')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (16, 5, N'Все организации', N'none', N'none')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (20, 2, N'Городская больница №2', N'Чайковского-18', N'+375 44 125-45-82')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (21, 2, N'Городская больница №3', N'Первомайская-205', N'+375 33 125-45-65')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (22, 1, N'Аптека №2', N'Павлова-12', N'+375 29 845-56-89 ')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (23, 2, N'Городская клиническая больница №2', N'Ленина-21', N'+375 29 451-12-26')
INSERT [dbo].[medical_inst] ([id_inst], [id_category], [name_inst], [address_inst], [phone_inst]) VALUES (24, 3, N'Аптека №4', N'Никольская-45', N'+375 33 356-56-92')
SET IDENTITY_INSERT [dbo].[medical_inst] OFF
GO
SET IDENTITY_INSERT [dbo].[patients] ON 

INSERT [dbo].[patients] ([id_patient], [first_name], [last_name], [surname], [date_of_birth], [phone_num], [home_address], [pasport]) VALUES (1, N'Вершулов', N'Андрей', N'Андреевич', CAST(N'1993-10-12' AS Date), N'+375 25 555-89-89', N'Красноармейская 23-55', N'MC451278')
INSERT [dbo].[patients] ([id_patient], [first_name], [last_name], [surname], [date_of_birth], [phone_num], [home_address], [pasport]) VALUES (2, N'Рожков', N'Дмитрий', N'Андреевич', CAST(N'1993-10-12' AS Date), N'+375 25 555-89-89', N'Лобана 128-32', N'MC457889')
INSERT [dbo].[patients] ([id_patient], [first_name], [last_name], [surname], [date_of_birth], [phone_num], [home_address], [pasport]) VALUES (3, N'Дмитриев', N'Илья', N'Родионович', CAST(N'1990-10-10' AS Date), N'+375 25 245-56-78', N'Фадеева 15', N'MC565656')
INSERT [dbo].[patients] ([id_patient], [first_name], [last_name], [surname], [date_of_birth], [phone_num], [home_address], [pasport]) VALUES (4, N'Павлова', N'Светлана', N'Викторовна', CAST(N'1986-10-24' AS Date), N'+375 29 564-58-99', N'Свердлова 18-186', N'MC123235')
INSERT [dbo].[patients] ([id_patient], [first_name], [last_name], [surname], [date_of_birth], [phone_num], [home_address], [pasport]) VALUES (5, N'Валетко', N'Янина', N'Леонидовна', CAST(N'1984-10-24' AS Date), N'+375 29-564-58-99', N'Пионерская 17', N'MC125987')
INSERT [dbo].[patients] ([id_patient], [first_name], [last_name], [surname], [date_of_birth], [phone_num], [home_address], [pasport]) VALUES (6, N'Колесникова', N'Ирина', N'Михайловна', CAST(N'2000-02-19' AS Date), N'+375 33-458-78-95', N'Ермолова 15', N'MC123456')
INSERT [dbo].[patients] ([id_patient], [first_name], [last_name], [surname], [date_of_birth], [phone_num], [home_address], [pasport]) VALUES (7, N'Рыжиков', N'Генадий', N'Вячеславович', CAST(N'2000-05-04' AS Date), N'+375 33 312-45-78', N'Лермонтова 12-154', N'MC124578')
INSERT [dbo].[patients] ([id_patient], [first_name], [last_name], [surname], [date_of_birth], [phone_num], [home_address], [pasport]) VALUES (10, N'Данилова', N'Кристина', N'Витальевна', CAST(N'1992-04-12' AS Date), N'+375 33 313-25-56', N'Романова 16', N'MC123478')
INSERT [dbo].[patients] ([id_patient], [first_name], [last_name], [surname], [date_of_birth], [phone_num], [home_address], [pasport]) VALUES (13, N'Варламов', N'Никита', N'Сергеевич', CAST(N'2001-04-17' AS Date), N'+375 29 124-57-88', N'Фадеева 17', N'MC124579')
SET IDENTITY_INSERT [dbo].[patients] OFF
GO
SET IDENTITY_INSERT [dbo].[positions_job] ON 

INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (1, N'водитель')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (2, N'врач')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (3, N'мед.брат/мед.сестра')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (4, N'сестра хозяйка')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (5, N'лаборант')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (6, N'операционная сестра')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (7, N'процедурная сестра')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (8, N'санитар/санитарка')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (9, N'уборщик помещений')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (10, N'дворник')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (11, N'директор')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (12, N'заведующий')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (13, N'регистратор')
INSERT [dbo].[positions_job] ([id_position], [name_position]) VALUES (14, N'провизор')
SET IDENTITY_INSERT [dbo].[positions_job] OFF
GO
SET IDENTITY_INSERT [dbo].[register] ON 

INSERT [dbo].[register] ([id_user], [login_user], [password_user], [id_med], [id_empl]) VALUES (1, N'admin', N'admin', 16, NULL)
INSERT [dbo].[register] ([id_user], [login_user], [password_user], [id_med], [id_empl]) VALUES (2, N'admin', N'admin2', 12, 40)
INSERT [dbo].[register] ([id_user], [login_user], [password_user], [id_med], [id_empl]) VALUES (3, N'admin', N'admin3', 3, 39)
INSERT [dbo].[register] ([id_user], [login_user], [password_user], [id_med], [id_empl]) VALUES (5, N'admin', N'admin5', 5, 41)
INSERT [dbo].[register] ([id_user], [login_user], [password_user], [id_med], [id_empl]) VALUES (6, N'admin', N'admin6', 6, 42)
INSERT [dbo].[register] ([id_user], [login_user], [password_user], [id_med], [id_empl]) VALUES (7, N'admin', N'admin7', 7, 43)
INSERT [dbo].[register] ([id_user], [login_user], [password_user], [id_med], [id_empl]) VALUES (8, N'admin', N'admin8', 8, 44)
INSERT [dbo].[register] ([id_user], [login_user], [password_user], [id_med], [id_empl]) VALUES (9, N'admin', N'admin9', 9, 45)
INSERT [dbo].[register] ([id_user], [login_user], [password_user], [id_med], [id_empl]) VALUES (16, N'doc', N'doc1', NULL, 50)
SET IDENTITY_INSERT [dbo].[register] OFF
GO
SET IDENTITY_INSERT [dbo].[specialisations_department] ON 

INSERT [dbo].[specialisations_department] ([id_specialisation], [name_specialisation]) VALUES (1, N'гастроэнторология')
INSERT [dbo].[specialisations_department] ([id_specialisation], [name_specialisation]) VALUES (2, N'гинекология')
INSERT [dbo].[specialisations_department] ([id_specialisation], [name_specialisation]) VALUES (3, N'кардиология')
INSERT [dbo].[specialisations_department] ([id_specialisation], [name_specialisation]) VALUES (4, N'лор')
INSERT [dbo].[specialisations_department] ([id_specialisation], [name_specialisation]) VALUES (5, N'неврологгия')
INSERT [dbo].[specialisations_department] ([id_specialisation], [name_specialisation]) VALUES (6, N'офтальмология')
INSERT [dbo].[specialisations_department] ([id_specialisation], [name_specialisation]) VALUES (7, N'психиатрия')
INSERT [dbo].[specialisations_department] ([id_specialisation], [name_specialisation]) VALUES (8, N'урология')
INSERT [dbo].[specialisations_department] ([id_specialisation], [name_specialisation]) VALUES (9, N'хирургия')
SET IDENTITY_INSERT [dbo].[specialisations_department] OFF
GO
SET IDENTITY_INSERT [dbo].[visiting_sheets] ON 

INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (1, CAST(N'2024-01-01' AS Date), 1, 1, N'test', N'120/80', N'36.6', N'test', N'test')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (2, CAST(N'2024-04-11' AS Date), 1, 1, N'тестовая запись', N'37,0', N'160/80', N'тест', N'тест')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (3, CAST(N'2024-04-11' AS Date), 2, 1, N'тестовая запись 2', N'37,2', N'130/80', N'тест', N'тест')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (4, CAST(N'2024-04-11' AS Date), 2, 2, N'болит живот', N'37,2', N'140/80', N'понос', N'пить водичку')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (5, CAST(N'2024-04-11' AS Date), 1, 2, N'здоров', N'36,6', N'120/80', N'здоров', N'-')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (6, CAST(N'2024-04-11' AS Date), 2, 1, N'test', N'37,6', N'120/70', N'test', N'test')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (7, CAST(N'2024-04-12' AS Date), 2, 2, N'test', N'37,7', N'120/80', N'test', N'test')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (8, CAST(N'2024-04-12' AS Date), 1, 1, N'test', N'37,7', N'120/80', N'test', N'test')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (9, CAST(N'2024-04-12' AS Date), 2, 1, N'test', N'37,1', N'180/80', N'test', N'test')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (10, CAST(N'2024-04-11' AS Date), 1, 1, N'тест', N'36,6', N'120/80', N'тест', N'тест')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (11, CAST(N'2024-04-11' AS Date), 2, 1, N'test', N'37,6', N'120/70', N'test', N'test')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (12, CAST(N'2024-04-12' AS Date), 2, 2, N'test', N'37,7', N'120/80', N'test', N'test')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (13, CAST(N'2024-04-12' AS Date), 2, 2, N'test', N'37,7', N'120/80', N'test', N'test')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (14, CAST(N'2024-04-12' AS Date), 3, 27, N'тестовая запись 13.04', N'37,3', N'160/80', N'тест 13.04', N'тест 13.04')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (15, CAST(N'2024-04-17' AS Date), 5, 34, N'Жалобы на сухой кашель, насморк, повышенную температуру тела, озноб, слабость', N'37,6', N'120/80', N'ОРВИ', N'Парацетомол 1т/ 3 раза в день')
INSERT [dbo].[visiting_sheets] ([id_sheet], [date_of_visit], [id_patient], [id_doctor], [inspector], [body_temperature], [pressure], [diagnosis], [appointment]) VALUES (16, CAST(N'2024-04-17' AS Date), 6, 34, N'Жалобы на головную боль, шум в голове, быструю утомляемость', N'36,7', N'160/80', N'Гипертония', N'консультация кардиолога')
SET IDENTITY_INSERT [dbo].[visiting_sheets] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tmp_ms_x__3CA2765A71103106]    Script Date: 18.04.2024 6:38:54 ******/
ALTER TABLE [dbo].[patients] ADD  CONSTRAINT [UQ__tmp_ms_x__3CA2765A71103106] UNIQUE NONCLUSTERED 
(
	[pasport] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__register__64782EC9B555EAA4]    Script Date: 18.04.2024 6:38:54 ******/
ALTER TABLE [dbo].[register] ADD  CONSTRAINT [UQ__register__64782EC9B555EAA4] UNIQUE NONCLUSTERED 
(
	[password_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__register__FA6E2789C3ED69AF]    Script Date: 18.04.2024 6:38:54 ******/
ALTER TABLE [dbo].[register] ADD  CONSTRAINT [UQ__register__FA6E2789C3ED69AF] UNIQUE NONCLUSTERED 
(
	[id_empl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__register__FA6E2789CE28054C]    Script Date: 18.04.2024 6:38:54 ******/
ALTER TABLE [dbo].[register] ADD  CONSTRAINT [UQ__register__FA6E2789CE28054C] UNIQUE NONCLUSTERED 
(
	[id_empl] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[departments]  WITH CHECK ADD  CONSTRAINT [FK_departments_specialisations_department] FOREIGN KEY([spec_id])
REFERENCES [dbo].[specialisations_department] ([id_specialisation])
GO
ALTER TABLE [dbo].[departments] CHECK CONSTRAINT [FK_departments_specialisations_department]
GO
ALTER TABLE [dbo].[employees]  WITH CHECK ADD  CONSTRAINT [FK_employees_medical_inst] FOREIGN KEY([place_of_work])
REFERENCES [dbo].[medical_inst] ([id_inst])
GO
ALTER TABLE [dbo].[employees] CHECK CONSTRAINT [FK_employees_medical_inst]
GO
ALTER TABLE [dbo].[employees]  WITH CHECK ADD  CONSTRAINT [FK_employees_positions_job] FOREIGN KEY([position_job])
REFERENCES [dbo].[positions_job] ([id_position])
GO
ALTER TABLE [dbo].[employees] CHECK CONSTRAINT [FK_employees_positions_job]
GO
ALTER TABLE [dbo].[medical_inst]  WITH CHECK ADD  CONSTRAINT [FK_medical_inst_category] FOREIGN KEY([id_category])
REFERENCES [dbo].[category] ([id_category])
GO
ALTER TABLE [dbo].[medical_inst] CHECK CONSTRAINT [FK_medical_inst_category]
GO
ALTER TABLE [dbo].[register]  WITH CHECK ADD  CONSTRAINT [FK_register_employees] FOREIGN KEY([id_empl])
REFERENCES [dbo].[employees] ([id_employee])
GO
ALTER TABLE [dbo].[register] CHECK CONSTRAINT [FK_register_employees]
GO
ALTER TABLE [dbo].[visiting_sheets]  WITH CHECK ADD  CONSTRAINT [FK_visiting_sheets_employees] FOREIGN KEY([id_doctor])
REFERENCES [dbo].[employees] ([id_employee])
GO
ALTER TABLE [dbo].[visiting_sheets] CHECK CONSTRAINT [FK_visiting_sheets_employees]
GO
ALTER TABLE [dbo].[visiting_sheets]  WITH CHECK ADD  CONSTRAINT [FK_visiting_sheets_patients] FOREIGN KEY([id_patient])
REFERENCES [dbo].[patients] ([id_patient])
GO
ALTER TABLE [dbo].[visiting_sheets] CHECK CONSTRAINT [FK_visiting_sheets_patients]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[90] 4[2] 2[3] 3) )"
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
         Begin Table = "category"
            Begin Extent = 
               Top = 612
               Left = 304
               Bottom = 731
               Right = 505
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "departments"
            Begin Extent = 
               Top = 0
               Left = 293
               Bottom = 190
               Right = 494
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "doctors_profiles"
            Begin Extent = 
               Top = 168
               Left = 1014
               Bottom = 293
               Right = 1215
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "employees"
            Begin Extent = 
               Top = 316
               Left = 1017
               Bottom = 550
               Right = 1218
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "medical_inst"
            Begin Extent = 
               Top = 552
               Left = 694
               Bottom = 715
               Right = 895
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "patients"
            Begin Extent = 
               Top = 126
               Left = 546
               Bottom = 289
               Right = 747
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "positions_job"
            Begin Extent = 
               Top = 488
               Left = 310
               Bottom = 607
               Right = 511
            E' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'nd
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "register"
            Begin Extent = 
               Top = 173
               Left = 45
               Bottom = 336
               Right = 246
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "specialisations_department"
            Begin Extent = 
               Top = 533
               Left = 37
               Bottom = 652
               Right = 265
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "visiting_sheets"
            Begin Extent = 
               Top = 197
               Left = 296
               Bottom = 475
               Right = 513
            End
            DisplayFlags = 280
            TopColumn = 0
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_1'
GO
USE [master]
GO
ALTER DATABASE [medical_project_DB] SET  READ_WRITE 
GO
