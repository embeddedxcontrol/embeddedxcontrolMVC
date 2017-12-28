USE master;  
GO  

IF DB_ID (N'exc') IS NOT NULL
DROP DATABASE exc;
GO
CREATE DATABASE exc
ON   
( NAME = excmdf,  
    FILENAME = 'C:\USERS\XPS 13\DOCUMENTS\VISUAL STUDIO 2017\PROJECTS\EMBEDDEDXCONTROLMVC\EMBEDDEDXCONTROL\APP_DATA\EXC.MDF' )  
LOG ON  
( NAME = excldf,  
    FILENAME = 'C:\USERS\XPS 13\DOCUMENTS\VISUAL STUDIO 2017\PROJECTS\EMBEDDEDXCONTROLMVC\EMBEDDEDXCONTROL\APP_DATA\EXC.LDF') ;  
GO  

USE exc
GO

/**********************************************************************************************/
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 11/30/2017 12:14:49 AM ******/
/**********************************************************************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'__MigrationHistory') IS NULL 
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/***************************************************************************************/
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/30/2017 12:15:46 AM ******/
/***************************************************************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetRoles') IS NULL 
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/***************************************************************************************/
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/30/2017 12:22:19 AM ******/
/***************************************************************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetUsers') IS NULL 
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

/********************************************************************************************/
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/30/2017 12:18:07 AM ******/
/********************************************************************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetUserClaims') IS NULL 
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO

/********************************************************************************************/
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/30/2017 12:19:15 AM ******/
/********************************************************************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetUserLogins') IS NULL 
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO

/*******************************************************************************************/
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/30/2017 12:21:09 AM ******/
/*******************************************************************************************/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetUserRoles') IS NULL 
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO

ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO

/****** Object:  Table [dbo].[Bios]    Script Date: 12/3/2017 9:14:12 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetBios') IS NULL 
CREATE TABLE [dbo].[AspNetBios](
	[Id] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[Biography] [nvarchar](max) NOT NULL,
	[Photo] [image] NULL,
	[PhotoName] [nvarchar](50) NULL,
	[DateCreated] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[AspNetBios] ADD  DEFAULT (getdate()) FOR [DateCreated]
GO

ALTER TABLE [dbo].[AspNetBios]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])--REFERENCES [dbo].[UserData] ([Id])
ON DELETE CASCADE
GO

/****** Object:  Table [dbo].[Projects]    Script Date: 12/3/2017 9:15:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetProjects') IS NULL 
CREATE TABLE [dbo].[AspNetProjects](
	[Id] [nvarchar](128) NOT NULL,
	[Title] [nvarchar](255) NOT NULL,
	[AuthorId] [nvarchar](128) NOT NULL,
	[Topic] [nvarchar](50) NOT NULL,
	[Summary] [nvarchar](500) NULL,
	[FullText] [nvarchar](max) NULL,
	[Published] [bit] NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[AspNetProjects] ADD  DEFAULT ((1)) FOR [Published]
GO

ALTER TABLE [dbo].[AspNetProjects] ADD  DEFAULT (getdate()) FOR [DateCreated]
GO

ALTER TABLE [dbo].[AspNetProjects] ADD  DEFAULT (getdate()) FOR [DateModified]
GO

ALTER TABLE [dbo].[AspNetProjects]  WITH CHECK ADD FOREIGN KEY([AuthorId])
REFERENCES [dbo].[AspNetUsers] ([Id]) --REFERENCES [dbo].[UserData] ([Id])
ON DELETE CASCADE
GO

/****** Object:  Table [dbo].[Feedback]    Script Date: 12/3/2017 9:14:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetFeedback') IS NULL 
CREATE TABLE [dbo].[AspNetFeedback](
	[Id] [nvarchar](128) NOT NULL,
	[Type] [varchar](10) NOT NULL,
	[AuthorId] [nvarchar](128) NULL,
	[UnregisteredName] [nvarchar](50) NULL,
	[Reference] [nvarchar](128) NULL,
	[ProjectId] [nvarchar](128) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[AspNetFeedback] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO

ALTER TABLE [dbo].[AspNetFeedback]  WITH CHECK ADD FOREIGN KEY([AuthorId])
REFERENCES [dbo].[AspNetUsers] ([Id])--REFERENCES [dbo].[UserData] ([Id])
GO

ALTER TABLE [dbo].[AspNetFeedback]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([Id])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[AspNetFeedback]  WITH CHECK ADD CHECK  (([Type]='Question' OR [Type]='Comment'))
GO

/****** Object:  Table [dbo].[Images]    Script Date: 12/3/2017 9:15:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetImages') IS NULL 
CREATE TABLE [dbo].[AspNetImages](
	[Id] [nvarchar](128) NOT NULL,
	[ProjectId] [nvarchar](128) NOT NULL,
	[ImageName] [nvarchar](50) NOT NULL,
	[ImageDescription] [nvarchar](max) NOT NULL,
	[ImageFile] [image] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Images]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([Id])
ON DELETE CASCADE
GO

/****** Object:  Table [dbo].[ProjectUpdates]    Script Date: 12/3/2017 9:16:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetProjectUpdates') IS NULL 
CREATE TABLE [dbo].[AspNetProjectUpdates](
	[Id] [nvarchar](128) NOT NULL,
	[ProjectId] [nvarchar](128) NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Update] [nvarchar](max) NOT NULL,
	[ProjectLink] [nvarchar](50) NULL,
	[DateCreated] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[AspNetProjectUpdates] ADD  DEFAULT (getdate()) FOR [DateCreated]
GO

ALTER TABLE [dbo].[AspNetProjectUpdates]  WITH CHECK ADD FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Projects] ([Id])
ON DELETE CASCADE
GO

/****** Object:  Table [dbo].[TopicsList]    Script Date: 12/3/2017 9:16:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetTopicsList') IS NULL 
CREATE TABLE [dbo].[AspNetTopicsList](
	[Id] [nvarchar](128) NOT NULL,
	[TopicItem] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[UserData]    Script Date: 12/3/2017 9:16:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetUserData') IS NULL 
CREATE TABLE [dbo].[AspNetUserData](
	[Id] [nvarchar](128) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Alias] [nvarchar](50) NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Admin] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AspNetUserData] ADD  DEFAULT ((0)) FOR [Admin]
GO

/****** Object:  Table [dbo].[VersionControl]    Script Date: 12/3/2017 9:16:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF OBJECT_ID (N'AspNetVersionControl') IS NULL 
CREATE TABLE [dbo].[AspNetVersionControl](
	[Id] [nvarchar](128) NOT NULL,
	[Version] [nvarchar](20) NOT NULL,
	[VersionReference] [nvarchar](20) NULL,
	[Notes] [nvarchar](max) NOT NULL,
	[Date] [datetime] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[AspNetVersionControl] ADD  DEFAULT (getdate()) FOR [Date]
GO



