/*�˽ű������������ݣ���ʹ�ü��±������ļ�����ΪANSI���룻��ʹ��VSCode����ΪGBK���롣ʹ��PgAdmin4�������롣*/
DROP TABLE IF EXISTS "Class" CASCADE;
--�༶��
CREATE TABLE "Class"
	("No"
		INT
		NOT NULL
		PRIMARY KEY
	,"Name"
		VARCHAR(20)
		NOT NULL);
INSERT INTO "Class"
	("No","Name")
	VALUES
	(1,'12����')
	,(2,'12�Ź�')
	,(3,'12��ҽ')
	,(4,'12�ٴ�');
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
		BOOLEAN
		NOT NULL
	,"BirthDate"
		DATE
		NOT NULL
	,"Speciality"
		VARCHAR(100)
		NULL
	,"ClassNo"
		INT
		NOT NULL
		REFERENCES "Class"("No"));
INSERT INTO "Student"
	("No","Name","Gender","BirthDate","Speciality","ClassNo")
	VALUES
	('3120707001','������',TRUE,'1991-10-15','˯��',2);