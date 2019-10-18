--�������ݿ⣻
USE master;
IF DB_ID('YourDatabase') IS NOT NULL
	BEGIN
		ALTER DATABASE YourDatabase
			SET SINGLE_USER
			WITH ROLLBACK IMMEDIATE;
		DROP DATABASE YourDatabase;
	END
GO
CREATE DATABASE YourDatabase
	ON
		(NAME='Datafile'
		,FILENAME='C:\DataFile.mdf')
	LOG ON
		(NAME='Logfile'
		,FILENAME='C:\Logfile.ldf');
GO
USE YourDatabase;
--������
CREATE TABLE Table1
	(No
		INT
		NOT NULL
		PRIMARY KEY
	,Name
		VARCHAR(20)
		NOT NULL);
INSERT Table1
	(No,Name)
	VALUES
	(1,'ֵ11')
	,(2,'ֵ12');
--������
CREATE TABLE Table2
	(No
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,Name
		VARCHAR(20)
		NOT NULL
	,Table1No
		INT
		NOT NULL
		FOREIGN KEY REFERENCES Table1(No));
INSERT Table2
	(No,Name,Table1No)
	VALUES
	('1110101001','ֵ21',2);
GO