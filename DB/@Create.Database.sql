﻿CREATE DATABASE [#DATABASE.NAME#]
ON PRIMARY (NAME = N'#DATABASE.NAME#', FILENAME = N'#STORAGE.PATH#\#DATABASE.NAME#.mdf')
LOG ON (NAME = N'#DATABASE.NAME#_log', FILENAME = N'#STORAGE.PATH#\#DATABASE.NAME#_log.ldf');

ALTER DATABASE [#DATABASE.NAME#] SET RECOVERY SIMPLE;
ALTER DATABASE [#DATABASE.NAME#] SET READ_COMMITTED_SNAPSHOT ON;
GO
USE [#DATABASE.NAME#];
EXEC sp_changedbowner 'sa'
GO
