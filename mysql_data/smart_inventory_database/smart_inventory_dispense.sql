CREATE DATABASE  IF NOT EXISTS `smart_inventory` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `smart_inventory`;
-- MySQL dump 10.13  Distrib 5.1.40, for Win32 (ia32)
--
-- Host: localhost    Database: smart_inventory
-- ------------------------------------------------------
-- Server version	5.0.45-community-nt

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Not dumping tablespaces as no INFORMATION_SCHEMA.FILES table on this server
--

--
-- Table structure for table `dispense`
--

DROP TABLE IF EXISTS `dispense`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dispense` (
  `dispense_id` int(11) NOT NULL auto_increment,
  `item_id` varchar(30) NOT NULL,
  `group_id` varchar(11) NOT NULL,
  `group_date` date NOT NULL,
  `item_code` varchar(30) default NULL,
  `item_name` varchar(100) NOT NULL,
  `stock_level` int(11) NOT NULL,
  `unit_price` float default NULL,
  `dispense_quantity` int(11) NOT NULL,
  `sub_amount` float default NULL,
  `vat` float default NULL,
  `total_amount` float default NULL,
  `stock_balance` int(11) default NULL,
  `date_dispensed` datetime default NULL,
  `user_dispensed` varchar(45) default NULL,
  `dispense_completed` varchar(5) default NULL,
  PRIMARY KEY  (`dispense_id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dispense`
--

LOCK TABLES `dispense` WRITE;
/*!40000 ALTER TABLE `dispense` DISABLE KEYS */;
INSERT INTO `dispense` VALUES (1,'1','27695','2017-07-01','PARA-01','Paracetamol',20,5,1,5,NULL,NULL,20,'2017-07-01 17:51:25','',NULL),(2,'1','11358','2017-07-01','PARA-01','Paracetamol',18,5,2,10,NULL,NULL,18,'2017-07-01 18:01:29','',NULL),(3,'1','3439','2017-07-01','PARA-01','Paracetamol',15,4,3,12,NULL,NULL,15,'2017-07-01 18:06:06','',NULL),(4,'1','85908','2017-07-01','PARA-01','Paracetamol',13,3,2,6,NULL,NULL,13,'2017-07-01 18:12:02','',NULL),(5,'1','21550','2017-07-01','PARA-01','Paracetamol',10,3,3,9,NULL,NULL,10,'2017-07-01 18:16:45','','YES'),(6,'1','18689','2017-07-01','PARA-01','Paracetamol',8,5,2,10,NULL,NULL,8,'2017-07-01 18:28:35','',NULL),(7,'1','71243','2017-07-01','PARA-01','Paracetamol',6,3,2,6,NULL,NULL,6,'2017-07-01 18:35:20','',NULL),(8,'1','60611','2017-07-01','PARA-01','Paracetamol',5,5,1,5,NULL,NULL,5,'2017-07-01 18:39:10','','YES'),(9,'1','26130','2017-07-01','PARA-01','Paracetamol',4,2,1,2,NULL,NULL,4,'2017-07-01 20:09:37','',NULL),(10,'2','88108','2017-07-01','Asp01','Aspirin',14,5,2,10,NULL,NULL,14,'2017-07-01 20:10:18','',NULL),(11,'2','10657','2017-07-01','Asp01','Aspirin',13,5,1,5,NULL,NULL,13,'2017-07-01 20:11:28','','YES'),(12,'2','21132','2017-07-02','Asp01','Aspirin',3,10,1,10,NULL,NULL,3,'2017-07-02 15:21:21','','YES'),(13,'3','21132','2017-07-02','','Felvin',47,50,1,50,NULL,NULL,47,'2017-07-02 15:21:21','','YES'),(14,'3','4141','2017-07-02','','Felvin',46,50,1,50,NULL,NULL,46,'2017-07-02 15:25:04','','YES'),(15,'1','4141','2017-07-02','PARA-01','Paracetamol',3,40,1,40,NULL,NULL,3,'2017-07-02 15:25:04','','YES'),(16,'3','42799','2017-07-11','','Felvin',43,55,1,55,NULL,NULL,43,'2017-07-11 22:07:18','',NULL),(17,'3','60105','2017-07-11','','Felvin',42,55,1,55,NULL,NULL,42,'2017-07-11 22:27:23','','YES'),(18,'1','60105','2017-07-11','PARA-01','Paracetamol',2,12,1,12,NULL,NULL,2,'2017-07-11 22:27:23','','YES'),(19,'3','26499','2017-07-11','','Felvin',41,55,1,55,NULL,NULL,41,'2017-07-11 22:37:54','',NULL),(20,'1','26499','2017-07-11','PARA-01','Paracetamol',1,12,1,12,NULL,NULL,1,'2017-07-11 22:37:54','',NULL),(21,'3','71337','2017-07-16','','Felvin',17,70,1,70,NULL,NULL,17,'2017-07-16 15:48:51','',NULL),(22,'3','37887','2017-07-16','','Felvin',13,70,1,0,NULL,NULL,0,'2017-07-16 20:17:35','',NULL),(23,'3','66011','2017-07-16','','Felvin',13,70,1,0,NULL,NULL,12,'2017-07-16 20:52:25','',NULL),(24,'3','60419','2017-07-16','','Felvin',12,70,1,70,NULL,NULL,11,'2017-07-16 20:54:54','','YES'),(25,'3','84483','2017-07-16','','Felvin',11,70,1,70,NULL,NULL,10,'2017-07-16 21:19:07','','YES'),(26,'2','84483','2017-07-16','Asp01','Aspirin',8,58,2,116,NULL,NULL,6,'2017-07-16 21:19:07','','YES'),(27,'1','84483','2017-07-16','PARA-01','Paracetamol',10,10,1,10,NULL,NULL,9,'2017-07-16 21:19:07','','YES'),(28,'1','84269','2017-07-16','PARA-01','Paracetamol',9,10,1,10,NULL,NULL,8,'2017-07-16 21:35:23','','YES'),(29,'1','84269','2017-07-16','PARA-01','Paracetamol',8,10,1,10,NULL,NULL,7,'2017-07-16 21:35:23','',NULL),(30,'1','74996','2017-07-16','PARA-01','Paracetamol',7,10,1,10,NULL,NULL,6,'2017-07-16 21:36:32','','YES'),(31,'2','74996','2017-07-16','Asp01','Aspirin',7,58,1,58,NULL,NULL,6,'2017-07-16 21:36:32','','YES'),(32,'2','74996','2017-07-16','Asp01','Aspirin',6,58,1,58,NULL,NULL,5,'2017-07-16 21:36:32','',NULL),(33,'3','11913','2017-07-16','','Felvin',10,70,1,70,NULL,NULL,9,'2017-07-16 21:41:06','','YES'),(34,'2','11913','2017-07-16','Asp01','Aspirin',5,58,1,58,NULL,NULL,4,'2017-07-16 21:41:06','','YES'),(35,'2','11913','2017-07-16','Asp01','Aspirin',4,58,1,58,NULL,NULL,3,'2017-07-16 21:41:06','','YES'),(36,'1','11913','2017-07-16','PARA-01','Paracetamol',6,10,1,10,NULL,NULL,5,'2017-07-16 21:41:06','','YES'),(37,'3','31610','2017-07-22','','Felvin',9,80,1,80,NULL,NULL,8,'2017-07-22 11:40:06','','YES'),(38,'2','31610','2017-07-22','Asp01','Aspirin',2,60,2,120,NULL,NULL,0,'2017-07-22 11:40:06','','YES'),(39,'3','31610','2017-07-22','','Felvin',8,80,1,80,NULL,NULL,7,'2017-07-22 11:40:06','','YES'),(40,'2','2304','2017-07-22','Asp01','Aspirin',19,60,1,60,NULL,NULL,18,'2017-07-22 20:03:00','','YES'),(41,'1','2304','2017-07-22','PARA-01','Paracetamol',19,20,1,20,NULL,NULL,18,'2017-07-22 20:03:00','','YES'),(42,'3','2304','2017-07-22','','Felvin',19,80,1,80,NULL,NULL,18,'2017-07-22 20:03:00','','YES');
/*!40000 ALTER TABLE `dispense` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-22 22:14:09
