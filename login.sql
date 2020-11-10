/*
SQLyog Community v13.1.6 (64 bit)
MySQL - 8.0.20 : Database - login
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`login` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `login`;

/*Table structure for table `log` */

DROP TABLE IF EXISTS `log`;

CREATE TABLE `log` (
  `userName` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `userPassword` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `sex` varchar(500) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `telephone` varchar(2000) DEFAULT NULL,
  `invite` varchar(1000) DEFAULT NULL,
  `rePassword` varchar(500) NOT NULL,
  `date` date DEFAULT NULL,
  PRIMARY KEY (`userName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

/*Data for the table `log` */

insert  into `log`(`userName`,`userPassword`,`sex`,`telephone`,`invite`,`rePassword`,`date`) values 
('？？？','!!!',NULL,NULL,NULL,'',NULL),
('233','233',NULL,NULL,NULL,'',NULL),
('25442','245245',NULL,NULL,NULL,'',NULL),
('434','434',NULL,NULL,NULL,'',NULL),
('4545','457587',NULL,NULL,NULL,'',NULL),
('77','77',NULL,NULL,NULL,'',NULL),
('777','777',NULL,NULL,NULL,'',NULL),
('782872','87278278',NULL,NULL,NULL,'',NULL),
('88','88','99',NULL,NULL,'',NULL),
('888','888',NULL,NULL,NULL,'',NULL),
('Chen','123456',NULL,NULL,NULL,'',NULL),
('cnm','cnm',NULL,NULL,NULL,'',NULL),
('Huang','abcdefg',NULL,NULL,NULL,'',NULL),
('kk','777',NULL,NULL,NULL,'',NULL),
('Li','123',NULL,NULL,NULL,'',NULL),
('Name','Password',NULL,NULL,NULL,'',NULL),
('nimabi','000',NULL,NULL,NULL,'',NULL),
('omg','520',NULL,NULL,NULL,'',NULL),
('ppp','ppp',NULL,NULL,NULL,'',NULL),
('sb','sb',NULL,NULL,NULL,'',NULL),
('sbsbsb','sbsbsb',NULL,NULL,NULL,'',NULL),
('Wang','456',NULL,NULL,NULL,'',NULL),
('yan','666',NULL,NULL,NULL,'',NULL),
('yyy','520',NULL,NULL,NULL,'',NULL),
('Zheng','abc123',NULL,NULL,NULL,'',NULL),
('七夕','77','女','13672388556','12345678','',NULL),
('七月','777','男',NULL,NULL,'',NULL),
('不知火舞','201314',NULL,NULL,NULL,'',NULL),
('你是傻逼对吧','dui',NULL,NULL,NULL,'',NULL),
('哈哈','haha','人妖','4586521','1234748','haha','1985-07-12'),
('小魔女','520',NULL,NULL,NULL,'',NULL),
('爱你哦','aini',NULL,NULL,NULL,'',NULL),
('牛不牛','666',NULL,NULL,NULL,'',NULL),
('牛批','666','男','13672369939','85456465','666',NULL),
('牛逼','1234',NULL,NULL,NULL,'',NULL),
('龙的传人','china',NULL,NULL,NULL,'',NULL);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
