/*�˽ű������������ݣ���ʹ�ü��±������ļ�����ΪANSI���룻��ʹ��VSCode����ΪGBK���롣ʹ��PgAdmin4�������롣*/
DROP TABLE IF EXISTS "Student" CASCADE;
--ѧ����
CREATE TABLE "Student"
	("No"
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,"Name"
		TEXT
		NOT NULL
	,"Gender"
		CHAR(2)
		NOT NULL
	,"BirthDate"
		DATE
		NOT NULL
	,"Class"
		VARCHAR(50)
		NOT NULL
	,"Speciality"
		VARCHAR(100)
		NULL);
INSERT INTO "Student"
	("No","Name","Gender","BirthDate","Class","Speciality")
	VALUES
	('3120707001','������','��','1991-10-15','12�Ź�','˯��');