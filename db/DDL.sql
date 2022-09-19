-- create login API with PASSWORD = '!!D3M0CRUD4PP!!'
-- go 

-- CREATE DATABASE DemoCRUDApp
-- GO

use DemoCRUDApp
go 

-- create user API for login API
-- exec sp_addrolemember 'db_datawriter', 'API'
-- exec sp_addrolemember 'db_datareader', 'API'
-- go
-- CREATE TABLE [USER] (
--     [userID] NVARCHAR(32),
--     [firstName] NVARCHAR(50) not NULL,
--     [surName] NVARCHAR(50) not null ,
--     [email] NVARCHAR(100) not null,
--     [PASSWORD] BINARY(64) not null ,
--     [salt] NVARCHAR(16) not null ,
--     [username] NVARCHAR(50) not null,
--     [createdAt] DATETIME not null ,
--     [lastUpdatedAt] DATETIME not null,
--     CONSTRAINT PK_USER PRIMARY KEY([userID]),
--     CONSTRAINT EMAIL_LIKE_REGEX_USER 
--         check([email] like '%__@%.%'),
--     CONSTRAINT UQ_EMAIL_USER
--         UNIQUE([email]),
--     CONSTRAINT UQ_SALT_USER
--         UNIQUE([salt]),
--     CONSTRAINT UQ_USERNAME_USER
--         UNIQUE([username])        
-- )
-- create TABLE [todo] (
--     todoID NVARCHAR(32),
--     userID NVARCHAR(32),
--     todoHeading NVARCHAR(50) not null,
--     todoBody NVARCHAR(MAX) not null,
--     todoStatus NVARCHAR(1) not null,
--     CONSTRAINT PK_TODO
--         PRIMARY KEY([todoID]),
--     CONSTRAINT FK_TODO
--         FOREIGN KEY ([userID]) REFERENCES [user],
--     CONSTRAINT CHECK_TODO_STATUS
--         check(todoStatus in ('F', 'P', 'N'))
-- )

