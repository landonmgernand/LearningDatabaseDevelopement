/*�˽ű������������ݣ���ʹ�ü��±������ļ�����ΪANSI���룻��ʹ��VSCode����ΪGBK���롣ʹ��PgAdmin4�������롣*/
DROP TABLE IF EXISTS "Table1" CASCADE;
--������
CREATE TABLE "Table1"
	("No"
		INT
		NOT NULL
		PRIMARY KEY
	,"Name"
		VARCHAR(20)
		NOT NULL);
INSERT INTO "Table1"
	("No","Name")
	VALUES
	(1,'ֵ11')
	,(2,'ֵ12');
DROP TABLE IF EXISTS "Table2" CASCADE;
--������
CREATE TABLE "Table2"
	("No"
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,"Name"
		VARCHAR(20)
		NOT NULL

	,"Table1No"
		INT
		NOT NULL
		REFERENCES "Table1"("No"));
INSERT INTO "Table2"
	("No","Name","Table1No")
	VALUES
	('1110101001','ֵ21',2);