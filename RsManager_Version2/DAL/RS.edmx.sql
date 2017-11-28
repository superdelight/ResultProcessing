
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/17/2017 15:15:45
-- Generated from EDMX file: C:\Users\tolulope.awode\Personal Repo\RsManager_Version2\DAL\RS.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ResultM];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Course_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Course] DROP CONSTRAINT [FK_Course_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_Department_Faculty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Department] DROP CONSTRAINT [FK_Department_Faculty];
GO
IF OBJECT_ID(N'[dbo].[FK_Faculty_School]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Faculty] DROP CONSTRAINT [FK_Faculty_School];
GO
IF OBJECT_ID(N'[dbo].[FK_Programme_Department]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Programme] DROP CONSTRAINT [FK_Programme_Department];
GO
IF OBJECT_ID(N'[dbo].[FK_ProgrammeLevel_Level]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProgrammeLevel] DROP CONSTRAINT [FK_ProgrammeLevel_Level];
GO
IF OBJECT_ID(N'[dbo].[FK_ProgrammeLevel_Programme]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProgrammeLevel] DROP CONSTRAINT [FK_ProgrammeLevel_Programme];
GO
IF OBJECT_ID(N'[dbo].[FK_ProgrammeLevel_ProgrammeStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProgrammeLevel] DROP CONSTRAINT [FK_ProgrammeLevel_ProgrammeStatus];
GO
IF OBJECT_ID(N'[dbo].[FK_Session_SessionStatu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Session] DROP CONSTRAINT [FK_Session_SessionStatu];
GO
IF OBJECT_ID(N'[dbo].[FK_SessionSem_Semester]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SessionSem] DROP CONSTRAINT [FK_SessionSem_Semester];
GO
IF OBJECT_ID(N'[dbo].[FK_SessionSem_Session]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SessionSem] DROP CONSTRAINT [FK_SessionSem_Session];
GO
IF OBJECT_ID(N'[dbo].[FK_SessionSem_SessionStatu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SessionSem] DROP CONSTRAINT [FK_SessionSem_SessionStatu];
GO
IF OBJECT_ID(N'[dbo].[FK_Student_Programme]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_Programme];
GO
IF OBJECT_ID(N'[dbo].[FK_Student_StudentStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_StudentStatus];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentLevel_AvailabityStatu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentLevel] DROP CONSTRAINT [FK_StudentLevel_AvailabityStatu];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentLevel_ProgrammeLevel]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentLevel] DROP CONSTRAINT [FK_StudentLevel_ProgrammeLevel];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentLevel_Session]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentLevel] DROP CONSTRAINT [FK_StudentLevel_Session];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentLevel_StandingVerificationStatus]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentLevel] DROP CONSTRAINT [FK_StudentLevel_StandingVerificationStatus];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentLevel_Student]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentLevel] DROP CONSTRAINT [FK_StudentLevel_Student];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentLevel_StudentLevelPaymentStatu]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentLevel] DROP CONSTRAINT [FK_StudentLevel_StudentLevelPaymentStatu];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AvailabityStatu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AvailabityStatu];
GO
IF OBJECT_ID(N'[dbo].[Course]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Course];
GO
IF OBJECT_ID(N'[dbo].[Department]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Department];
GO
IF OBJECT_ID(N'[dbo].[DisciplinaryStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DisciplinaryStatus];
GO
IF OBJECT_ID(N'[dbo].[Faculty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Faculty];
GO
IF OBJECT_ID(N'[dbo].[Level]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Level];
GO
IF OBJECT_ID(N'[dbo].[Programme]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Programme];
GO
IF OBJECT_ID(N'[dbo].[ProgrammeLevel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProgrammeLevel];
GO
IF OBJECT_ID(N'[dbo].[ProgrammeStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProgrammeStatus];
GO
IF OBJECT_ID(N'[dbo].[School]', 'U') IS NOT NULL
    DROP TABLE [dbo].[School];
GO
IF OBJECT_ID(N'[dbo].[Semester]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Semester];
GO
IF OBJECT_ID(N'[dbo].[Session]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Session];
GO
IF OBJECT_ID(N'[dbo].[SessionSem]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SessionSem];
GO
IF OBJECT_ID(N'[dbo].[SessionStatu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SessionStatu];
GO
IF OBJECT_ID(N'[dbo].[Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Student];
GO
IF OBJECT_ID(N'[dbo].[StudentLevel]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentLevel];
GO
IF OBJECT_ID(N'[dbo].[StudentLevelPaymentStatu]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentLevelPaymentStatu];
GO
IF OBJECT_ID(N'[dbo].[StudentStatus]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentStatus];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CourseCode] nvarchar(max)  NULL,
    [CourseTitle] nvarchar(max)  NULL,
    [DeptId] int  NULL,
    [DateCreated] datetime  NULL
);
GO

-- Creating table 'Departments'
CREATE TABLE [dbo].[Departments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DeptCode] nvarchar(max)  NULL,
    [DeptFullName] nvarchar(max)  NULL,
    [FacId] int  NULL,
    [IsVisible] bit  NULL,
    [DateCreated] datetime  NULL
);
GO

-- Creating table 'Faculties'
CREATE TABLE [dbo].[Faculties] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FacAcronyms] nvarchar(max)  NULL,
    [SchoolId] int  NULL,
    [IsVisible] bit  NULL,
    [FacName] nvarchar(max)  NULL
);
GO

-- Creating table 'Levels'
CREATE TABLE [dbo].[Levels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Programmes'
CREATE TABLE [dbo].[Programmes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProgrammeDescription] nvarchar(max)  NULL,
    [ProgrammeCode] nvarchar(max)  NULL,
    [deptId] int  NULL,
    [DateCreated] datetime  NULL,
    [ExpectedGraduationYear] int  NULL
);
GO

-- Creating table 'ProgrammeLevels'
CREATE TABLE [dbo].[ProgrammeLevels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProgrammeDescription] nvarchar(max)  NULL,
    [ProgId] int  NULL,
    [Status] int  NULL,
    [DateCreated] datetime  NULL,
    [AwardLevelId] int  NOT NULL
);
GO

-- Creating table 'ProgrammeStatus'
CREATE TABLE [dbo].[ProgrammeStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SchoolName] nvarchar(max)  NULL,
    [Logo] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [IsVisible] bit  NULL,
    [DateCreated] datetime  NULL,
    [PhoneNo] nvarchar(max)  NOT NULL,
    [EmailAddress] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Semesters'
CREATE TABLE [dbo].[Semesters] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Sessions'
CREATE TABLE [dbo].[Sessions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL,
    [DateCreated] datetime  NULL,
    [IsActive] bit  NULL,
    [CommencementDate] datetime  NULL,
    [NormalClosureDate] datetime  NULL,
    [DateOpened] datetime  NULL,
    [OpenedBy] nvarchar(max)  NULL,
    [ClosedTime] datetime  NULL,
    [ClosedBy] nvarchar(max)  NULL,
    [Status] int  NULL
);
GO

-- Creating table 'SessionSems'
CREATE TABLE [dbo].[SessionSems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL,
    [DateCreated] datetime  NULL,
    [IsActive] bit  NULL,
    [CommencementDate] datetime  NULL,
    [NormalClosureDate] datetime  NULL,
    [DateOpened] datetime  NULL,
    [OpenedBy] nvarchar(max)  NULL,
    [ClosedTime] datetime  NULL,
    [ClosedBy] nvarchar(max)  NULL,
    [Status] int  NULL,
    [SemId] int  NULL,
    [SessId] int  NULL
);
GO

-- Creating table 'SessionStatus'
CREATE TABLE [dbo].[SessionStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MatricNo] nvarchar(max)  NULL,
    [Surname] nvarchar(max)  NULL,
    [Othername] nvarchar(max)  NULL,
    [Gender] nvarchar(max)  NULL,
    [Address] nvarchar(max)  NULL,
    [StateofOrigin] nvarchar(max)  NULL,
    [PhoneNumber] nvarchar(max)  NULL,
    [YearofAdmission] int  NULL,
    [ModeofAdmission] nvarchar(max)  NULL,
    [NameofNextofKin] nvarchar(max)  NULL,
    [PhoneNoNextofKin] nvarchar(max)  NULL,
    [Relationship] nvarchar(max)  NULL,
    [ProgrammeId] int  NULL,
    [Status] int  NULL,
    [DateCreated] datetime  NULL,
    [CentreId] int  NOT NULL,
    [LGAId] int  NOT NULL,
    [Picture] nvarchar(max)  NOT NULL,
    [Signature] nvarchar(max)  NOT NULL,
    [DOB] datetime  NOT NULL,
    [PlaceofBirth] nvarchar(max)  NOT NULL,
    [Genotype] nvarchar(max)  NOT NULL,
    [BloodGroup] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'StudentStatus'
CREATE TABLE [dbo].[StudentStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'AvailabityStatus'
CREATE TABLE [dbo].[AvailabityStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Status] nvarchar(max)  NULL
);
GO

-- Creating table 'DisciplinaryStatus'
CREATE TABLE [dbo].[DisciplinaryStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'StudentLevelPaymentStatus'
CREATE TABLE [dbo].[StudentLevelPaymentStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StatusDescription] nvarchar(max)  NULL
);
GO

-- Creating table 'StudentLevels'
CREATE TABLE [dbo].[StudentLevels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StudentId] int  NULL,
    [ProgLevId] int  NULL,
    [DisciplineStatus] int  NULL,
    [SessionId] int  NULL,
    [DateCreated] datetime  NULL,
    [PayStatus] int  NULL,
    [AvailStatus] int  NULL
);
GO

-- Creating table 'Centres'
CREATE TABLE [dbo].[Centres] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CentreCode] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [CentrePicture] nvarchar(max)  NOT NULL,
    [PhoneNo] nvarchar(max)  NOT NULL,
    [EmailAddress] nvarchar(max)  NOT NULL,
    [CityId] int  NOT NULL,
    [SchoolId] int  NOT NULL
);
GO

-- Creating table 'States'
CREATE TABLE [dbo].[States] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [StateCode] nvarchar(max)  NOT NULL,
    [GeoZoneId] int  NOT NULL
);
GO

-- Creating table 'GeoZones'
CREATE TABLE [dbo].[GeoZones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'LGAs'
CREATE TABLE [dbo].[LGAs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [StateId] int  NOT NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CityName] nvarchar(max)  NOT NULL,
    [StateId] int  NOT NULL
);
GO

-- Creating table 'Requirements'
CREATE TABLE [dbo].[Requirements] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [MinimumUnit] int  NOT NULL,
    [MaximumUnit] int  NOT NULL,
    [IsElective] bit  NOT NULL,
    [AwardLevelId] int  NOT NULL,
    [SemesterId] int  NOT NULL
);
GO

-- Creating table 'RequiredCourses'
CREATE TABLE [dbo].[RequiredCourses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CourseCode] nvarchar(max)  NOT NULL,
    [CourseTitle] nvarchar(max)  NOT NULL,
    [Unit] nvarchar(max)  NOT NULL,
    [RequirementId] int  NOT NULL,
    [CourseId] int  NOT NULL
);
GO

-- Creating table 'Awards'
CREATE TABLE [dbo].[Awards] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AwardName] nvarchar(max)  NOT NULL,
    [AwardAcronyms] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AwardLevels'
CREATE TABLE [dbo].[AwardLevels] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [AwardId] int  NOT NULL,
    [LevelId] int  NOT NULL
);
GO

-- Creating table 'Curricula'
CREATE TABLE [dbo].[Curricula] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [IsActive] bit  NOT NULL,
    [RequirementId] int  NOT NULL,
    [ProgrammeLevelId] int  NOT NULL
);
GO

-- Creating table 'Registrations'
CREATE TABLE [dbo].[Registrations] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [RequiredCourseId] int  NOT NULL,
    [StudentLevelId] int  NOT NULL,
    [SessionSemId] int  NOT NULL,
    [RegistrationStatusId] int  NOT NULL
);
GO

-- Creating table 'RegistrationStatus'
CREATE TABLE [dbo].[RegistrationStatus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Results'
CREATE TABLE [dbo].[Results] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TestScore] float  NOT NULL,
    [GradeId] int  NOT NULL,
    [ExamScore] float  NOT NULL,
    [TotalScore] float  NOT NULL,
    [Registration_Id] int  NOT NULL
);
GO

-- Creating table 'Grades'
CREATE TABLE [dbo].[Grades] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GradeChar] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ScoreRange] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Requirements_ProgrammeReq'
CREATE TABLE [dbo].[Requirements_ProgrammeReq] (
    [ProgrammeId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Requirements_FacultyReq'
CREATE TABLE [dbo].[Requirements_FacultyReq] (
    [FacultyId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Requirements_GeneralReq'
CREATE TABLE [dbo].[Requirements_GeneralReq] (
    [GenReq] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [PK_Departments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [PK_Faculties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Levels'
ALTER TABLE [dbo].[Levels]
ADD CONSTRAINT [PK_Levels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Programmes'
ALTER TABLE [dbo].[Programmes]
ADD CONSTRAINT [PK_Programmes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProgrammeLevels'
ALTER TABLE [dbo].[ProgrammeLevels]
ADD CONSTRAINT [PK_ProgrammeLevels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProgrammeStatus'
ALTER TABLE [dbo].[ProgrammeStatus]
ADD CONSTRAINT [PK_ProgrammeStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Semesters'
ALTER TABLE [dbo].[Semesters]
ADD CONSTRAINT [PK_Semesters]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sessions'
ALTER TABLE [dbo].[Sessions]
ADD CONSTRAINT [PK_Sessions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SessionSems'
ALTER TABLE [dbo].[SessionSems]
ADD CONSTRAINT [PK_SessionSems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SessionStatus'
ALTER TABLE [dbo].[SessionStatus]
ADD CONSTRAINT [PK_SessionStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudentStatus'
ALTER TABLE [dbo].[StudentStatus]
ADD CONSTRAINT [PK_StudentStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AvailabityStatus'
ALTER TABLE [dbo].[AvailabityStatus]
ADD CONSTRAINT [PK_AvailabityStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DisciplinaryStatus'
ALTER TABLE [dbo].[DisciplinaryStatus]
ADD CONSTRAINT [PK_DisciplinaryStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudentLevelPaymentStatus'
ALTER TABLE [dbo].[StudentLevelPaymentStatus]
ADD CONSTRAINT [PK_StudentLevelPaymentStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudentLevels'
ALTER TABLE [dbo].[StudentLevels]
ADD CONSTRAINT [PK_StudentLevels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Centres'
ALTER TABLE [dbo].[Centres]
ADD CONSTRAINT [PK_Centres]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'States'
ALTER TABLE [dbo].[States]
ADD CONSTRAINT [PK_States]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GeoZones'
ALTER TABLE [dbo].[GeoZones]
ADD CONSTRAINT [PK_GeoZones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LGAs'
ALTER TABLE [dbo].[LGAs]
ADD CONSTRAINT [PK_LGAs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Requirements'
ALTER TABLE [dbo].[Requirements]
ADD CONSTRAINT [PK_Requirements]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RequiredCourses'
ALTER TABLE [dbo].[RequiredCourses]
ADD CONSTRAINT [PK_RequiredCourses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Awards'
ALTER TABLE [dbo].[Awards]
ADD CONSTRAINT [PK_Awards]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AwardLevels'
ALTER TABLE [dbo].[AwardLevels]
ADD CONSTRAINT [PK_AwardLevels]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Curricula'
ALTER TABLE [dbo].[Curricula]
ADD CONSTRAINT [PK_Curricula]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [PK_Registrations]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RegistrationStatus'
ALTER TABLE [dbo].[RegistrationStatus]
ADD CONSTRAINT [PK_RegistrationStatus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [PK_Results]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Grades'
ALTER TABLE [dbo].[Grades]
ADD CONSTRAINT [PK_Grades]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Requirements_ProgrammeReq'
ALTER TABLE [dbo].[Requirements_ProgrammeReq]
ADD CONSTRAINT [PK_Requirements_ProgrammeReq]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Requirements_FacultyReq'
ALTER TABLE [dbo].[Requirements_FacultyReq]
ADD CONSTRAINT [PK_Requirements_FacultyReq]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Requirements_GeneralReq'
ALTER TABLE [dbo].[Requirements_GeneralReq]
ADD CONSTRAINT [PK_Requirements_GeneralReq]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [DeptId] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [FK_Course_Department]
    FOREIGN KEY ([DeptId])
    REFERENCES [dbo].[Departments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Course_Department'
CREATE INDEX [IX_FK_Course_Department]
ON [dbo].[Courses]
    ([DeptId]);
GO

-- Creating foreign key on [FacId] in table 'Departments'
ALTER TABLE [dbo].[Departments]
ADD CONSTRAINT [FK_Department_Faculty]
    FOREIGN KEY ([FacId])
    REFERENCES [dbo].[Faculties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Department_Faculty'
CREATE INDEX [IX_FK_Department_Faculty]
ON [dbo].[Departments]
    ([FacId]);
GO

-- Creating foreign key on [deptId] in table 'Programmes'
ALTER TABLE [dbo].[Programmes]
ADD CONSTRAINT [FK_Programme_Department]
    FOREIGN KEY ([deptId])
    REFERENCES [dbo].[Departments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Programme_Department'
CREATE INDEX [IX_FK_Programme_Department]
ON [dbo].[Programmes]
    ([deptId]);
GO

-- Creating foreign key on [SchoolId] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [FK_Faculty_School]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[Schools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Faculty_School'
CREATE INDEX [IX_FK_Faculty_School]
ON [dbo].[Faculties]
    ([SchoolId]);
GO

-- Creating foreign key on [ProgId] in table 'ProgrammeLevels'
ALTER TABLE [dbo].[ProgrammeLevels]
ADD CONSTRAINT [FK_ProgrammeLevel_Programme]
    FOREIGN KEY ([ProgId])
    REFERENCES [dbo].[Programmes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProgrammeLevel_Programme'
CREATE INDEX [IX_FK_ProgrammeLevel_Programme]
ON [dbo].[ProgrammeLevels]
    ([ProgId]);
GO

-- Creating foreign key on [ProgrammeId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_Student_Programme]
    FOREIGN KEY ([ProgrammeId])
    REFERENCES [dbo].[Programmes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Student_Programme'
CREATE INDEX [IX_FK_Student_Programme]
ON [dbo].[Students]
    ([ProgrammeId]);
GO

-- Creating foreign key on [Status] in table 'ProgrammeLevels'
ALTER TABLE [dbo].[ProgrammeLevels]
ADD CONSTRAINT [FK_ProgrammeLevel_ProgrammeStatus]
    FOREIGN KEY ([Status])
    REFERENCES [dbo].[ProgrammeStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProgrammeLevel_ProgrammeStatus'
CREATE INDEX [IX_FK_ProgrammeLevel_ProgrammeStatus]
ON [dbo].[ProgrammeLevels]
    ([Status]);
GO

-- Creating foreign key on [SemId] in table 'SessionSems'
ALTER TABLE [dbo].[SessionSems]
ADD CONSTRAINT [FK_SessionSem_Semester]
    FOREIGN KEY ([SemId])
    REFERENCES [dbo].[Semesters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessionSem_Semester'
CREATE INDEX [IX_FK_SessionSem_Semester]
ON [dbo].[SessionSems]
    ([SemId]);
GO

-- Creating foreign key on [Status] in table 'Sessions'
ALTER TABLE [dbo].[Sessions]
ADD CONSTRAINT [FK_Session_SessionStatu]
    FOREIGN KEY ([Status])
    REFERENCES [dbo].[SessionStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Session_SessionStatu'
CREATE INDEX [IX_FK_Session_SessionStatu]
ON [dbo].[Sessions]
    ([Status]);
GO

-- Creating foreign key on [SessId] in table 'SessionSems'
ALTER TABLE [dbo].[SessionSems]
ADD CONSTRAINT [FK_SessionSem_Session]
    FOREIGN KEY ([SessId])
    REFERENCES [dbo].[Sessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessionSem_Session'
CREATE INDEX [IX_FK_SessionSem_Session]
ON [dbo].[SessionSems]
    ([SessId]);
GO

-- Creating foreign key on [Status] in table 'SessionSems'
ALTER TABLE [dbo].[SessionSems]
ADD CONSTRAINT [FK_SessionSem_SessionStatu]
    FOREIGN KEY ([Status])
    REFERENCES [dbo].[SessionStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessionSem_SessionStatu'
CREATE INDEX [IX_FK_SessionSem_SessionStatu]
ON [dbo].[SessionSems]
    ([Status]);
GO

-- Creating foreign key on [Status] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_Student_StudentStatus]
    FOREIGN KEY ([Status])
    REFERENCES [dbo].[StudentStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Student_StudentStatus'
CREATE INDEX [IX_FK_Student_StudentStatus]
ON [dbo].[Students]
    ([Status]);
GO

-- Creating foreign key on [AvailStatus] in table 'StudentLevels'
ALTER TABLE [dbo].[StudentLevels]
ADD CONSTRAINT [FK_StudentLevel_AvailabityStatu]
    FOREIGN KEY ([AvailStatus])
    REFERENCES [dbo].[AvailabityStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentLevel_AvailabityStatu'
CREATE INDEX [IX_FK_StudentLevel_AvailabityStatu]
ON [dbo].[StudentLevels]
    ([AvailStatus]);
GO

-- Creating foreign key on [DisciplineStatus] in table 'StudentLevels'
ALTER TABLE [dbo].[StudentLevels]
ADD CONSTRAINT [FK_StudentLevel_StandingVerificationStatus]
    FOREIGN KEY ([DisciplineStatus])
    REFERENCES [dbo].[DisciplinaryStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentLevel_StandingVerificationStatus'
CREATE INDEX [IX_FK_StudentLevel_StandingVerificationStatus]
ON [dbo].[StudentLevels]
    ([DisciplineStatus]);
GO

-- Creating foreign key on [ProgLevId] in table 'StudentLevels'
ALTER TABLE [dbo].[StudentLevels]
ADD CONSTRAINT [FK_StudentLevel_ProgrammeLevel]
    FOREIGN KEY ([ProgLevId])
    REFERENCES [dbo].[ProgrammeLevels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentLevel_ProgrammeLevel'
CREATE INDEX [IX_FK_StudentLevel_ProgrammeLevel]
ON [dbo].[StudentLevels]
    ([ProgLevId]);
GO

-- Creating foreign key on [SessionId] in table 'StudentLevels'
ALTER TABLE [dbo].[StudentLevels]
ADD CONSTRAINT [FK_StudentLevel_Session]
    FOREIGN KEY ([SessionId])
    REFERENCES [dbo].[Sessions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentLevel_Session'
CREATE INDEX [IX_FK_StudentLevel_Session]
ON [dbo].[StudentLevels]
    ([SessionId]);
GO

-- Creating foreign key on [StudentId] in table 'StudentLevels'
ALTER TABLE [dbo].[StudentLevels]
ADD CONSTRAINT [FK_StudentLevel_Student]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[Students]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentLevel_Student'
CREATE INDEX [IX_FK_StudentLevel_Student]
ON [dbo].[StudentLevels]
    ([StudentId]);
GO

-- Creating foreign key on [PayStatus] in table 'StudentLevels'
ALTER TABLE [dbo].[StudentLevels]
ADD CONSTRAINT [FK_StudentLevel_StudentLevelPaymentStatu]
    FOREIGN KEY ([PayStatus])
    REFERENCES [dbo].[StudentLevelPaymentStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentLevel_StudentLevelPaymentStatu'
CREATE INDEX [IX_FK_StudentLevel_StudentLevelPaymentStatu]
ON [dbo].[StudentLevels]
    ([PayStatus]);
GO

-- Creating foreign key on [GeoZoneId] in table 'States'
ALTER TABLE [dbo].[States]
ADD CONSTRAINT [FK_GeoZoneState]
    FOREIGN KEY ([GeoZoneId])
    REFERENCES [dbo].[GeoZones]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GeoZoneState'
CREATE INDEX [IX_FK_GeoZoneState]
ON [dbo].[States]
    ([GeoZoneId]);
GO

-- Creating foreign key on [StateId] in table 'LGAs'
ALTER TABLE [dbo].[LGAs]
ADD CONSTRAINT [FK_StateLGA]
    FOREIGN KEY ([StateId])
    REFERENCES [dbo].[States]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StateLGA'
CREATE INDEX [IX_FK_StateLGA]
ON [dbo].[LGAs]
    ([StateId]);
GO

-- Creating foreign key on [StateId] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [FK_StateCity]
    FOREIGN KEY ([StateId])
    REFERENCES [dbo].[States]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StateCity'
CREATE INDEX [IX_FK_StateCity]
ON [dbo].[Cities]
    ([StateId]);
GO

-- Creating foreign key on [CityId] in table 'Centres'
ALTER TABLE [dbo].[Centres]
ADD CONSTRAINT [FK_CityCentre]
    FOREIGN KEY ([CityId])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CityCentre'
CREATE INDEX [IX_FK_CityCentre]
ON [dbo].[Centres]
    ([CityId]);
GO

-- Creating foreign key on [CentreId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_CentreStudent]
    FOREIGN KEY ([CentreId])
    REFERENCES [dbo].[Centres]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CentreStudent'
CREATE INDEX [IX_FK_CentreStudent]
ON [dbo].[Students]
    ([CentreId]);
GO

-- Creating foreign key on [LGAId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_LGAStudent]
    FOREIGN KEY ([LGAId])
    REFERENCES [dbo].[LGAs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LGAStudent'
CREATE INDEX [IX_FK_LGAStudent]
ON [dbo].[Students]
    ([LGAId]);
GO

-- Creating foreign key on [SchoolId] in table 'Centres'
ALTER TABLE [dbo].[Centres]
ADD CONSTRAINT [FK_SchoolCentre]
    FOREIGN KEY ([SchoolId])
    REFERENCES [dbo].[Schools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolCentre'
CREATE INDEX [IX_FK_SchoolCentre]
ON [dbo].[Centres]
    ([SchoolId]);
GO

-- Creating foreign key on [ProgrammeId] in table 'Requirements_ProgrammeReq'
ALTER TABLE [dbo].[Requirements_ProgrammeReq]
ADD CONSTRAINT [FK_ProgrammeProgrammeReq]
    FOREIGN KEY ([ProgrammeId])
    REFERENCES [dbo].[Programmes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProgrammeProgrammeReq'
CREATE INDEX [IX_FK_ProgrammeProgrammeReq]
ON [dbo].[Requirements_ProgrammeReq]
    ([ProgrammeId]);
GO

-- Creating foreign key on [FacultyId] in table 'Requirements_FacultyReq'
ALTER TABLE [dbo].[Requirements_FacultyReq]
ADD CONSTRAINT [FK_FacultyFacultyReq]
    FOREIGN KEY ([FacultyId])
    REFERENCES [dbo].[Faculties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyFacultyReq'
CREATE INDEX [IX_FK_FacultyFacultyReq]
ON [dbo].[Requirements_FacultyReq]
    ([FacultyId]);
GO

-- Creating foreign key on [AwardId] in table 'AwardLevels'
ALTER TABLE [dbo].[AwardLevels]
ADD CONSTRAINT [FK_AwardAwardLevel]
    FOREIGN KEY ([AwardId])
    REFERENCES [dbo].[Awards]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AwardAwardLevel'
CREATE INDEX [IX_FK_AwardAwardLevel]
ON [dbo].[AwardLevels]
    ([AwardId]);
GO

-- Creating foreign key on [LevelId] in table 'AwardLevels'
ALTER TABLE [dbo].[AwardLevels]
ADD CONSTRAINT [FK_LevelAwardLevel]
    FOREIGN KEY ([LevelId])
    REFERENCES [dbo].[Levels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LevelAwardLevel'
CREATE INDEX [IX_FK_LevelAwardLevel]
ON [dbo].[AwardLevels]
    ([LevelId]);
GO

-- Creating foreign key on [AwardLevelId] in table 'ProgrammeLevels'
ALTER TABLE [dbo].[ProgrammeLevels]
ADD CONSTRAINT [FK_AwardLevelProgrammeLevel]
    FOREIGN KEY ([AwardLevelId])
    REFERENCES [dbo].[AwardLevels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AwardLevelProgrammeLevel'
CREATE INDEX [IX_FK_AwardLevelProgrammeLevel]
ON [dbo].[ProgrammeLevels]
    ([AwardLevelId]);
GO

-- Creating foreign key on [AwardLevelId] in table 'Requirements'
ALTER TABLE [dbo].[Requirements]
ADD CONSTRAINT [FK_AwardLevelRequirement]
    FOREIGN KEY ([AwardLevelId])
    REFERENCES [dbo].[AwardLevels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AwardLevelRequirement'
CREATE INDEX [IX_FK_AwardLevelRequirement]
ON [dbo].[Requirements]
    ([AwardLevelId]);
GO

-- Creating foreign key on [RequirementId] in table 'RequiredCourses'
ALTER TABLE [dbo].[RequiredCourses]
ADD CONSTRAINT [FK_RequirementRequiredCourse]
    FOREIGN KEY ([RequirementId])
    REFERENCES [dbo].[Requirements]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequirementRequiredCourse'
CREATE INDEX [IX_FK_RequirementRequiredCourse]
ON [dbo].[RequiredCourses]
    ([RequirementId]);
GO

-- Creating foreign key on [SemesterId] in table 'Requirements'
ALTER TABLE [dbo].[Requirements]
ADD CONSTRAINT [FK_SemesterRequirement]
    FOREIGN KEY ([SemesterId])
    REFERENCES [dbo].[Semesters]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SemesterRequirement'
CREATE INDEX [IX_FK_SemesterRequirement]
ON [dbo].[Requirements]
    ([SemesterId]);
GO

-- Creating foreign key on [RequirementId] in table 'Curricula'
ALTER TABLE [dbo].[Curricula]
ADD CONSTRAINT [FK_RequirementCurriculum]
    FOREIGN KEY ([RequirementId])
    REFERENCES [dbo].[Requirements]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequirementCurriculum'
CREATE INDEX [IX_FK_RequirementCurriculum]
ON [dbo].[Curricula]
    ([RequirementId]);
GO

-- Creating foreign key on [ProgrammeLevelId] in table 'Curricula'
ALTER TABLE [dbo].[Curricula]
ADD CONSTRAINT [FK_ProgrammeLevelCurriculum]
    FOREIGN KEY ([ProgrammeLevelId])
    REFERENCES [dbo].[ProgrammeLevels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProgrammeLevelCurriculum'
CREATE INDEX [IX_FK_ProgrammeLevelCurriculum]
ON [dbo].[Curricula]
    ([ProgrammeLevelId]);
GO

-- Creating foreign key on [RequiredCourseId] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [FK_RequiredCourseRegistration]
    FOREIGN KEY ([RequiredCourseId])
    REFERENCES [dbo].[RequiredCourses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequiredCourseRegistration'
CREATE INDEX [IX_FK_RequiredCourseRegistration]
ON [dbo].[Registrations]
    ([RequiredCourseId]);
GO

-- Creating foreign key on [StudentLevelId] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [FK_StudentLevelRegistration]
    FOREIGN KEY ([StudentLevelId])
    REFERENCES [dbo].[StudentLevels]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentLevelRegistration'
CREATE INDEX [IX_FK_StudentLevelRegistration]
ON [dbo].[Registrations]
    ([StudentLevelId]);
GO

-- Creating foreign key on [SessionSemId] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [FK_SessionSemRegistration]
    FOREIGN KEY ([SessionSemId])
    REFERENCES [dbo].[SessionSems]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessionSemRegistration'
CREATE INDEX [IX_FK_SessionSemRegistration]
ON [dbo].[Registrations]
    ([SessionSemId]);
GO

-- Creating foreign key on [RegistrationStatusId] in table 'Registrations'
ALTER TABLE [dbo].[Registrations]
ADD CONSTRAINT [FK_RegistrationStatusRegistration]
    FOREIGN KEY ([RegistrationStatusId])
    REFERENCES [dbo].[RegistrationStatus]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RegistrationStatusRegistration'
CREATE INDEX [IX_FK_RegistrationStatusRegistration]
ON [dbo].[Registrations]
    ([RegistrationStatusId]);
GO

-- Creating foreign key on [Registration_Id] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_RegistrationResult]
    FOREIGN KEY ([Registration_Id])
    REFERENCES [dbo].[Registrations]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RegistrationResult'
CREATE INDEX [IX_FK_RegistrationResult]
ON [dbo].[Results]
    ([Registration_Id]);
GO

-- Creating foreign key on [GradeId] in table 'Results'
ALTER TABLE [dbo].[Results]
ADD CONSTRAINT [FK_GradeResult]
    FOREIGN KEY ([GradeId])
    REFERENCES [dbo].[Grades]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_GradeResult'
CREATE INDEX [IX_FK_GradeResult]
ON [dbo].[Results]
    ([GradeId]);
GO

-- Creating foreign key on [CourseId] in table 'RequiredCourses'
ALTER TABLE [dbo].[RequiredCourses]
ADD CONSTRAINT [FK_CourseRequiredCourse]
    FOREIGN KEY ([CourseId])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CourseRequiredCourse'
CREATE INDEX [IX_FK_CourseRequiredCourse]
ON [dbo].[RequiredCourses]
    ([CourseId]);
GO

-- Creating foreign key on [Id] in table 'Requirements_ProgrammeReq'
ALTER TABLE [dbo].[Requirements_ProgrammeReq]
ADD CONSTRAINT [FK_ProgrammeReq_inherits_Requirement]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Requirements]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Requirements_FacultyReq'
ALTER TABLE [dbo].[Requirements_FacultyReq]
ADD CONSTRAINT [FK_FacultyReq_inherits_Requirement]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Requirements]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Requirements_GeneralReq'
ALTER TABLE [dbo].[Requirements_GeneralReq]
ADD CONSTRAINT [FK_GeneralReq_inherits_Requirement]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Requirements]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------