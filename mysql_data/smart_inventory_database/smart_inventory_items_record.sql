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
-- Table structure for table `items_record`
--

DROP TABLE IF EXISTS `items_record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `items_record` (
  `item_id` int(11) NOT NULL auto_increment,
  `item_code` varchar(30) default NULL,
  `item_name` varchar(100) NOT NULL,
  `description` varchar(200) default NULL,
  `alternative_name` varchar(50) default NULL,
  `manufacturer` varchar(100) default NULL,
  `major_supplier` varchar(100) default NULL,
  `pack_quantity` varchar(50) default NULL,
  `pack_description` varchar(50) default NULL,
  `alternative_item` varchar(50) default NULL,
  `standard_issue_qty` varchar(9) default NULL,
  `economic_order_qty` varchar(9) default NULL,
  `purchase_price` float default NULL,
  `markup_percent` float default NULL,
  `selling_price` float default NULL,
  `stock_level` int(11) default NULL,
  `minimum_level` int(11) default NULL,
  `reorder_level` int(11) default NULL,
  `maximum_level` int(11) default NULL,
  `lead_days` int(11) default NULL,
  `date_created` datetime default NULL,
  `date_amended` datetime default NULL,
  `user_created` varchar(45) default NULL,
  `user_amended` varchar(45) default NULL,
  PRIMARY KEY  (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `items_record`
--

LOCK TABLES `items_record` WRITE;
/*!40000 ALTER TABLE `items_record` DISABLE KEYS */;
INSERT INTO `items_record` VALUES (1,'PARA-01','Paracetamol','500mg tablet','','Emzor','Emzor Distributor','10','Sachet','2','Aspirin','100',10,0,20,19,40,500,50,3,'2017-06-26 19:49:01','2017-07-22 20:03:00',NULL,''),(2,'Asp01','Aspirin','300mg','-','-','Emzor','20','Sachet','2','','100',55,15,65,19,100,200,2000,3,'2017-07-01 19:57:12','2017-07-22 22:03:47',NULL,''),(3,'','Felvin','pain killer, 2mg','Piroxicam','','Nich','10','Pack','','Ricam','5',70,0,80,19,10,5,0,1,'2017-07-02 10:43:40','2017-07-22 20:03:00',NULL,'');
/*!40000 ALTER TABLE `items_record` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-07-22 22:14:10
