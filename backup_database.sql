-- MySQL dump 10.13  Distrib 8.0.39, for Win64 (x86_64)
--
-- Host: localhost    Database: klinikGigi
-- ------------------------------------------------------
-- Server version	8.0.39

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `antrean`
--

DROP TABLE IF EXISTS `antrean`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `antrean` (
  `antrean_id` int NOT NULL AUTO_INCREMENT,
  `pasien_id` int NOT NULL,
  `dokter_id` int DEFAULT NULL,
  `tanggal_antrean` date DEFAULT NULL,
  `status_antrean` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `visible` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`antrean_id`),
  KEY `pasien_id` (`pasien_id`),
  KEY `dokter_id` (`dokter_id`),
  CONSTRAINT `antrean_ibfk_1` FOREIGN KEY (`pasien_id`) REFERENCES `pasien` (`pasien_id`) ON DELETE CASCADE,
  CONSTRAINT `antrean_ibfk_2` FOREIGN KEY (`dokter_id`) REFERENCES `dokter` (`dokter_id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `antrean`
--

LOCK TABLES `antrean` WRITE;
/*!40000 ALTER TABLE `antrean` DISABLE KEYS */;
INSERT INTO `antrean` VALUES (7,1,2,'2025-01-07','Selesai',0),(8,21,1,'2025-01-08','Selesai',0),(10,24,1,'2025-01-08','Selesai',0),(11,27,1,'2025-01-08','Selesai',0),(12,23,1,'2025-01-08','Selesai',0),(13,26,1,'2025-02-05','Selesai',0),(14,25,1,'2025-02-07','Selesai',0),(15,22,2,'2025-02-07','Antri',1);
/*!40000 ALTER TABLE `antrean` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dokter`
--

DROP TABLE IF EXISTS `dokter`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dokter` (
  `dokter_id` int NOT NULL AUTO_INCREMENT,
  `nama_dokter` varchar(100) NOT NULL,
  `hari_praktek` varchar(50) DEFAULT NULL,
  `jam_praktek` time DEFAULT NULL,
  `jam_selesai` time DEFAULT NULL,
  PRIMARY KEY (`dokter_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dokter`
--

LOCK TABLES `dokter` WRITE;
/*!40000 ALTER TABLE `dokter` DISABLE KEYS */;
INSERT INTO `dokter` VALUES (1,'Dr. Ahmad','Senin, Selasa, Rabu, Kamis, Jumat, Sabtu','08:00:00','12:00:00'),(2,'Dr. Siti','Senin, Selasa, Rabu, Kamis, Jumat, Sabtu','13:00:00','17:00:00');
/*!40000 ALTER TABLE `dokter` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `layanan`
--

DROP TABLE IF EXISTS `layanan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `layanan` (
  `layanan_id` int NOT NULL AUTO_INCREMENT,
  `nama_layanan` varchar(50) NOT NULL,
  `harga` decimal(10,2) NOT NULL,
  PRIMARY KEY (`layanan_id`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `layanan`
--

LOCK TABLES `layanan` WRITE;
/*!40000 ALTER TABLE `layanan` DISABLE KEYS */;
INSERT INTO `layanan` VALUES (1,'Tambal Gigi',200000.00),(2,'Cabut Gigi',300000.00),(3,'Pembersihan Gigi',150000.00),(4,'Pemutihan Gigi',500000.00),(5,'Perawatan Saluran Akar (Root Canal)',1200000.00),(6,'Pemasangan Kawat Gigi',2500000.00),(7,'Cek Kesehatan Gigi',100000.00),(8,'Pencabutan Gigi Bungsu',400000.00),(9,'Pemasangan Gigi Palsu',1200000.00),(10,'Scaling Gigi',250000.00),(11,'Pemeriksaan Gigi Rutin',80000.00),(12,'Veneer Gigi',1500000.00),(13,'Pemasangan Implan Gigi',5000000.00),(14,'Perawatan Gusi',350000.00),(15,'Orthodontic Consultation',300000.00),(16,'Fluoride Treatment',100000.00),(17,'Gigi Sensitif Treatment',200000.00),(18,'Tindik Gigi',50000.00),(19,'Perawatan Gigi Anak',150000.00),(20,'X-Ray Gigi',200000.00),(21,'Pencabutan Gigi Sederhana',250000.00),(22,'Pencabutan Gigi Kompleks',500000.00),(23,'Penyembuhan Luka Mulut',180000.00),(24,'Rehabilitasi Gigi',3550000.00),(25,'Pemeriksaan Radiologi Gigi',300000.00),(28,'Kontrol',50000.00),(32,'Pemutihan Gigi',350000.00);
/*!40000 ALTER TABLE `layanan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pasien`
--

DROP TABLE IF EXISTS `pasien`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pasien` (
  `pasien_id` int NOT NULL AUTO_INCREMENT,
  `nama` varchar(100) NOT NULL,
  `nik` char(16) NOT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  `umur` int DEFAULT NULL,
  PRIMARY KEY (`pasien_id`),
  UNIQUE KEY `nik` (`nik`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pasien`
--

LOCK TABLES `pasien` WRITE;
/*!40000 ALTER TABLE `pasien` DISABLE KEYS */;
INSERT INTO `pasien` VALUES (1,'Tejo','2004500326732','jl.Benang',24),(2,'Rapi','3304568823412','jl.Raja',23),(4,'rara','123123564586','jl.Situ',21),(21,'Hanif Azmi Hafidh','988214578256','jl. Pembangunan, Curup, Bengkulu',20),(22,'dappin','6475343489559','jl.voila',20),(23,'dion','12345645666','planet lain',12),(24,'yahya','4352346527262','sdaffd',55),(25,'faris andi','1234124325524','jl.Sawa',20),(26,'radit amikom','2345264373773','jl.Sawa Ct 8',22),(27,'Arfian Wardana','1231334325555','jl.Concat 7',25);
/*!40000 ALTER TABLE `pasien` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pembayaran`
--

DROP TABLE IF EXISTS `pembayaran`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pembayaran` (
  `pembayaran_id` int NOT NULL AUTO_INCREMENT,
  `pasien_id` int NOT NULL,
  `total_biaya` decimal(10,2) NOT NULL,
  `tanggal_pembayaran` date NOT NULL,
  `metode_pembayaran` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`pembayaran_id`),
  KEY `pasien_id` (`pasien_id`),
  CONSTRAINT `pembayaran_ibfk_1` FOREIGN KEY (`pasien_id`) REFERENCES `pasien` (`pasien_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pembayaran`
--

LOCK TABLES `pembayaran` WRITE;
/*!40000 ALTER TABLE `pembayaran` DISABLE KEYS */;
INSERT INTO `pembayaran` VALUES (2,1,500000.00,'2025-01-08','Transfer'),(3,21,550000.00,'2025-01-08','Transfer'),(4,24,450000.00,'2025-01-08','Transfer'),(5,27,450000.00,'2025-01-08','Cash'),(6,23,2650000.00,'2025-02-05','Cash'),(7,26,1000000.00,'2025-02-05','Cash'),(8,25,650000.00,'2025-02-07','Transfer');
/*!40000 ALTER TABLE `pembayaran` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pembayaran_layanan`
--

DROP TABLE IF EXISTS `pembayaran_layanan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pembayaran_layanan` (
  `pembayaran_layanan_id` int NOT NULL AUTO_INCREMENT,
  `pembayaran_id` int NOT NULL,
  `layanan_id` int NOT NULL,
  `jumlah` int NOT NULL,
  `biaya` decimal(10,2) NOT NULL,
  PRIMARY KEY (`pembayaran_layanan_id`),
  KEY `pembayaran_id` (`pembayaran_id`),
  KEY `layanan_id` (`layanan_id`),
  CONSTRAINT `pembayaran_layanan_ibfk_1` FOREIGN KEY (`pembayaran_id`) REFERENCES `pembayaran` (`pembayaran_id`) ON DELETE CASCADE,
  CONSTRAINT `pembayaran_layanan_ibfk_2` FOREIGN KEY (`layanan_id`) REFERENCES `layanan` (`layanan_id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pembayaran_layanan`
--

LOCK TABLES `pembayaran_layanan` WRITE;
/*!40000 ALTER TABLE `pembayaran_layanan` DISABLE KEYS */;
/*!40000 ALTER TABLE `pembayaran_layanan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rekam_medis`
--

DROP TABLE IF EXISTS `rekam_medis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rekam_medis` (
  `id` int NOT NULL AUTO_INCREMENT,
  `pasien_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `pasien_id` (`pasien_id`),
  CONSTRAINT `rekam_medis_ibfk_2` FOREIGN KEY (`pasien_id`) REFERENCES `pasien` (`pasien_id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rekam_medis`
--

LOCK TABLES `rekam_medis` WRITE;
/*!40000 ALTER TABLE `rekam_medis` DISABLE KEYS */;
INSERT INTO `rekam_medis` VALUES (1,2),(2,4),(14,21),(15,22),(16,23),(17,24),(18,25),(19,26),(20,27);
/*!40000 ALTER TABLE `rekam_medis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `riwayat_medis`
--

DROP TABLE IF EXISTS `riwayat_medis`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `riwayat_medis` (
  `id` int NOT NULL AUTO_INCREMENT,
  `pasien_id` int DEFAULT NULL,
  `layanan_id` int DEFAULT NULL,
  `dokter_id` int DEFAULT NULL,
  `tanggal_periksa` date NOT NULL,
  `diagnosa` varchar(255) NOT NULL,
  `tindakan` varchar(255) NOT NULL,
  `keluhan` varchar(100) DEFAULT NULL,
  `rekam_medis_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `pasien_id` (`pasien_id`),
  KEY `layanan_id` (`layanan_id`),
  KEY `dokter_id` (`dokter_id`),
  CONSTRAINT `riwayat_medis_ibfk_1` FOREIGN KEY (`pasien_id`) REFERENCES `pasien` (`pasien_id`) ON DELETE CASCADE,
  CONSTRAINT `riwayat_medis_ibfk_2` FOREIGN KEY (`layanan_id`) REFERENCES `layanan` (`layanan_id`) ON DELETE SET NULL,
  CONSTRAINT `riwayat_medis_ibfk_3` FOREIGN KEY (`dokter_id`) REFERENCES `dokter` (`dokter_id`) ON DELETE SET NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `riwayat_medis`
--

LOCK TABLES `riwayat_medis` WRITE;
/*!40000 ALTER TABLE `riwayat_medis` DISABLE KEYS */;
INSERT INTO `riwayat_medis` VALUES (3,4,NULL,NULL,'2024-10-07','Cariees','Scalling','bau mulut',0);
/*!40000 ALTER TABLE `riwayat_medis` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `username` varchar(100) NOT NULL,
  `password` varchar(16) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('AZS','new');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-02-18 19:15:55
