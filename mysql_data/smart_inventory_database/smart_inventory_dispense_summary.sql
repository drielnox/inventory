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
-- Table structure for table `dispense_summary`
--

DROP TABLE IF EXISTS `dispense_summary`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dispense_summary` (
  `dsp_id` int(11) NOT NULL auto_increment,
  `group_id` varchar(10) NOT NULL,
  `group_date` date NOT NULL,
  `sub_amount` float NOT NULL,
  `discount` float default NULL,
  `vat` float default NULL,
  `total` float NOT NULL,
  `date_dispensed` datetime default NULL,
  `user_dispensed` varchar(30) default NULL,
  PRIMARY KEY  (`dsp_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dispense_summary`
--

LOCK TABLES `dispense_summary` WRITE;
/*!40000 ALTER TABLE `dispense_summary` DISABLE KEYS */;
INSERT INTO `dispense_summary` VALUES (1,'21550','2017-07-01',9,1,5,8,'2017-07-01 18:16:45',''),(2,'60611','2017-07-01',5,2,4.5,3,'2017-07-01 18:39:10',''),(3,'10657','2017-07-01',5,1,5,4,'2017-07-01 20:11:28',''),(4,'21132','2017-07-02',60,10,0,50,'2017-07-02 15:21:21',''),(5,'60105','2017-07-11',67,7,0,60,'2017-07-11 22:27:23',''),(6,'60419','2017-07-16',70,0,0,70,'2017-07-16 20:54:54',''),(7,'84269','2017-07-16',10,0,0,10,'2017-07-16 21:35:23',''),(8,'74996','2017-07-16',68,0,0,68,'2017-07-16 21:36:32',''),(9,'11913','2017-07-16',196,0,0,196,'2017-07-16 21:41:06',''),(10,'31610','2017-07-22',280,50,0,230,'2017-07-22 11:40:06',''),(11,'2304','2017-07-22',160,0,0,160,'2017-07-22 20:03:00','');
/*!40000 ALTER TABLE `dispense_summary` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-22 22:14:07
