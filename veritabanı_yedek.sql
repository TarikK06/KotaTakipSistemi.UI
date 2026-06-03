-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: kotatakipdb
-- ------------------------------------------------------
-- Server version	8.0.46

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aboneler`
--

DROP TABLE IF EXISTS `aboneler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `aboneler` (
  `AboneID` int NOT NULL AUTO_INCREMENT,
  `Ad` varchar(50) NOT NULL,
  `Soyad` varchar(50) NOT NULL,
  `TCKN` char(11) NOT NULL,
  `Telefon` varchar(15) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `KayitTarihi` date DEFAULT (curdate()),
  PRIMARY KEY (`AboneID`),
  UNIQUE KEY `TCKN` (`TCKN`),
  UNIQUE KEY `Email` (`Email`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aboneler`
--

LOCK TABLES `aboneler` WRITE;
/*!40000 ALTER TABLE `aboneler` DISABLE KEYS */;
INSERT INTO `aboneler` VALUES (6,'tarik','koca','55555555555','5555555555','tarikemin','2026-06-02');
/*!40000 ALTER TABLE `aboneler` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faturalar`
--

DROP TABLE IF EXISTS `faturalar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `faturalar` (
  `FaturaID` int NOT NULL AUTO_INCREMENT,
  `HatID` int NOT NULL,
  `FaturaTarihi` date DEFAULT (curdate()),
  `SonOdemeTarihi` date NOT NULL,
  `ToplamTutar` decimal(10,2) NOT NULL,
  `OdenmeDurumu` varchar(10) DEFAULT 'Ödenmedi',
  PRIMARY KEY (`FaturaID`),
  KEY `HatID` (`HatID`),
  CONSTRAINT `faturalar_ibfk_1` FOREIGN KEY (`HatID`) REFERENCES `hatlar` (`HatID`) ON DELETE CASCADE,
  CONSTRAINT `faturalar_chk_1` CHECK ((`OdenmeDurumu` in (_utf8mb4'Ödendi',_utf8mb4'Ödenmedi')))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faturalar`
--

LOCK TABLES `faturalar` WRITE;
/*!40000 ALTER TABLE `faturalar` DISABLE KEYS */;
/*!40000 ALTER TABLE `faturalar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hatlar`
--

DROP TABLE IF EXISTS `hatlar`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hatlar` (
  `HatID` int NOT NULL AUTO_INCREMENT,
  `AboneID` int NOT NULL,
  `PaketID` int NOT NULL,
  `IpAdresi` varchar(45) NOT NULL,
  `KalanKotaGB` decimal(10,2) NOT NULL,
  `Durum` varchar(20) DEFAULT 'Aktif',
  PRIMARY KEY (`HatID`),
  UNIQUE KEY `IpAdresi` (`IpAdresi`),
  KEY `AboneID` (`AboneID`),
  KEY `PaketID` (`PaketID`),
  CONSTRAINT `hatlar_ibfk_1` FOREIGN KEY (`AboneID`) REFERENCES `aboneler` (`AboneID`) ON DELETE CASCADE,
  CONSTRAINT `hatlar_ibfk_2` FOREIGN KEY (`PaketID`) REFERENCES `paketler` (`PaketID`),
  CONSTRAINT `hatlar_chk_1` CHECK ((`Durum` in (_utf8mb4'Aktif',_utf8mb4'Dondurulmuş',_utf8mb4'Kota Aşımı')))
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hatlar`
--

LOCK TABLES `hatlar` WRITE;
/*!40000 ALTER TABLE `hatlar` DISABLE KEYS */;
INSERT INTO `hatlar` VALUES (2,6,1,'192.168.1.171',16.95,'Aktif');
/*!40000 ALTER TABLE `hatlar` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kullanimgecmisi`
--

DROP TABLE IF EXISTS `kullanimgecmisi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `kullanimgecmisi` (
  `KullanimID` int NOT NULL AUTO_INCREMENT,
  `HatID` int NOT NULL,
  `HarcananDownloadMB` decimal(10,2) DEFAULT '0.00',
  `HarcananUploadMB` decimal(10,2) DEFAULT '0.00',
  `Tarih` date DEFAULT (curdate()),
  PRIMARY KEY (`KullanimID`),
  KEY `HatID` (`HatID`),
  CONSTRAINT `kullanimgecmisi_ibfk_1` FOREIGN KEY (`HatID`) REFERENCES `hatlar` (`HatID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kullanimgecmisi`
--

LOCK TABLES `kullanimgecmisi` WRITE;
/*!40000 ALTER TABLE `kullanimgecmisi` DISABLE KEYS */;
/*!40000 ALTER TABLE `kullanimgecmisi` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paketler`
--

DROP TABLE IF EXISTS `paketler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paketler` (
  `PaketID` int NOT NULL AUTO_INCREMENT,
  `PaketAdi` varchar(100) NOT NULL,
  `HizLimiti` varchar(50) NOT NULL,
  `KotaLimitiGB` int NOT NULL,
  `AylikUcret` decimal(10,2) NOT NULL,
  PRIMARY KEY (`PaketID`),
  CONSTRAINT `paketler_chk_1` CHECK ((`KotaLimitiGB` >= 0)),
  CONSTRAINT `paketler_chk_2` CHECK ((`AylikUcret` >= 0))
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paketler`
--

LOCK TABLES `paketler` WRITE;
/*!40000 ALTER TABLE `paketler` DISABLE KEYS */;
INSERT INTO `paketler` VALUES (1,'20 GB İnternet Paketi','',0,0.00),(2,'50 GB İnternet Paketi','',0,0.00),(3,'100 GB İnternet Paketi','',0,0.00);
/*!40000 ALTER TABLE `paketler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-03 18:35:50
