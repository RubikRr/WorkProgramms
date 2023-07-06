-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: work_programs
-- ------------------------------------------------------
-- Server version	8.0.30

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
-- Table structure for table `block`
--

DROP TABLE IF EXISTS `block`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `block` (
  `id` int NOT NULL AUTO_INCREMENT,
  `block_title` varchar(255) NOT NULL,
  `part_title` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `block`
--

LOCK TABLES `block` WRITE;
/*!40000 ALTER TABLE `block` DISABLE KEYS */;
INSERT INTO `block` VALUES (1,'Блок 1.Дисциплины (модули)','Обязательная часть'),(2,'Блок 1.Дисциплины (модули)','Часть, формируемая участниками образовательных отношений'),(3,'Блок 2.Практика','Обязательная часть'),(4,'Блок 2.Практика','Часть, формируемая участниками образовательных отношений'),(5,'Блок 3.Государственная итоговая аттестация','ФТД.Факультативы '),(6,'Блок 1 «Дисциплины (модули)»','Базовая часть'),(7,'Блок 1 «Дисциплины (модули)»','Вариативная часть'),(8,'Блок 2 «Практики»','Вариативная часть'),(9,'Блок 3 «Научные исследования»','Вариативная часть'),(10,'Блок 4 «Государственная итоговая аттестация»','Базовая часть'),(11,'ФТД.Факультативы',''),(12,'Блок 3',''),(13,'Блок 3.Государственная итоговая аттестация','');
/*!40000 ALTER TABLE `block` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classroom_funds`
--

DROP TABLE IF EXISTS `classroom_funds`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classroom_funds` (
  `id` int NOT NULL AUTO_INCREMENT,
  `current_year` year NOT NULL,
  `semester` int NOT NULL,
  `day_week` int NOT NULL,
  `lesson_num` int NOT NULL,
  `week_num` int NOT NULL,
  `croom_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classroom_funds`
--

LOCK TABLES `classroom_funds` WRITE;
/*!40000 ALTER TABLE `classroom_funds` DISABLE KEYS */;
/*!40000 ALTER TABLE `classroom_funds` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `classrooms`
--

DROP TABLE IF EXISTS `classrooms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classrooms` (
  `id` int NOT NULL AUTO_INCREMENT,
  `number` varchar(4) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classrooms`
--

LOCK TABLES `classrooms` WRITE;
/*!40000 ALTER TABLE `classrooms` DISABLE KEYS */;
/*!40000 ALTER TABLE `classrooms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `competence`
--

DROP TABLE IF EXISTS `competence`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `competence` (
  `id` int NOT NULL AUTO_INCREMENT,
  `code` varchar(6) NOT NULL,
  `description` text NOT NULL,
  `speciality_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `competence`
--

LOCK TABLES `competence` WRITE;
/*!40000 ALTER TABLE `competence` DISABLE KEYS */;
INSERT INTO `competence` VALUES (1,'УК-1','Способен осуществлять поиск, критический анализ и синтез информации, применять системный подход для решения поставленных задач',0),(2,'УК-2','Способен определять круг задач в рамках поставленной цели и выбирать оптимальные способы их решения, исходя из действующих правовых норм, имеющихся ресурсов и ограничений',0),(3,'УК-3','Способен осуществлять социальное взаимодействие и реализовывать свою роль в команде',0),(4,'УК-4','Способен осуществлять деловую коммуникацию в устной и письменной формах на государственном языке Российской Федерации и иностранном(ых) языке(ах)',0),(5,'УК-5','Способен воспринимать межкультурное разнообразие общества в социально-историческом, этическом и философском контекстах',0),(6,'УК-6','Способен управлять своим временем, выстраивать и реализовывать траекторию саморазвития на основе принципов образования в течение всей жизни',0),(7,'УК-7','Способен поддерживать должный уровень физической подготовленности для обеспечения полноценной социальной и профессиональной деятельности',0),(8,'УК-8','Способен создавать и поддерживать безопасные условия жизнедеятельности, в том числе при возникновении чрезвычайных ситуаций',0),(9,'ОПК-1','Способен применять фундаментальные знания, полученные в области математических и (или) естественных наук, и использовать их в профессиональной деятельности',0),(10,'ОПК-2','Способен разрабатывать, анализировать и внедрять новые математические модели в современных естествознании, технике, экономике и управлении',0),(11,'ОПК-3','Способен использовать в педагогической деятельности научные знания в сфере математики и информатики',0),(12,'ОПК-4','Способен решать задачи профессиональной деятельности с использованием существующих информационно-коммуникационных технологий и с учетом основных требований информационной безопасности',0),(13,'ПК-1','Способен администрировать средства защиты информации в компьютерных системах и сетях',0),(14,'ПК-2','Способен к программной реализации алгоритмов решения типовых задач обеспечения информационной безопасности и к применению программных средств системного, прикладного и специального назначения',0),(15,'ПК-3','Способен проводить научно-исследовательские и опытно-конструкторские разработки по отдельным разделам темы',0),(16,'ПК-4','Способен использовать педагогически обоснованные формы, методы и приемы организации деятельности обучающихся, применять современные технические средства обучения и образовательные технологии',0);
/*!40000 ALTER TABLE `competence` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `degrees`
--

DROP TABLE IF EXISTS `degrees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `degrees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `short_title` varchar(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `degrees`
--

LOCK TABLES `degrees` WRITE;
/*!40000 ALTER TABLE `degrees` DISABLE KEYS */;
INSERT INTO `degrees` VALUES (1,'кандидат физико-математических наук','к.ф.-м.н.'),(2,'доктор физико-математических наук','д.ф.-м.н.');
/*!40000 ALTER TABLE `degrees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departments`
--

DROP TABLE IF EXISTS `departments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `departments` (
  `id` int NOT NULL AUTO_INCREMENT,
  `faculty_id` int NOT NULL,
  `title` varchar(255) NOT NULL,
  `head_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=132 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departments`
--

LOCK TABLES `departments` WRITE;
/*!40000 ALTER TABLE `departments` DISABLE KEYS */;
INSERT INTO `departments` VALUES (1,1,'кафедра прикладной математики и информатики',2),(2,1,'кафедра алгебры и анализа',3),(3,0,'Социально-гуманитарных дисциплин (Политологии)',0),(4,0,'Социально-гуманитарных дисциплин (Философии)',0),(5,0,'Социально-гуманитарных дисциплин (Этнокультурологии)',0),(6,0,'Экономической теории (Экономики)',0),(7,0,'Общей психологии (Психологии)',0),(8,0,'Общей психологии (Педагогики)',0),(9,0,'Общей психологии (Педагогики высшей школы)',0),(10,0,'Иностранных языков для гуманитарных факультетов',0),(11,0,'Иностранных языков для естественнонаучных факультетов',0),(12,0,'Русской и зарубежной литературы (Зарубежной литературы и мировой художественной культуры)',0),(13,0,'Русской и зарубежной литературы (Русской литературы)',0),(14,0,'Русского языка',0),(15,0,'Социологии политических и социальных процессов',0),(16,0,'Фундаментальной социологии',0),(17,0,'Психологии',0),(18,0,'Теории и методологии социальной работы',0),(19,0,'Психолого-педагогических и медицинских проблем социальной работы',0),(20,0,'Технологий и инноваций в социальной работе',0),(21,0,'Теории и методики физического воспитания',0),(22,0,'Физического воспитания',0),(23,0,'Спортивных дисциплин',0),(24,0,'Спортивных игр',0),(25,0,'Теории и методики спортивной борьбы',0),(26,0,'Возрастной морфологии и физиологии',0),(27,0,'Русского языка и литературы в национальной школе  (Русского языка в национальной школе)',0),(28,0,'Русского языка и литературы в национальной школе (Русской литературы в национальной школе)',0),(29,0,'Осетинского и общего языкознания',0),(30,0,'Осетинской литературы (Осетинской литературы)',0),(31,0,'Осетинской литературы (Осетинского литературного творчества)',0),(32,0,'Журналистики (Телерадиовещания, связей с общественностью и рекламы)',0),(33,0,'Журналистики (Истории журналистики и современной печати)',0),(34,0,'Культуры речи и языка массовых коммуникаций',0),(35,0,'Истории древнего мира и средних веков',0),(36,0,'Российской истории (Российской истории и кавказоведения)',0),(37,0,'Новейшей истории и политики России',0),(38,0,'Новой, новейшей истории и исторической  политологии',0),(39,0,'Теории и истории государства и права',0),(40,0,'Уголовного права',0),(41,0,'Уголовного процесса и криминалистики',0),(42,0,'Предпринимательского и гражданского  права',0),(43,0,'Государственного права',0),(44,0,'Английского языка',0),(45,0,'Немецкого языка',0),(46,0,'Французского языка',0),(47,0,'Международных экономических отношений',0),(48,0,'Методики начального обучения',0),(49,0,'Методики начального национального обучения',0),(50,0,'Педагогики и психологии',0),(51,0,'Ботаники',0),(52,0,'Зоологии',0),(53,0,'Анатомии и физиологии человека и животных',0),(54,0,'Технологии пищевых продуктов',0),(55,0,'Физической географии',0),(56,0,'Экономической, социальной и политической географии',0),(57,0,'Геоэкологии и устойчивого развития',0),(58,0,'Землеустройства и кадастров',0),(59,0,'Индустрии сервиса и туризма',0),(60,0,'Технологии лекарственных форм и организации фармацевтического дела',0),(61,0,'Фармацевтической химии и фармакогнозии',0),(62,0,'Общей и неорганической химии',0),(63,0,'Органической химии',0),(64,0,'Товароведения и технологии продуктов питания (Экспертизы товаров)',0),(65,0,'Алгебры и геометрии',0),(66,0,'Прикладной математики',0),(67,0,'Функционального анализа и дифференциальных уравнений',0),(68,0,'Математического анализа',0),(69,0,'Общей физики',0),(70,0,'Физики твердого тела и электроники',0),(71,0,'Технологии и конструирования швейных изделий',0),(72,0,'Теоретической и математической физики',0),(73,0,'Физики и астрономии',0),(74,0,'Налогов и налогообложения',0),(75,0,'Бухгалтерского учета и аудита',0),(76,0,'Финансов и кредита',0),(77,0,'Экономической теории',0),(78,0,'Экономики и предпринимательства',0),(79,0,'Менеджмента',0),(80,0,'Маркетинга',0),(81,0,'Театрального искусства',0),(82,0,'Изобразительного искусства',0),(83,0,'Стоматологии',0),(84,0,'Социально-гуманитарных дисциплин',0),(85,0,'Педагогики и психологии',0),(86,0,'Русской и зарубежной литературы',0),(87,0,'Русского языка и литературы в национальной школе',0),(88,0,'Осетинского языка (Осетинского языка и литературы)',0),(89,0,'Журналистики',0),(90,0,'Социологии и социальных процессов',0),(91,0,'Спортивных игр и медико-биологических дисциплин',0),(92,0,'Теории, методики физического воспитания и легкой атлетики',0),(93,0,'Теории, методики спортивной борьбы и гимнастики',0),(94,0,'Начального и дошкольного образования',0),(95,0,'Анатомии, физиологии и ботаники',0),(96,0,'Физической и социально-экономической географии',0),(97,0,'Физики конденсированного состояния',0),(98,0,'Гражданского и предпринимательского права',0),(99,0,'Гражданского процесса и трудового права',0),(100,0,'Терапевтической, хирургической и детской стоматологии',0),(101,0,'Ортопедической стоматологии, пропедевтики и постдипломного образования',0),(102,0,'Бухгалтерского учета и налогообложения',0),(103,0,'Иностранных языков для неязыковых специальностей',0),(104,0,'Всеобщей истории иисторической политологии (Всеобщей истории и политологии)',0),(105,0,'Новейшей отечественной истории (Новейшей отечественной истории и философии) (Политической истории и',0),(106,0,'Уголовного права и процесса',0),(107,0,'Гражданского права и процесса',0),(108,0,'Базовая кафедра Верховного суда РСО-Алания «Судебная деятельность»',0),(109,0,'Менеджмента и маркетинга',0),(110,0,'Теории и истории социальной работы (Теории и практики социальной работы)',0),(111,0,'Психолого-педагогических и медицинских проблем социальной работы (Социального обеспечения и управлен',0),(112,0,'Социологии (Социологии и социальной работы)',0),(113,0,'Зоологии и биоэкологии (Зоологии, биоэкологии и биотехнологии)',0),(114,0,'Геоэкологии и землеустройства',0),(115,0,'Теории и методики физического воспитания и спортивных дисциплин',0),(116,0,'Фундаментальной медицины',0),(117,0,'Фармации',0),(118,0,'Философии и общественных наук (Философии и социально-политических наук)',0),(119,0,'Маркетинга и рекламы',0),(120,0,'Инклюзивного образования',0),(121,0,'Медиакоммуникаций и мультимедийных технологий',0),(122,0,'Технологий современных СМИ (базовая)',0),(123,0,'Социальной работы',0),(124,0,'Экономики',0),(125,0,'Предпринимательства, сервиса и туризма',0),(126,0,'Современных технологий бродильных производств (базовая)',0),(127,0,'Регионального развития (базовая)',0),(128,0,'Дизайна, конструирования изделий легкой промышленности',0),(129,0,'Осетинской литературы',0),(130,0,'Всеобщей истории',0),(131,0,'Политологии',0);
/*!40000 ALTER TABLE `departments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edu_forms`
--

DROP TABLE IF EXISTS `edu_forms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `edu_forms` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edu_forms`
--

LOCK TABLES `edu_forms` WRITE;
/*!40000 ALTER TABLE `edu_forms` DISABLE KEYS */;
INSERT INTO `edu_forms` VALUES (1,'Очная'),(2,'Очно-заочная'),(3,'Заочная');
/*!40000 ALTER TABLE `edu_forms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edu_levels`
--

DROP TABLE IF EXISTS `edu_levels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `edu_levels` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  `level` tinyint(1) NOT NULL DEFAULT '1' COMMENT '1-high level',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edu_levels`
--

LOCK TABLES `edu_levels` WRITE;
/*!40000 ALTER TABLE `edu_levels` DISABLE KEYS */;
INSERT INTO `edu_levels` VALUES (1,'бакалавриат',1),(2,'магистратура',1),(3,'специалитет',1),(4,'аспирантура',1),(5,'докторантура',1);
/*!40000 ALTER TABLE `edu_levels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edu_plan`
--

DROP TABLE IF EXISTS `edu_plan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `edu_plan` (
  `id` int NOT NULL AUTO_INCREMENT,
  `block_id` int NOT NULL,
  `subject_id` int NOT NULL,
  `code_subject` varchar(10) NOT NULL,
  `department_id` int NOT NULL,
  `title_plan_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=84 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edu_plan`
--

LOCK TABLES `edu_plan` WRITE;
/*!40000 ALTER TABLE `edu_plan` DISABLE KEYS */;
INSERT INTO `edu_plan` VALUES (1,1,1,'0',0,1),(2,1,2,'35',36,1),(3,1,3,'129',130,1),(4,1,4,'21',22,1),(5,1,5,'102',103,1),(6,1,6,'64',65,1),(7,1,7,'67',68,1),(8,1,8,'65',66,1),(9,1,9,'64',65,1),(10,1,10,'64',65,1),(11,1,11,'64',65,1),(12,1,12,'65',66,1),(13,1,13,'65',66,1),(14,1,14,'64',65,1),(15,1,15,'64',65,1),(16,1,16,'72',73,1),(17,1,17,'64',65,1),(18,1,18,'65',66,1),(19,1,19,'66',67,1),(20,1,20,'117',118,1),(21,1,21,'66',67,1),(22,1,22,'42',43,1),(23,1,23,'65',66,1),(24,1,24,'64',65,1),(25,1,25,'65',66,1),(26,1,26,'65',66,1),(27,1,27,'49',50,1),(28,1,28,'49',50,1),(29,1,29,'66',67,1),(30,1,30,'65',66,1),(31,1,31,'66',67,1),(32,1,32,'64',65,1),(33,1,33,'64',65,1),(34,2,34,'21',22,1),(35,2,35,'64',65,1),(36,2,36,'67',68,1),(37,2,37,'65',66,1),(38,2,38,'64',65,1),(39,2,39,'102',103,1),(40,2,40,'64',65,1),(41,2,41,'64',65,1),(42,2,42,'123',124,1),(43,2,43,'65',66,1),(44,2,44,'67',68,1),(45,2,45,'64',65,1),(46,2,46,'49',50,1),(47,2,47,'119',120,1),(48,2,48,'49',50,1),(49,2,49,'0',0,1),(50,2,50,'87',88,1),(51,2,51,'13',14,1),(52,2,52,'0',0,1),(53,2,53,'64',65,1),(54,2,54,'65',66,1),(55,2,55,'0',0,1),(56,2,56,'67',68,1),(57,2,57,'64',65,1),(58,2,58,'0',0,1),(59,2,59,'64',65,1),(60,2,60,'64',65,1),(61,2,61,'0',0,1),(62,2,62,'65',66,1),(63,2,63,'64',65,1),(64,2,64,'0',0,1),(65,2,65,'64',65,1),(66,2,66,'64',65,1),(67,2,67,'0',0,1),(68,2,68,'66',67,1),(69,2,69,'64',65,1),(70,2,70,'0',0,1),(71,2,71,'65',66,1),(72,2,72,'64',65,1),(73,2,73,'0',0,1),(74,2,74,'64',65,1),(75,2,75,'64',65,1),(76,3,76,'65',66,1),(77,3,77,'64',65,1),(78,4,78,'64',65,1),(79,13,79,'64',65,1),(80,13,80,'64',65,1),(81,11,81,'42',43,1),(82,11,82,'87',88,1),(83,11,83,'87',88,1);
/*!40000 ALTER TABLE `edu_plan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edu_plan_competencies`
--

DROP TABLE IF EXISTS `edu_plan_competencies`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `edu_plan_competencies` (
  `id` int NOT NULL AUTO_INCREMENT,
  `edu_plan_id` int NOT NULL,
  `competency_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=194 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edu_plan_competencies`
--

LOCK TABLES `edu_plan_competencies` WRITE;
/*!40000 ALTER TABLE `edu_plan_competencies` DISABLE KEYS */;
INSERT INTO `edu_plan_competencies` VALUES (1,1,5),(2,2,5),(3,3,5),(4,4,7),(5,5,4),(6,6,9),(7,6,11),(8,7,9),(9,7,11),(10,8,1),(11,8,12),(12,9,1),(13,9,11),(14,9,12),(15,10,9),(16,10,11),(17,11,9),(18,11,10),(19,11,11),(20,12,9),(21,12,10),(22,12,11),(23,13,12),(24,14,12),(25,15,9),(26,15,11),(27,16,8),(28,17,1),(29,17,10),(30,18,1),(31,18,12),(32,19,1),(33,19,11),(34,20,5),(35,21,1),(36,21,9),(37,21,11),(38,22,2),(39,23,2),(40,23,12),(41,24,2),(42,24,9),(43,25,2),(44,25,12),(45,26,2),(46,26,10),(47,26,12),(48,27,3),(49,28,6),(50,29,1),(51,29,11),(52,30,1),(53,30,11),(54,31,1),(55,31,9),(56,32,12),(57,33,1),(58,33,12),(59,34,7),(60,35,6),(61,35,15),(62,36,2),(63,36,15),(64,37,6),(65,37,13),(66,38,1),(67,38,13),(68,39,4),(69,39,16),(70,40,1),(71,40,13),(72,41,1),(73,41,14),(74,41,15),(75,42,2),(76,42,13),(77,43,2),(78,43,13),(79,44,1),(80,44,14),(81,44,15),(82,45,1),(83,45,14),(84,46,2),(85,46,3),(86,46,16),(87,47,2),(88,47,3),(89,47,16),(90,48,2),(91,48,3),(92,48,16),(93,49,4),(94,49,16),(95,50,4),(96,50,16),(97,51,4),(98,51,16),(99,52,1),(100,52,15),(101,53,1),(102,53,15),(103,54,1),(104,54,15),(105,55,1),(106,55,15),(107,56,1),(108,56,15),(109,57,1),(110,57,15),(111,58,15),(112,59,15),(113,60,15),(114,61,8),(115,61,15),(116,62,8),(117,62,15),(118,63,8),(119,63,15),(120,64,1),(121,64,14),(122,65,1),(123,65,14),(124,66,1),(125,66,14),(126,67,1),(127,67,15),(128,68,1),(129,68,15),(130,69,1),(131,69,15),(132,70,1),(133,70,15),(134,71,1),(135,71,15),(136,72,1),(137,72,15),(138,73,1),(139,73,14),(140,74,1),(141,74,14),(142,75,1),(143,75,14),(144,76,1),(145,76,9),(146,76,10),(147,76,11),(148,76,12),(149,77,1),(150,77,9),(151,77,10),(152,77,11),(153,77,12),(154,78,1),(155,78,13),(156,78,14),(157,78,15),(158,78,16),(159,79,1),(160,79,2),(161,79,3),(162,79,4),(163,79,5),(164,79,6),(165,79,7),(166,79,8),(167,79,9),(168,79,10),(169,79,11),(170,79,12),(171,79,13),(172,79,14),(173,79,15),(174,79,16),(175,80,1),(176,80,2),(177,80,3),(178,80,4),(179,80,5),(180,80,6),(181,80,7),(182,80,8),(183,80,9),(184,80,10),(185,80,11),(186,80,12),(187,80,13),(188,80,14),(189,80,15),(190,80,16),(191,81,2),(192,82,4),(193,83,4);
/*!40000 ALTER TABLE `edu_plan_competencies` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edu_plan_form_control`
--

DROP TABLE IF EXISTS `edu_plan_form_control`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `edu_plan_form_control` (
  `id` int NOT NULL AUTO_INCREMENT,
  `edu_semester_id` int NOT NULL,
  `form_control_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edu_plan_form_control`
--

LOCK TABLES `edu_plan_form_control` WRITE;
/*!40000 ALTER TABLE `edu_plan_form_control` DISABLE KEYS */;
/*!40000 ALTER TABLE `edu_plan_form_control` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `edu_semesters`
--

DROP TABLE IF EXISTS `edu_semesters`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `edu_semesters` (
  `id` int NOT NULL AUTO_INCREMENT,
  `edu_plan_id` int NOT NULL,
  `semester` int NOT NULL,
  `zed` decimal(10,2) NOT NULL,
  `lecture` int NOT NULL,
  `practice` int NOT NULL,
  `laboratory` int NOT NULL,
  `ind_work` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `edu_semesters`
--

LOCK TABLES `edu_semesters` WRITE;
/*!40000 ALTER TABLE `edu_semesters` DISABLE KEYS */;
INSERT INTO `edu_semesters` VALUES (1,1,1,0.00,18,18,0,36),(2,1,2,0.00,16,16,0,40),(3,2,1,0.00,18,18,0,36),(4,3,1,0.00,0,0,0,0),(5,4,1,0.00,18,0,0,54),(6,5,1,0.00,0,36,0,36),(7,5,2,0.00,0,32,0,49),(8,5,3,0.00,0,36,0,36),(9,5,4,0.00,0,32,0,49),(10,6,1,0.00,36,36,0,45),(11,6,2,0.00,32,32,0,44),(12,6,3,0.00,36,36,0,63),(13,6,4,0.00,32,32,0,62),(14,7,1,0.00,36,36,0,45),(15,7,2,0.00,32,32,0,44),(16,7,3,0.00,36,36,0,63),(17,7,4,0.00,32,32,0,62),(18,8,1,0.00,18,36,0,63),(19,9,1,0.00,36,0,36,45),(20,10,1,0.00,0,0,0,0),(21,11,1,0.00,0,0,72,36),(22,11,2,0.00,0,0,32,40),(23,12,1,0.00,0,0,0,0),(24,13,1,0.00,0,0,0,0),(25,14,1,0.00,0,0,0,0),(26,15,1,0.00,0,0,0,0),(27,16,1,0.00,0,0,0,0),(28,17,1,0.00,0,0,0,0),(29,17,2,0.00,0,0,0,0),(30,18,1,0.00,0,0,0,0),(31,19,1,0.00,0,0,0,0),(32,20,1,0.00,0,0,0,0),(33,21,1,0.00,0,0,0,0),(34,22,1,0.00,0,0,0,0),(35,23,1,0.00,0,0,0,0),(36,24,1,0.00,0,0,0,0),(37,24,2,0.00,0,0,0,0),(38,25,1,0.00,0,0,0,0),(39,25,2,0.00,0,0,0,0),(40,26,1,0.00,0,0,0,0),(41,27,1,0.00,0,0,0,0),(42,27,2,0.00,0,0,0,0),(43,28,1,0.00,0,0,0,0),(44,28,2,0.00,0,0,0,0),(45,29,1,0.00,0,0,0,0),(46,30,1,0.00,0,0,0,0),(47,31,1,0.00,0,0,0,0),(48,32,1,0.00,0,0,0,0),(49,33,1,0.00,0,0,0,0),(50,35,1,0.00,0,0,0,0),(51,36,1,0.00,0,0,0,0),(52,37,1,0.00,0,0,0,0),(53,38,1,0.00,0,0,0,0),(54,39,1,0.00,0,0,0,0),(55,40,1,0.00,0,0,0,0),(56,41,1,0.00,0,0,0,0),(57,42,1,0.00,0,0,0,0),(58,43,1,0.00,0,0,0,0),(59,44,1,0.00,0,0,0,0),(60,45,1,0.00,0,0,0,0),(61,45,2,0.00,0,0,0,0),(62,46,1,0.00,0,0,0,0),(63,47,1,0.00,0,0,0,0),(64,48,1,0.00,0,0,0,0),(65,49,1,0.00,0,36,0,36),(66,50,1,0.00,0,36,0,36),(67,51,1,0.00,0,36,0,36),(68,52,1,0.00,0,0,0,0),(69,52,2,0.00,0,0,0,0),(70,53,1,0.00,0,0,0,0),(71,53,2,0.00,0,0,0,0),(72,54,1,0.00,0,0,0,0),(73,54,2,0.00,0,0,0,0),(74,55,1,0.00,0,0,0,0),(75,56,1,0.00,0,0,0,0),(76,57,1,0.00,0,0,0,0),(77,58,1,0.00,0,0,0,0),(78,59,1,0.00,0,0,0,0),(79,60,1,0.00,0,0,0,0),(80,61,1,0.00,36,36,0,45),(81,62,1,0.00,36,36,0,45),(82,63,1,0.00,36,36,0,45),(83,64,1,0.00,0,0,0,0),(84,65,1,0.00,0,0,0,0),(85,66,1,0.00,0,0,0,0),(86,67,1,0.00,0,0,0,0),(87,68,1,0.00,0,0,0,0),(88,69,1,0.00,0,0,0,0),(89,70,1,0.00,0,0,0,0),(90,71,1,0.00,0,0,0,0),(91,72,1,0.00,0,0,0,0),(92,73,1,0.00,0,0,0,0),(93,74,1,0.00,0,0,0,0),(94,75,1,0.00,0,0,0,0),(95,76,1,0.00,0,0,0,0),(96,76,2,0.00,0,30,0,78),(97,77,1,0.00,0,0,0,0),(98,78,1,0.00,0,0,0,0),(99,79,1,0.00,0,0,0,0),(100,80,1,0.00,0,0,0,0),(101,81,1,0.00,0,0,0,0),(102,82,1,0.00,0,0,0,0),(103,83,1,0.00,0,0,0,0);
/*!40000 ALTER TABLE `edu_semesters` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empl_contracts`
--

DROP TABLE IF EXISTS `empl_contracts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empl_contracts` (
  `id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `date_from` date NOT NULL,
  `date_to` date NOT NULL,
  `number` int NOT NULL,
  `position_id` int NOT NULL,
  `competition` tinyint(1) NOT NULL COMMENT '1-election by competition',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empl_contracts`
--

LOCK TABLES `empl_contracts` WRITE;
/*!40000 ALTER TABLE `empl_contracts` DISABLE KEYS */;
/*!40000 ALTER TABLE `empl_contracts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empl_degrees`
--

DROP TABLE IF EXISTS `empl_degrees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empl_degrees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `spec_id` int NOT NULL,
  `degree_id` int NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empl_degrees`
--

LOCK TABLES `empl_degrees` WRITE;
/*!40000 ALTER TABLE `empl_degrees` DISABLE KEYS */;
/*!40000 ALTER TABLE `empl_degrees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empl_education`
--

DROP TABLE IF EXISTS `empl_education`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empl_education` (
  `id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `edu_level_id` int NOT NULL,
  `speciality` varchar(255) NOT NULL,
  `qualification` varchar(255) NOT NULL,
  `date` date NOT NULL,
  `serial` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empl_education`
--

LOCK TABLES `empl_education` WRITE;
/*!40000 ALTER TABLE `empl_education` DISABLE KEYS */;
/*!40000 ALTER TABLE `empl_education` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empl_loads`
--

DROP TABLE IF EXISTS `empl_loads`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empl_loads` (
  `id` int NOT NULL AUTO_INCREMENT,
  `load_id` int NOT NULL,
  `semester` int NOT NULL,
  `employee_id` int NOT NULL,
  `hourly_fund` tinyint(1) NOT NULL DEFAULT '0',
  `edu_semester_id` int NOT NULL,
  `subject` varchar(255) NOT NULL,
  `group_id` int NOT NULL,
  `subject_form_id` int NOT NULL,
  `hours_other` decimal(10,2) NOT NULL,
  `hours_contact` decimal(10,2) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empl_loads`
--

LOCK TABLES `empl_loads` WRITE;
/*!40000 ALTER TABLE `empl_loads` DISABLE KEYS */;
/*!40000 ALTER TABLE `empl_loads` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empl_prof_education`
--

DROP TABLE IF EXISTS `empl_prof_education`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empl_prof_education` (
  `id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `number` varchar(30) NOT NULL,
  `date` date NOT NULL,
  `doc_type_id` int NOT NULL,
  `title` varchar(200) NOT NULL,
  `n_hours` int NOT NULL,
  `organization` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empl_prof_education`
--

LOCK TABLES `empl_prof_education` WRITE;
/*!40000 ALTER TABLE `empl_prof_education` DISABLE KEYS */;
/*!40000 ALTER TABLE `empl_prof_education` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empl_publications`
--

DROP TABLE IF EXISTS `empl_publications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empl_publications` (
  `id` int NOT NULL AUTO_INCREMENT,
  `empl_id` int NOT NULL,
  `publ_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empl_publications`
--

LOCK TABLES `empl_publications` WRITE;
/*!40000 ALTER TABLE `empl_publications` DISABLE KEYS */;
/*!40000 ALTER TABLE `empl_publications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empl_titles`
--

DROP TABLE IF EXISTS `empl_titles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `empl_titles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `employee_id` int NOT NULL,
  `title_id` int NOT NULL,
  `date` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empl_titles`
--

LOCK TABLES `empl_titles` WRITE;
/*!40000 ALTER TABLE `empl_titles` DISABLE KEYS */;
/*!40000 ALTER TABLE `empl_titles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `surname` varchar(30) NOT NULL,
  `name` varchar(30) NOT NULL,
  `patronimyc` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'Кулаев','Руслан','Черменович'),(2,'Басаева','Елена','Казбековна'),(3,'Джусоева','Нонна','Анатольевна');
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `external_practices`
--

DROP TABLE IF EXISTS `external_practices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `external_practices` (
  `id` int NOT NULL AUTO_INCREMENT,
  `empl_id` int NOT NULL,
  `date_from` date NOT NULL,
  `date_to` date NOT NULL,
  `organization` varchar(255) NOT NULL,
  `position` varchar(255) NOT NULL,
  `education` tinyint(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `external_practices`
--

LOCK TABLES `external_practices` WRITE;
/*!40000 ALTER TABLE `external_practices` DISABLE KEYS */;
/*!40000 ALTER TABLE `external_practices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `faculties`
--

DROP TABLE IF EXISTS `faculties`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `faculties` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `dean_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faculties`
--

LOCK TABLES `faculties` WRITE;
/*!40000 ALTER TABLE `faculties` DISABLE KEYS */;
INSERT INTO `faculties` VALUES (1,'факультет математики и компьютерных наук',1);
/*!40000 ALTER TABLE `faculties` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `form_control`
--

DROP TABLE IF EXISTS `form_control`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `form_control` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `form_control`
--

LOCK TABLES `form_control` WRITE;
/*!40000 ALTER TABLE `form_control` DISABLE KEYS */;
INSERT INTO `form_control` VALUES (1,'Экзамен'),(2,'Зачет'),(3,'Зачет с оц.'),(4,'КР');
/*!40000 ALTER TABLE `form_control` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `groups`
--

DROP TABLE IF EXISTS `groups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `groups` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(30) NOT NULL,
  `galactika_number` int NOT NULL,
  `year` year NOT NULL,
  `speciality_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groups`
--

LOCK TABLES `groups` WRITE;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
/*!40000 ALTER TABLE `groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `loads`
--

DROP TABLE IF EXISTS `loads`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loads` (
  `id` int NOT NULL AUTO_INCREMENT,
  `current_year` year NOT NULL,
  `department_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loads`
--

LOCK TABLES `loads` WRITE;
/*!40000 ALTER TABLE `loads` DISABLE KEYS */;
/*!40000 ALTER TABLE `loads` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order_types`
--

DROP TABLE IF EXISTS `order_types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order_types` (
  `id` int NOT NULL AUTO_INCREMENT,
  `type` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order_types`
--

LOCK TABLES `order_types` WRITE;
/*!40000 ALTER TABLE `order_types` DISABLE KEYS */;
/*!40000 ALTER TABLE `order_types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `number` varchar(30) NOT NULL,
  `title` varchar(255) NOT NULL,
  `order_type_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `positions`
--

DROP TABLE IF EXISTS `positions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `positions` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(30) NOT NULL,
  `level` tinyint(1) NOT NULL COMMENT '1-администрация',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `positions`
--

LOCK TABLES `positions` WRITE;
/*!40000 ALTER TABLE `positions` DISABLE KEYS */;
INSERT INTO `positions` VALUES (1,'декан',1),(2,'заместитель декана',1),(3,'профессор',0),(4,'доцент',0),(5,'секретарь',1),(6,'старший преподаватель',0),(7,'ассистент',0);
/*!40000 ALTER TABLE `positions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prof_doc_types`
--

DROP TABLE IF EXISTS `prof_doc_types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `prof_doc_types` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prof_doc_types`
--

LOCK TABLES `prof_doc_types` WRITE;
/*!40000 ALTER TABLE `prof_doc_types` DISABLE KEYS */;
INSERT INTO `prof_doc_types` VALUES (1,'Диплом о профессиональной переподготовке'),(2,'Удостоверение о повышении квалификации');
/*!40000 ALTER TABLE `prof_doc_types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publ_levels`
--

DROP TABLE IF EXISTS `publ_levels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publ_levels` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publ_levels`
--

LOCK TABLES `publ_levels` WRITE;
/*!40000 ALTER TABLE `publ_levels` DISABLE KEYS */;
INSERT INTO `publ_levels` VALUES (1,'РИНЦ (ядро)'),(2,'РИНЦ'),(3,'Scopus'),(4,'Web of Science'),(5,'ВАК');
/*!40000 ALTER TABLE `publ_levels` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publications`
--

DROP TABLE IF EXISTS `publications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publications` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `DOI` varchar(50) NOT NULL,
  `imprint` text NOT NULL,
  `publ_level_id` int NOT NULL,
  `type` varchar(1) DEFAULT 'A' COMMENT 'A-article, P-posobie',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publications`
--

LOCK TABLES `publications` WRITE;
/*!40000 ALTER TABLE `publications` DISABLE KEYS */;
/*!40000 ALTER TABLE `publications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `schedule`
--

DROP TABLE IF EXISTS `schedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `schedule` (
  `id` int NOT NULL AUTO_INCREMENT,
  `group_id` int NOT NULL,
  `subgroup_num` int NOT NULL,
  `edu_semester_id` int NOT NULL,
  `subject_form_id` int NOT NULL,
  `croom_fund_id` int NOT NULL,
  `employee_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `schedule`
--

LOCK TABLES `schedule` WRITE;
/*!40000 ALTER TABLE `schedule` DISABLE KEYS */;
/*!40000 ALTER TABLE `schedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `speciality`
--

DROP TABLE IF EXISTS `speciality`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `speciality` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(150) NOT NULL,
  `code` varchar(30) NOT NULL,
  `profile` varchar(255) NOT NULL,
  `edu_level_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `speciality`
--

LOCK TABLES `speciality` WRITE;
/*!40000 ALTER TABLE `speciality` DISABLE KEYS */;
INSERT INTO `speciality` VALUES (1,'Математическая логика, алгебра и теория чисел','01.01.06','',4),(2,'Математика','01.03.01','Кибербезопасность',1),(3,'Информатика и вычислительная техника','09.03.01','Информатика и вычислительная техника',1),(4,'Прикладная математика и информатика','01.03.02','Программирование, анализ данных и математическое моделирование',1);
/*!40000 ALTER TABLE `speciality` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stud_orders`
--

DROP TABLE IF EXISTS `stud_orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stud_orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `student_id` int NOT NULL,
  `order_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stud_orders`
--

LOCK TABLES `stud_orders` WRITE;
/*!40000 ALTER TABLE `stud_orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `stud_orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `students` (
  `id` int NOT NULL AUTO_INCREMENT,
  `surname` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `patronymic` varchar(50) NOT NULL,
  `birth_year` year NOT NULL,
  `speciality_id` varchar(100) NOT NULL,
  `date_enter` year NOT NULL,
  `group_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject_forms`
--

DROP TABLE IF EXISTS `subject_forms`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subject_forms` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject_forms`
--

LOCK TABLES `subject_forms` WRITE;
/*!40000 ALTER TABLE `subject_forms` DISABLE KEYS */;
/*!40000 ALTER TABLE `subject_forms` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subjects`
--

DROP TABLE IF EXISTS `subjects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `subjects` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=84 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subjects`
--

LOCK TABLES `subjects` WRITE;
/*!40000 ALTER TABLE `subjects` DISABLE KEYS */;
INSERT INTO `subjects` VALUES (1,'История'),(2,'История России'),(3,'Всеобщая история'),(4,'Физическая культура и спорт'),(5,'Иностранный язык'),(6,'Алгебра'),(7,'Математический анализ'),(8,'Основы аппаратного и программного обеспечения ПК'),(9,'Основы программирования'),(10,'Аналитическая геометрия'),(11,'Элементарная математика'),(12,'Дискретная математика'),(13,'Вычислительные сети (CISCO)'),(14,'Методы программирования'),(15,'Теория чисел'),(16,'Безопасность жизнедеятельности'),(17,'Теория вероятностей и математическая статистика'),(18,'Основы сетевых технологий (CISCO)'),(19,'Дифференциальные уравнения (разностные схемы)'),(20,'Философия'),(21,'Функциональный анализ'),(22,'Организационно-правовое обеспечение информационной безопасности'),(23,'Защита в операционных системах'),(24,'Теория кодирования'),(25,'Администрирование операционных систем'),(26,'Численные методы'),(27,'Психология'),(28,'Педагогика'),(29,'Методика преподавания математики'),(30,'Методика преподавания информатики'),(31,'Уравнения математической физики'),(32,'Методы криптоанализа'),(33,'Программирование на Python'),(34,'Элективные дисциплины по физической культуре и спорту'),(35,'Научный семинар'),(36,'Методы оптимизации'),(37,'Управление программным проектом'),(38,'Технические средства и методы защиты информации'),(39,'Технический перевод'),(40,'Кибербезопасность и интернет-вещей'),(41,'Введение в криптографию'),(42,'Банковское дело'),(43,'Безопасность сетей (CISCO Security)'),(44,'Математическое моделирование'),(45,'Web разработка'),(46,'Коммуникативные практики в профессиональной деятельности'),(47,'Основы специальной психологии'),(48,'Обучение детей с особыми потребностями'),(49,'Дисциплины по выбору Б1.В.ДВ.1'),(50,'Осетинский язык'),(51,'Русский язык и культура речи'),(52,'Дисциплины по выбору Б1.В.ДВ.2'),(53,'История математики'),(54,'Комплексные системы защиты информации (ЭЦП, каналы связи)'),(55,'Дисциплины по выбору Б1.В.ДВ.3'),(56,'Вариационное исчисление и методы оптимизации'),(57,'Коды, исправляющие ошибки'),(58,'Дисциплины по выбору Б1.В.ДВ.4'),(59,'Группы, кольца и теоретико-числовые основы в криптографии'),(60,'Конечно-автоматные криптосистемы'),(61,'Дисциплины по выбору Б1.В.ДВ.5'),(62,'Математические методы в экономике'),(63,'Схемотехника'),(64,'Дисциплины по выбору Б1.В.ДВ.6'),(65,'Информационные технологии'),(66,'Квантовые вычисления'),(67,'Дисциплины по выбору Б1.В.ДВ.7'),(68,'Частные методики'),(69,'Группы, кольца, алгоритмы и математическое обоснование RSA'),(70,'Дисциплины по выбору Б1.В.ДВ.8'),(71,'Методика, история и перспективы развития прикладной математики'),(72,'Разделение секрета'),(73,'Дисциплины по выбору Б1.В.ДВ.9'),(74,'Пакеты символьной математики'),(75,'Современные языки программирования'),(76,'Учебная практика (Научно-исследовательская работа (получение первичных навыков научно-исследовательской работы))'),(77,'Производственная практика (Научно-исследовательская работа)'),(78,'Преддипломная практика'),(79,'Подготовка к сдаче и сдача государственного экзамена'),(80,'Выполнение и защита выпускной квалификационной работы'),(81,'Закон об образовании'),(82,'Осетинский язык и культура речи'),(83,'Осетинский язык (базовый курс)');
/*!40000 ALTER TABLE `subjects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thesis_work`
--

DROP TABLE IF EXISTS `thesis_work`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thesis_work` (
  `id` int NOT NULL AUTO_INCREMENT,
  `current_year` year NOT NULL,
  `semester` int NOT NULL,
  `student_id` int NOT NULL,
  `employee_id` int NOT NULL,
  `title` varchar(255) NOT NULL,
  `thesis_work_type_id` int NOT NULL,
  `mark` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thesis_work`
--

LOCK TABLES `thesis_work` WRITE;
/*!40000 ALTER TABLE `thesis_work` DISABLE KEYS */;
/*!40000 ALTER TABLE `thesis_work` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thesis_work_type`
--

DROP TABLE IF EXISTS `thesis_work_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thesis_work_type` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thesis_work_type`
--

LOCK TABLES `thesis_work_type` WRITE;
/*!40000 ALTER TABLE `thesis_work_type` DISABLE KEYS */;
/*!40000 ALTER TABLE `thesis_work_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `title_plan`
--

DROP TABLE IF EXISTS `title_plan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `title_plan` (
  `id` int NOT NULL AUTO_INCREMENT,
  `spec_id` int NOT NULL,
  `profile` varchar(255) NOT NULL,
  `date_uchsovet` date NOT NULL,
  `number_uchsovet` int NOT NULL,
  `current_year` year NOT NULL,
  `date_enter` year NOT NULL,
  `date_fgos` date NOT NULL,
  `number_fgos` int NOT NULL,
  `department_id` int NOT NULL,
  `included` varchar(1) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `title_plan`
--

LOCK TABLES `title_plan` WRITE;
/*!40000 ALTER TABLE `title_plan` DISABLE KEYS */;
INSERT INTO `title_plan` VALUES (1,2,'Профиль \"Кибербезопасность\"','2020-04-30',9,2023,2020,'2018-01-10',8,65,'1');
/*!40000 ALTER TABLE `title_plan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `titles`
--

DROP TABLE IF EXISTS `titles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `titles` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=cp1251;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `titles`
--

LOCK TABLES `titles` WRITE;
/*!40000 ALTER TABLE `titles` DISABLE KEYS */;
INSERT INTO `titles` VALUES (1,'доцент'),(2,'профессор');
/*!40000 ALTER TABLE `titles` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-27 19:34:58
