
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/18/2020 10:53:44
-- Generated from EDMX file: C:\Users\Admin\source\repos\task1\task1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [sd];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'students'
CREATE TABLE [dbo].[students] (
    [sid] int IDENTITY(1,1) NOT NULL,
    [sname] nvarchar(max)  NOT NULL,
    [age] int  NOT NULL,
    [standard] int  NOT NULL,
    [subject] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'schools'
CREATE TABLE [dbo].[schools] (
    [schlid] int IDENTITY(1,1) NOT NULL,
    [schlname] nvarchar(max)  NOT NULL,
    [area] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'examcenters'
CREATE TABLE [dbo].[examcenters] (
    [eid] int IDENTITY(1,1) NOT NULL,
    [ename] nvarchar(max)  NOT NULL,
    [location] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'courses'
CREATE TABLE [dbo].[courses] (
    [cid] int IDENTITY(1,1) NOT NULL,
    [coursename] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'rooms'
CREATE TABLE [dbo].[rooms] (
    [rid] int IDENTITY(1,1) NOT NULL,
    [roomid] int  NOT NULL
);
GO

-- Creating table 'invigilators'
CREATE TABLE [dbo].[invigilators] (
    [invigilatorid] int IDENTITY(1,1) NOT NULL,
    [iname] nvarchar(max)  NOT NULL,
    [workingschool] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'arrangements'
CREATE TABLE [dbo].[arrangements] (
    [day] datetime  NOT NULL,
    [student_sid] int  NOT NULL,
    [school_schlid] int  NOT NULL,
    [examcenter_eid] int  NOT NULL,
    [course_cid] int  NOT NULL,
    [invigilator_invigilatorid] int  NOT NULL,
    [room_rid] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [sid] in table 'students'
ALTER TABLE [dbo].[students]
ADD CONSTRAINT [PK_students]
    PRIMARY KEY CLUSTERED ([sid] ASC);
GO

-- Creating primary key on [schlid] in table 'schools'
ALTER TABLE [dbo].[schools]
ADD CONSTRAINT [PK_schools]
    PRIMARY KEY CLUSTERED ([schlid] ASC);
GO

-- Creating primary key on [eid] in table 'examcenters'
ALTER TABLE [dbo].[examcenters]
ADD CONSTRAINT [PK_examcenters]
    PRIMARY KEY CLUSTERED ([eid] ASC);
GO

-- Creating primary key on [cid] in table 'courses'
ALTER TABLE [dbo].[courses]
ADD CONSTRAINT [PK_courses]
    PRIMARY KEY CLUSTERED ([cid] ASC);
GO

-- Creating primary key on [rid] in table 'rooms'
ALTER TABLE [dbo].[rooms]
ADD CONSTRAINT [PK_rooms]
    PRIMARY KEY CLUSTERED ([rid] ASC);
GO

-- Creating primary key on [invigilatorid] in table 'invigilators'
ALTER TABLE [dbo].[invigilators]
ADD CONSTRAINT [PK_invigilators]
    PRIMARY KEY CLUSTERED ([invigilatorid] ASC);
GO

-- Creating primary key on [day] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [PK_arrangements]
    PRIMARY KEY CLUSTERED ([day] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [student_sid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_studentarrangements]
    FOREIGN KEY ([student_sid])
    REFERENCES [dbo].[students]
        ([sid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_studentarrangements'
CREATE INDEX [IX_FK_studentarrangements]
ON [dbo].[arrangements]
    ([student_sid]);
GO

-- Creating foreign key on [school_schlid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_schoolarrangements]
    FOREIGN KEY ([school_schlid])
    REFERENCES [dbo].[schools]
        ([schlid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_schoolarrangements'
CREATE INDEX [IX_FK_schoolarrangements]
ON [dbo].[arrangements]
    ([school_schlid]);
GO

-- Creating foreign key on [examcenter_eid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_examcenterarrangements]
    FOREIGN KEY ([examcenter_eid])
    REFERENCES [dbo].[examcenters]
        ([eid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_examcenterarrangements'
CREATE INDEX [IX_FK_examcenterarrangements]
ON [dbo].[arrangements]
    ([examcenter_eid]);
GO

-- Creating foreign key on [course_cid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_coursearrangements]
    FOREIGN KEY ([course_cid])
    REFERENCES [dbo].[courses]
        ([cid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_coursearrangements'
CREATE INDEX [IX_FK_coursearrangements]
ON [dbo].[arrangements]
    ([course_cid]);
GO

-- Creating foreign key on [invigilator_invigilatorid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_invigilatorarrangements]
    FOREIGN KEY ([invigilator_invigilatorid])
    REFERENCES [dbo].[invigilators]
        ([invigilatorid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_invigilatorarrangements'
CREATE INDEX [IX_FK_invigilatorarrangements]
ON [dbo].[arrangements]
    ([invigilator_invigilatorid]);
GO

-- Creating foreign key on [room_rid] in table 'arrangements'
ALTER TABLE [dbo].[arrangements]
ADD CONSTRAINT [FK_roomarrangements]
    FOREIGN KEY ([room_rid])
    REFERENCES [dbo].[rooms]
        ([rid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_roomarrangements'
CREATE INDEX [IX_FK_roomarrangements]
ON [dbo].[arrangements]
    ([room_rid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------