-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: esparasdb
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `course`
--

DROP TABLE IF EXISTS `course`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `course` (
  `courseID` int NOT NULL AUTO_INCREMENT,
  `courseName` varchar(45) NOT NULL,
  `deptID` int DEFAULT NULL,
  PRIMARY KEY (`courseID`),
  KEY `deptID_idx` (`deptID`),
  CONSTRAINT `deptID` FOREIGN KEY (`deptID`) REFERENCES `department` (`deptID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course`
--

LOCK TABLES `course` WRITE;
/*!40000 ALTER TABLE `course` DISABLE KEYS */;
INSERT INTO `course` VALUES (1,'BS Information Technology',1),(2,'BS Biology',1),(3,'BS Civil Engineering',2),(4,'Bachelor of Elementary Education',3),(5,'BS Economics',4),(6,'BS Social Work',7),(7,'AB Political Science',7),(8,'AB Journalism',8),(9,'Bachelor of Physical Education',9),(10,'BS Architecture',10);
/*!40000 ALTER TABLE `course` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deleted_subject_log`
--

DROP TABLE IF EXISTS `deleted_subject_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deleted_subject_log` (
  `deleted_subject_logID` int NOT NULL AUTO_INCREMENT,
  `subjectID` int NOT NULL,
  `subjectName` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  `time_deleted` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`deleted_subject_logID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deleted_subject_log`
--

LOCK TABLES `deleted_subject_log` WRITE;
/*!40000 ALTER TABLE `deleted_subject_log` DISABLE KEYS */;
INSERT INTO `deleted_subject_log` VALUES (1,11,'Information Management','DELETED','2023-03-03 13:43:13');
/*!40000 ALTER TABLE `deleted_subject_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `deptID` int NOT NULL AUTO_INCREMENT,
  `deptName` varchar(100) NOT NULL,
  PRIMARY KEY (`deptID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'College of Science'),(2,'College of Engineering'),(3,'College of Education'),(4,'College of Business, Economics and Management'),(5,'College of Agriculture and Forestry'),(6,'College of Nursing'),(7,'College of Social Sciences and Philosophy'),(8,'College of Arts and Letters'),(9,'Institute of Physical Education, Sports and Recreation'),(10,'Institute of Design and Architecture');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `instructor`
--

DROP TABLE IF EXISTS `instructor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `instructor` (
  `instructorID` int NOT NULL AUTO_INCREMENT,
  `instructorName` varchar(45) NOT NULL,
  PRIMARY KEY (`instructorID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `instructor`
--

LOCK TABLES `instructor` WRITE;
/*!40000 ALTER TABLE `instructor` DISABLE KEYS */;
INSERT INTO `instructor` VALUES (1,'Prof. Gomez'),(2,'Prof. Perez'),(3,'Prof. Apoloan'),(4,'Prof. Garcia'),(5,'Prof. Enguerra'),(6,'Prof. Esparas'),(7,'Prof. Fernicol'),(8,'Prof. Escultura'),(9,'Prof. Esquivias'),(10,'Prof. Bonuel'),(11,'Prof. Valdez');
/*!40000 ALTER TABLE `instructor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `new_instructor_log`
--

DROP TABLE IF EXISTS `new_instructor_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `new_instructor_log` (
  `new_instructor_id` int NOT NULL AUTO_INCREMENT,
  `instructorID` int NOT NULL,
  `instructorName` varchar(45) NOT NULL,
  PRIMARY KEY (`new_instructor_id`),
  KEY `instructorID_idx` (`instructorID`,`instructorName`),
  CONSTRAINT `instructorName` FOREIGN KEY (`instructorID`) REFERENCES `instructor` (`instructorID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `new_instructor_log`
--

LOCK TABLES `new_instructor_log` WRITE;
/*!40000 ALTER TABLE `new_instructor_log` DISABLE KEYS */;
INSERT INTO `new_instructor_log` VALUES (3,11,'Prof. Valdez');
/*!40000 ALTER TABLE `new_instructor_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `student` (
  `studentID` int NOT NULL AUTO_INCREMENT,
  `studentName` varchar(45) NOT NULL,
  `age` int NOT NULL,
  `date_enrolled` date NOT NULL,
  `yearLevel` varchar(45) NOT NULL,
  `courseID` int DEFAULT NULL,
  PRIMARY KEY (`studentID`),
  KEY `courseID_idx` (`courseID`),
  CONSTRAINT `courseID` FOREIGN KEY (`courseID`) REFERENCES `course` (`courseID`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (1,'Lyka',21,'2020-08-10','3rd year',1),(2,'Marilou',19,'2022-08-15','1st year',2),(3,'Yurie',20,'2021-08-16','2nd year',3),(4,'Apryll',20,'2021-08-16','2nd year',3),(5,'Angela',21,'2019-08-12','4th year',5),(6,'Karl',21,'2020-08-10','3rd year',6),(7,'Lineth',21,'2020-08-10','3rd year',6),(8,'Allen',21,'2020-08-10','3rd year',8),(9,'Hanna',18,'2022-08-15','1st year',9),(10,'Cailo',19,'2022-08-15','1st year',9);
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subject` (
  `subjectID` int NOT NULL AUTO_INCREMENT,
  `subjectName` varchar(45) NOT NULL,
  `instructorID` int DEFAULT NULL,
  `studentID` int DEFAULT NULL,
  PRIMARY KEY (`subjectID`),
  KEY `instructorID_idx` (`instructorID`),
  KEY `studentID_idx` (`studentID`),
  CONSTRAINT `instructorID` FOREIGN KEY (`instructorID`) REFERENCES `instructor` (`instructorID`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `studentID` FOREIGN KEY (`studentID`) REFERENCES `student` (`studentID`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (1,'Event-Driven Programming',1,1),(2,'E-Commerce',2,1),(3,'Biochemistry',3,2),(4,'Differential Equations',4,3),(5,'Readings in the Philippine History',5,4),(6,'Life and Works of Rizal',5,10),(7,'Philosophy 2',8,6),(8,'Applied Philosophy',9,7),(9,'Media Management',6,8),(10,'Surveying',10,9);
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `update_studentage_log`
--

DROP TABLE IF EXISTS `update_studentage_log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `update_studentage_log` (
  `update_studentage_logID` int NOT NULL AUTO_INCREMENT,
  `studentID` int NOT NULL,
  `studentName` varchar(45) NOT NULL,
  `age_before` int NOT NULL,
  `age_after` int NOT NULL,
  `time_updated` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`update_studentage_logID`,`studentID`),
  KEY `studentName_idx` (`studentID`),
  CONSTRAINT `studentName` FOREIGN KEY (`studentID`) REFERENCES `student` (`studentID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `update_studentage_log`
--

LOCK TABLES `update_studentage_log` WRITE;
/*!40000 ALTER TABLE `update_studentage_log` DISABLE KEYS */;
INSERT INTO `update_studentage_log` VALUES (1,10,'Cailo',18,19,'2023-03-03 13:06:06');
/*!40000 ALTER TABLE `update_studentage_log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `username` varchar(45) NOT NULL,
  `password` longtext,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES ('lyka','558935ea8138769f00459fa35d432eaf');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `view1`
--

DROP TABLE IF EXISTS `view1`;
/*!50001 DROP VIEW IF EXISTS `view1`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view1` AS SELECT 
 1 AS `studentID`,
 1 AS `studentName`,
 1 AS `age`,
 1 AS `yearLevel`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view2`
--

DROP TABLE IF EXISTS `view2`;
/*!50001 DROP VIEW IF EXISTS `view2`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view2` AS SELECT 
 1 AS `subjectID`,
 1 AS `subjectName`,
 1 AS `instructorID`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `view3`
--

DROP TABLE IF EXISTS `view3`;
/*!50001 DROP VIEW IF EXISTS `view3`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `view3` AS SELECT 
 1 AS `courseID`,
 1 AS `courseName`,
 1 AS `deptID`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `view1`
--

/*!50001 DROP VIEW IF EXISTS `view1`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view1` AS select `student`.`studentID` AS `studentID`,`student`.`studentName` AS `studentName`,`student`.`age` AS `age`,`student`.`yearLevel` AS `yearLevel` from `student` where (`student`.`age` >= 20) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view2`
--

/*!50001 DROP VIEW IF EXISTS `view2`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view2` AS select `subject`.`subjectID` AS `subjectID`,`subject`.`subjectName` AS `subjectName`,`subject`.`instructorID` AS `instructorID` from `subject` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `view3`
--

/*!50001 DROP VIEW IF EXISTS `view3`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = cp850 */;
/*!50001 SET character_set_results     = cp850 */;
/*!50001 SET collation_connection      = cp850_general_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `view3` AS select `course`.`courseID` AS `courseID`,`course`.`courseName` AS `courseName`,`course`.`deptID` AS `deptID` from `course` where (`course`.`deptID` = 1) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-13  2:21:49
