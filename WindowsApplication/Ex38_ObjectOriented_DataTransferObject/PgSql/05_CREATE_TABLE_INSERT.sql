/*�˽ű������������ݣ���ʹ�ü��±������ļ�����ΪANSI����*/
DROP TABLE IF EXISTS "Role" CASCADE;
--��ɫ��
CREATE TABLE "Role"
	("No"
		SERIAL
		NOT NULL
		PRIMARY KEY
	,"Name"
		VARCHAR(10)
		NOT NULL
		UNIQUE);
INSERT INTO "Role"
	("Name")
	VALUES
	('ѧ��')
	,('��ʦ');
DROP TABLE IF EXISTS "User" CASCADE;
--�û���
CREATE TABLE "User"
	("No"
		CHAR(10)
		NOT NULL
		PRIMARY KEY
	,"Password"
		BYTEA
		NOT NULL
	,"IsActivated"
		BOOLEAN
	 	NOT NULL
	,"LoginFailCount"
		INTEGER
		NOT NULL
		DEFAULT 0
	,"RoleNo"
		INT
		NOT NULL
		REFERENCES "Role"("No"));
INSERT INTO "User"
	("No","Password","IsActivated","RoleNo")
	VALUES
	('3180707001',DECODE(MD5('7001'),'HEX'),TRUE,1);