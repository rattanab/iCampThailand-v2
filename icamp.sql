-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 14, 2017 at 05:04 PM
-- Server version: 10.1.24-MariaDB
-- PHP Version: 7.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `icamp`
--

-- --------------------------------------------------------

--
-- Table structure for table `activity`
--

CREATE TABLE `activity` (
  `ActivityID` int(11) NOT NULL,
  `ActivityName` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `activity`
--

INSERT INTO `activity` (`ActivityID`, `ActivityName`) VALUES
(1, 'Archery'),
(2, 'Boxing'),
(3, 'Gaga Game'),
(4, 'Horse Riding'),
(5, 'Tennis'),
(6, 'Swimming'),
(7, 'Waterpark'),
(8, 'Adventure Park'),
(9, 'Flag Football'),
(10, 'Basketball'),
(11, 'Beach Volleyball'),
(12, 'Painting'),
(13, 'Fashion Design'),
(14, 'Sculpture'),
(15, 'Print-Making'),
(16, 'Weaving'),
(17, 'Creative Writing'),
(18, 'Puppetry');

-- --------------------------------------------------------

--
-- Table structure for table `activity_availability`
--

CREATE TABLE `activity_availability` (
  `date` date NOT NULL,
  `timeslot` int(11) NOT NULL,
  `activity_name` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `activity_availability`
--

INSERT INTO `activity_availability` (`date`, `timeslot`, `activity_name`) VALUES
('2017-10-02', 1, 'Basketball'),
('2017-10-02', 1, 'Flag Football'),
('2017-10-02', 1, 'Tennis'),
('2017-10-02', 2, 'Sculpture'),
('2017-10-02', 2, 'Swimming'),
('2017-10-02', 2, 'Waterpark'),
('2017-10-02', 3, 'Archery'),
('2017-10-02', 3, 'Painting'),
('2017-10-02', 3, 'Print-Making'),
('2017-10-02', 4, 'Beach Volleyball'),
('2017-10-02', 4, 'Boxing'),
('2017-10-02', 4, 'Horse Riding'),
('2017-10-02', 5, 'Fashion Design'),
('2017-10-02', 5, 'Puppetry'),
('2017-10-02', 5, 'Weaving');

-- --------------------------------------------------------

--
-- Table structure for table `activity_selection`
--

CREATE TABLE `activity_selection` (
  `CamperID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `SubjectNum` int(11) NOT NULL,
  `Activity` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `activity_selection`
--

INSERT INTO `activity_selection` (`CamperID`, `Date`, `SubjectNum`, `Activity`) VALUES
(2, '2017-10-02', 1, 'Basketball'),
(2, '2017-10-02', 2, 'Waterpark'),
(2, '2017-10-02', 3, 'Archery'),
(2, '2017-10-02', 4, 'Beach Volleyball'),
(2, '2017-10-02', 5, 'Weaving');

-- --------------------------------------------------------

--
-- Table structure for table `camper`
--

CREATE TABLE `camper` (
  `CamperID` int(11) NOT NULL,
  `CamperName` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `CamperNickName` varchar(40) COLLATE utf8mb4_unicode_ci NOT NULL,
  `Bunk` int(11) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Nationality` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `EndDate` date DEFAULT NULL,
  `MedicalNeed` text COLLATE utf8mb4_unicode_ci,
  `DietNeed` text COLLATE utf8mb4_unicode_ci,
  `Transport` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PG1Name` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PG1Contact` int(11) DEFAULT NULL,
  `PG1Email` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PG2Name` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `PG2Contact` int(11) DEFAULT NULL,
  `PG2Email` varchar(40) COLLATE utf8mb4_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `camper`
--

INSERT INTO `camper` (`CamperID`, `CamperName`, `CamperNickName`, `Bunk`, `Age`, `Nationality`, `StartDate`, `EndDate`, `MedicalNeed`, `DietNeed`, `Transport`, `PG1Name`, `PG1Contact`, `PG1Email`, `PG2Name`, `PG2Contact`, `PG2Email`) VALUES
(1, 'Ross', 'Ross', 2, 25, 'English', '2017-09-30', '2017-10-06', 'NA', 'NA', 'Bus', 'George', 812345678, 'dad@mail.com', 'Jane', 86543210, 'mum@mail.com'),
(2, 'Rattana', 'Tee', 1, 21, 'Thai', '2017-09-30', '2017-10-06', 'Dust Allery', 'No spicy food', 'Public', 'Dad', 832221111, 'System.Windows.Forms.TextBox, Text: dad@', 'Mum', 901112222, 'mum@mail.com'),
(3, 'Camper3', 'Tee', 1, 21, 'Thai', '2017-09-30', '2017-10-06', 'Dust Allery', 'No spicy food', 'Public', 'Dad', 832221111, 'System.Windows.Forms.TextBox, Text: dad@', 'Mum', 901112222, 'mum@mail.com');

-- --------------------------------------------------------

--
-- Table structure for table `camp_session`
--

CREATE TABLE `camp_session` (
  `SessionID` int(11) NOT NULL,
  `SessionName` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `SessionDateStart` date NOT NULL,
  `SessionDateEnd` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `camp_session`
--

INSERT INTO `camp_session` (`SessionID`, `SessionName`, `SessionDateStart`, `SessionDateEnd`) VALUES
(1, 'Session 1', '2017-09-30', '2017-10-06'),
(2, 'Session 2', '2017-10-07', '2017-10-13'),
(3, 'Session 3', '2017-10-14', '2017-10-20'),
(4, 'Session 4', '2017-10-23', '2017-10-29');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activity`
--
ALTER TABLE `activity`
  ADD PRIMARY KEY (`ActivityID`);

--
-- Indexes for table `activity_availability`
--
ALTER TABLE `activity_availability`
  ADD PRIMARY KEY (`date`,`timeslot`,`activity_name`);

--
-- Indexes for table `activity_selection`
--
ALTER TABLE `activity_selection`
  ADD PRIMARY KEY (`CamperID`,`Date`,`SubjectNum`,`Activity`);

--
-- Indexes for table `camper`
--
ALTER TABLE `camper`
  ADD PRIMARY KEY (`CamperID`);

--
-- Indexes for table `camp_session`
--
ALTER TABLE `camp_session`
  ADD PRIMARY KEY (`SessionID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activity`
--
ALTER TABLE `activity`
  MODIFY `ActivityID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `camper`
--
ALTER TABLE `camper`
  MODIFY `CamperID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `camp_session`
--
ALTER TABLE `camp_session`
  MODIFY `SessionID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `activity_selection`
--
ALTER TABLE `activity_selection`
  ADD CONSTRAINT `activity_selection_ibfk_1` FOREIGN KEY (`CamperID`) REFERENCES `camper` (`CamperID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
