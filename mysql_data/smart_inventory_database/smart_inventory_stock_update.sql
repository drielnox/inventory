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
-- Table structure for table `stock_update`
--

DROP TABLE IF EXISTS `stock_update`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stock_update` (
  `update_id` int(11) NOT NULL auto_increment,
  `item_id` varchar(30) NOT NULL,
  `item_code` varchar(30) default NULL,
  `item_name` varchar(100) NOT NULL,
  `stock_level` int(11) NOT NULL,
  `qty_added` int(11) default NULL,
  `qty_deducted` int(11) default NULL,
  `stock_balance` int(11) default NULL,
  `date_updated` datetime default NULL,
  `user_updated` varchar(45) default NULL,
  PRIMARY KEY  (`update_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stock_update`
--

LOCK TABLES `stock_update` WRITE;
/*!40000 ALTER TABLE `stock_update` DISABLE KEYS */;
INSERT INTO `stock_update` VALUES (1,'1','PARA-01','Paracetamol',21,20,0,21,'2017-07-01 17:50:14',''),(2,'2','Asp01','Aspirin',20,20,0,20,'2017-07-01 20:00:21',''),(3,'2','Asp01','Aspirin',20,20,0,20,'2017-07-01 20:00:21',''),(4,'3','','Felvin',50,50,0,50,'2017-07-02 10:59:47',''),(5,'2','Asp01','Aspirin',10,10,0,10,'2017-07-11 22:39:12',''),(6,'1','PARA-01','Paracetamol',11,10,0,11,'2017-07-11 22:48:53',''),(7,'1','PARA-01','Paracetamol',20,14,0,20,'2017-07-22 11:41:36',''),(8,'2','Asp01','Aspirin',20,18,0,20,'2017-07-22 11:41:36',''),(9,'3','','Felvin',20,12,0,20,'2017-07-22 11:41:36','');
/*!40000 ALTER TABLE `stock_update` ENABLE KEYS */;
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
