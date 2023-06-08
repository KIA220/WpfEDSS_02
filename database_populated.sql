BEGIN TRANSACTION;
CREATE TABLE "warranty" (
	`id_warranty`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`id_text`	TEXT NOT NULL,
	`date`	TEXT NOT NULL
);
CREATE TABLE "type_report" (
	`id_report`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`template`	INTEGER NOT NULL
);
CREATE TABLE "report" (
	`id_report`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`id_type_report`	INTEGER NOT NULL,
	`id_warranty`	INTEGER NOT NULL
);
CREATE TABLE "processes" (
	`id_process`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`id_comment`	TEXT NOT NULL,
	`id_qr_code`	INTEGER NOT NULL,
	`id_user`	TEXT NOT NULL,
	`id_report`	INTEGER NOT NULL,
	`id_client`	TEXT NOT NULL
);
INSERT INTO `processes` VALUES (1,'Комментарий',0,'Пользователь1',0,'Лучший клиент1');
INSERT INTO `processes` VALUES (2,'Комментарий2',1,'Пользователь2',1,'Лучший клиент2');
INSERT INTO `processes` VALUES (3,'Комментарий3',0,'Пользователь1',0,'Лучший клиент3');
INSERT INTO `processes` VALUES (4,'Комментарий4',0,'Пользователь1',0,'Лучший клиент4');
INSERT INTO `processes` VALUES (5,'Комментарий5',0,'Пользователь2',0,'Лучший клиент6');
INSERT INTO `processes` VALUES (6,'Комментарий6',0,'Пользователь2',0,'Лучший клиент5');
INSERT INTO `processes` VALUES (7,'Комментарий7',0,'Пользователь1',0,'Лучший клиент100');
INSERT INTO `processes` VALUES (8,'Комментарий8',0,'Пользователь2',0,'Лучший клиент22');
INSERT INTO `processes` VALUES (9,'Комментарий9',0,'Пользователь1',0,'Лучший клиент212');
INSERT INTO `processes` VALUES (10,'Комментарий10',0,'Пользователь2',0,'Лучший клиент211');
INSERT INTO `processes` VALUES (11,'Комментарий11',0,'Пользователь1',0,'Лучший клиент2000');
CREATE TABLE "jobtitiles" (
	`id_jobtitle`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`id_role`	INTEGER NOT NULL
);
CREATE TABLE "comment" (
	`id_comment`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`text_comment`	TEXT NOT NULL
);
CREATE TABLE "Users" (
	`id_user`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`id_jobtitle`	TEXT NOT NULL,
	`fio_user`	TEXT NOT NULL,
	`tel_user`	TEXT NOT NULL
);
INSERT INTO `Users` VALUES (1,'admin','admin','7 964 981-74-31');
INSERT INTO `Users` VALUES (2,'user','user','7 998 839-84-14');
INSERT INTO `Users` VALUES (3,'Пользователь1','Пользователь1','7 915 420-20-79');
INSERT INTO `Users` VALUES (4,'Пользователь2','Пользователь2','7 982 286-13-85');
CREATE TABLE "Roles" (
	`id_role`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`Possibilities`	INTEGER NOT NULL
);
CREATE TABLE "QR_codes" (
	`id_qr_code`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`Text_qr_code`	TEXT NOT NULL,
	`img_link_qr_code`	TEXT NOT NULL
);
CREATE TABLE "Clients" (
	`id_client`	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
	`fio_client`	TEXT NOT NULL,
	`tel_client`	TEXT NOT NULL
);
INSERT INTO `Clients` VALUES (1,'Лучший клиент','7 951 558-25-13');
INSERT INTO `Clients` VALUES (2,'Лучший клиент2','7 968 047-94-70');
INSERT INTO `Clients` VALUES (3,'Лучший клиент200','7 988 648-83-55');
INSERT INTO `Clients` VALUES (4,'Лучший клиент2000','7 985 377-71-02');
INSERT INTO `Clients` VALUES (5,'Лучший клиент212','7 924 505-44-25');
INSERT INTO `Clients` VALUES (6,'Лучший клиент22','7 982 294-53-36');
INSERT INTO `Clients` VALUES (7,'Лучший клиент3','7 977 208-77-26');
COMMIT;
