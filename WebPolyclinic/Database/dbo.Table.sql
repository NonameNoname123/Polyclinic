﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] TEXT NOT NULL,
	[Surname] TEXT NOT NULL,
	[Patronymic] TEXT NOT NULL,
	[Login] TEXT NOT NULL,
	[Password] TEXT NOT NULL
)
