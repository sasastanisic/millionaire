-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.32 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for quiz_millionaire
CREATE DATABASE IF NOT EXISTS `quiz_millionaire` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `quiz_millionaire`;

-- Dumping structure for table quiz_millionaire.answer
CREATE TABLE IF NOT EXISTS `answer` (
  `id` int NOT NULL AUTO_INCREMENT,
  `text` text NOT NULL,
  `correctAnswer` tinyint NOT NULL,
  `questionId` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_question` (`questionId`),
  CONSTRAINT `fk_question` FOREIGN KEY (`questionId`) REFERENCES `question` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=113 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table quiz_millionaire.answer: ~112 rows (approximately)
/*!40000 ALTER TABLE `answer` DISABLE KEYS */;
INSERT INTO `answer` (`id`, `text`, `correctAnswer`, `questionId`) VALUES
	(1, 'Marlon Brando', 0, 1),
	(2, 'Al Pacino', 0, 1),
	(3, 'Leonardo DiCaprio', 1, 1),
	(4, 'Sean Connery', 0, 1),
	(5, 'LeBron James', 0, 2),
	(6, 'Giannis Antetokounmpo', 1, 2),
	(7, 'Stephen Curry', 0, 2),
	(8, 'Nikola Jokic', 0, 2),
	(9, '1953', 1, 3),
	(10, '1950', 0, 3),
	(11, '1961', 0, 3),
	(12, '1974', 0, 3),
	(13, 'Heart', 0, 4),
	(14, 'Skin', 1, 4),
	(15, 'Kidney', 0, 4),
	(16, 'Liver', 0, 4),
	(17, 'Serbia and Bulgaria', 0, 5),
	(18, 'Chile and Argentina', 0, 5),
	(19, 'Canada and the USA', 1, 5),
	(20, 'China and Russia', 0, 5),
	(21, 'Cat', 0, 6),
	(22, 'Mouse', 0, 6),
	(23, 'Horse', 1, 6),
	(24, 'Dolphin', 0, 6),
	(25, 'Magnesium', 0, 7),
	(26, 'Calcium', 1, 7),
	(27, 'Lithium', 0, 7),
	(28, 'Natrium', 0, 7),
	(29, 'LeBron James', 1, 8),
	(30, 'Kevin Durant', 0, 8),
	(31, 'John Wall', 0, 8),
	(32, 'James Harden', 0, 8),
	(33, 'Friends', 0, 9),
	(34, 'Game of Thrones', 1, 9),
	(35, 'La casa de papel', 0, 9),
	(36, 'Lucifer', 0, 9),
	(37, 'Asia', 1, 10),
	(38, 'Europe', 0, 10),
	(39, 'Africa', 0, 10),
	(40, 'South America', 0, 10),
	(41, 'Seoul', 0, 11),
	(42, 'Beijing', 0, 11),
	(43, 'Bangkok', 0, 11),
	(44, 'Tokyo', 1, 11),
	(45, 'Quentin Tarantino', 0, 12),
	(46, 'Christopher Nolan', 1, 12),
	(47, 'Steven Spielberg', 0, 12),
	(48, 'Martin Scorsese', 0, 12),
	(49, '250', 0, 13),
	(50, '150', 0, 13),
	(51, '206', 1, 13),
	(52, '182', 0, 13),
	(53, 'Toyota', 0, 14),
	(54, 'Tesla', 1, 14),
	(55, 'Honda', 0, 14),
	(56, 'Ford', 0, 14),
	(57, 'Italy', 1, 15),
	(58, 'Germany', 0, 15),
	(59, 'Brazil', 0, 15),
	(60, 'France', 0, 15),
	(61, 'Remco Evenepoel', 0, 16),
	(62, 'Jonas Vingegaard', 0, 16),
	(63, 'Tadej Pogacar', 1, 16),
	(64, 'Primoz Roglic', 0, 16),
	(65, 'Mitochondria', 1, 17),
	(66, 'Endoplasmic Reticulum', 0, 17),
	(67, 'Nucleus', 0, 17),
	(68, 'Ribosome', 0, 17),
	(69, 'Mississippi', 0, 18),
	(70, 'Yangtze', 0, 18),
	(71, 'Amazon', 0, 18),
	(72, 'Nile', 1, 18),
	(73, 'BMW', 0, 19),
	(74, 'Audi', 1, 19),
	(75, 'Mercedes Benz', 0, 19),
	(76, 'Toyota', 0, 19),
	(77, '1990', 0, 20),
	(78, '1985', 0, 20),
	(79, '1977', 1, 20),
	(80, '2001', 0, 20),
	(81, 'USA', 0, 21),
	(82, 'China', 1, 21),
	(83, 'Brazil', 0, 21),
	(84, 'Russia', 0, 21),
	(85, 'Anthony Hopkins', 1, 22),
	(86, 'Gary Oldman', 0, 22),
	(87, 'Chadwick Boseman', 0, 22),
	(88, 'Riz Ahmed', 0, 22),
	(89, '38.3°C', 0, 23),
	(90, '39.2°C', 0, 23),
	(91, '37°C', 1, 23),
	(92, '34°C', 0, 23),
	(93, 'Toyota', 0, 24),
	(94, 'Honda', 0, 24),
	(95, 'Chevrolet', 0, 24),
	(96, 'Ford', 1, 24),
	(97, 'Paris', 1, 25),
	(98, 'Rome', 0, 25),
	(99, 'London', 0, 25),
	(100, 'Berlin', 0, 25),
	(101, '4', 0, 26),
	(102, '3', 1, 26),
	(103, '2', 0, 26),
	(104, '5', 0, 26),
	(105, 'Michael Jordan', 0, 27),
	(106, 'Kareem Abdul-Jabbar', 0, 27),
	(107, 'LeBron James', 1, 27),
	(108, 'Kobe Bryant', 0, 27),
	(109, 'Melbourne', 0, 28),
	(110, 'Perth', 0, 28),
	(111, 'Sydney', 0, 28),
	(112, 'Canberra', 1, 28);
/*!40000 ALTER TABLE `answer` ENABLE KEYS */;

-- Dumping structure for table quiz_millionaire.question
CREATE TABLE IF NOT EXISTS `question` (
  `id` int NOT NULL AUTO_INCREMENT,
  `text` text NOT NULL,
  `difficulty` int NOT NULL,
  `area` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table quiz_millionaire.question: ~3 rows (approximately)
/*!40000 ALTER TABLE `question` DISABLE KEYS */;
INSERT INTO `question` (`id`, `text`, `difficulty`, `area`) VALUES
	(1, 'What was the name of the actor who played Jack Dawson in Titanic?', 2, 'Movies'),
	(2, 'Who won NBA MVP award in 2020?', 3, 'Sports'),
	(3, 'In what year was the Chevrolet Corvette introduced?', 4, 'Cars'),
	(4, 'Which is the largest organ in human body?', 2, 'Health'),
	(5, 'Which two countries share the longest international border?', 4, 'Geography'),
	(6, 'Which animal can be seen on the Porsche logo?', 2, 'Cars'),
	(7, 'Which element is said to keep bones strong?', 1, 'Health'),
	(8, 'Who is the GOAT in basketball?', 4, 'Sports'),
	(9, 'Which popular TV show featured house Targaryen and Stark?', 3, 'Movies'),
	(10, 'Which continent is the largest?', 1, 'Geography'),
	(11, 'What is the capital of Japan?', 1, 'Geography'),
	(12, 'Who directed the movie "Inception"?', 4, 'Movies'),
	(13, 'How many bones are in human body?', 3, 'Health'),
	(14, 'Which company produces Tesla electric car?', 2, 'Cars'),
	(15, 'What country won the FIFA World Cup in 2006?', 3, 'Sports'),
	(16, 'Who is the winner of Le Tour de France in 2021?', 3, 'Sports'),
	(17, 'What is the powerhouse of cell?', 2, 'Health'),
	(18, 'Which river is longest in the world?', 1, 'Geography'),
	(19, 'Which car brand has a logo with four interlocked rings?', 1, 'Cars'),
	(20, 'In what year was the first Star Wars movie released?', 4, 'Movies'),
	(21, 'Which country hosted the 2008 Summer Olympics?', 3, 'Sports'),
	(22, 'Who won the Academy Award for Best Actor in 2021?', 4, 'Movies'),
	(23, 'What is the average body temperature of a human?', 2, 'Health'),
	(24, 'Which car brand produces the model "Mustang"?', 3, 'Cars'),
	(25, 'What is the capital city of France?', 1, 'Geography'),
	(26, 'How many parts are there in the "Rush Hour" movie series?', 1, 'Movies'),
	(27, 'Who is the all-time leading scorer in the NBA?', 4, 'Sports'),
	(28, 'What is the capital city of Australia?', 2, 'Geography');
/*!40000 ALTER TABLE `question` ENABLE KEYS */;

-- Dumping structure for table quiz_millionaire.quiz
CREATE TABLE IF NOT EXISTS `quiz` (
  `id` int NOT NULL AUTO_INCREMENT,
  `player` varchar(50) NOT NULL,
  `correctAnswers` int NOT NULL,
  `prize` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Dumping data for table quiz_millionaire.quiz: ~0 rows (approximately)
/*!40000 ALTER TABLE `quiz` DISABLE KEYS */;
/*!40000 ALTER TABLE `quiz` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
