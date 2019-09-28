/*
��4.2_��¼_�ؼ�
*/
--�������ݿ⣻
USE master;
IF DB_ID('EduBaseDemo') IS NOT NULL
	BEGIN
		ALTER DATABASE EduBaseDemo
			SET SINGLE_USER
			WITH ROLLBACK IMMEDIATE;
		DROP DATABASE EduBaseDemo;
	END
GO
CREATE DATABASE EduBaseDemo
	ON
		(NAME='Datafile'
		,FILENAME='C:\DataFile.mdf')
	LOG ON
		(NAME='Logfile'
		,FILENAME='C:\Logfile.ldf');
GO
USE EduBaseDemo;
--������
----�༶��
CREATE TABLE Class
	(No
		INT
		NOT NULL
		PRIMARY KEY
	,Name
		VARCHAR(20)
		NOT NULL);
INSERT Class
	(No,Name)
	VALUES
	(1,'12����')
	,(2,'12�Ź�')
	,(3,'12��ҽ')
	,(4,'12�ٴ�');
----ѧ����
CREATE TABLE Student
	(No
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,Name
		VARCHAR(20)
		NOT NULL
	,Gender
		BIT
		NOT NULL
	,BirthDate
		DATE
		NOT NULL
	,ClassNo
		INT
		NOT NULL
		FOREIGN KEY REFERENCES Class(No)
	,Speciality
		VARCHAR(100)
		NULL);
INSERT Student
	(No,Name,Gender,BirthDate,ClassNo,Speciality)
	VALUES
	('3120707001','������',1,'1991-10-15',2,'˯��');
GO