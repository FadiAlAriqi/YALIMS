-- phpMyAdmin SQL Dump
-- version 6.0.0-dev+20230921.a50645ef7f
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 28, 2023 at 02:21 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `yalims`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin_users`
--

CREATE TABLE `admin_users` (
  `ID` int(5) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Mobile` int(9) NOT NULL,
  `Status` int(1) NOT NULL,
  `Email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `admin_users`
--

INSERT INTO `admin_users` (`ID`, `Username`, `Password`, `Mobile`, `Status`, `Email`) VALUES
(7, 'osama', '123', 777555333, 1, 'osamarbg@gmail.com'),
(10, 'fadi', 'fadi_sharedlock', 775862002, 0, 'fadi@shared.lock'),
(11, 'ahmed', '55511122288', 771442553, 1, 'ahmed@zeft.com'),
(12, 'jkgdf', 'trhrdgsd', 775888222, 0, 'fljg@gf.hgf');

-- --------------------------------------------------------

--
-- Table structure for table `courses`
--

CREATE TABLE `courses` (
  `ID` int(3) NOT NULL,
  `CourseName` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `courses`
--

INSERT INTO `courses` (`ID`, `CourseName`) VALUES
(1, 'Reading Course'),
(2, 'Writing Course'),
(3, 'Listening Course');

-- --------------------------------------------------------

--
-- Table structure for table `marks`
--

CREATE TABLE `marks` (
  `ID` int(11) NOT NULL,
  `Student_ID` int(5) NOT NULL,
  `CourseType` int(3) NOT NULL,
  `CourseLevel` varchar(5) NOT NULL,
  `Mark` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `marks`
--

INSERT INTO `marks` (`ID`, `Student_ID`, `CourseType`, `CourseLevel`, `Mark`) VALUES
(8, 10, 2, '2', 45),
(12, 11, 1, '2', 15);

-- --------------------------------------------------------

--
-- Table structure for table `student_inf`
--

CREATE TABLE `student_inf` (
  `Id` int(5) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Phone` int(15) NOT NULL,
  `Birthdate` date NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `CourseType` int(3) NOT NULL,
  `Level` int(5) NOT NULL,
  `Time` time NOT NULL,
  `img` varchar(255) NOT NULL,
  `Status` int(1) NOT NULL,
  `teacher` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `student_inf`
--

INSERT INTO `student_inf` (`Id`, `Name`, `Email`, `Phone`, `Birthdate`, `Username`, `Password`, `CourseType`, `Level`, `Time`, `img`, `Status`, `teacher`) VALUES
(2, 'Khalid', 'Khalid@gmail.com', 775111207, '2022-07-20', 'prince', 'ad/Q1kEzYgbjU', 2, 0, '08:30:00', 'WhatsApp Image 2022-06-17 at 7.53.57 PM.jpeg', 0, 3),
(5, 'Fadi Alariqi', 'Fadi@gmail.com', 735111207, '2022-11-16', 'fadi', 'f9R5TP7kt6Fko', 3, 0, '04:30:00', 'pexels-rodnae-productions-7713511.jpg', 1, 2),
(6, 'ahmedd', 'ahmedalshahe000thi04@gmail.com', 771142480, '0000-00-00', 'ahmeddd', '20CKlb72gRt4E', 1, 0, '08:30:00', 'تصميم بدون عنوان.png', 0, 3),
(7, 'osama', 'osama@gmail.com', 774725751, '2022-11-09', 'osama', '1234567', 2, 2, '08:30:00', '', 1, 3),
(10, 'sacsscsd', 'osamkdsa@gmail.com', 775588665, '2022-08-15', 'osamsdsas', '123456789', 1, 2, '08:30:00', '', 0, 2),
(11, 'ahmedali', 'ahmedali@gmail.com', 775877350, '2022-11-09', 'hamada', '7cjGai2lpGNfQ', 1, 2, '08:30:00', '', 0, 3),
(13, 'fdfd', 'dfd@gmail.com', 775778557, '2022-11-09', 'fdfd', '64o8bNRrSeaSw', 1, 2, '12:30:00', '', 1, 3),
(14, 'fvdfv', 'fdv@gmail.com', 772775779, '2022-11-09', 'fvdfvfd', '4ce66UiCR7hTg', 2, 2, '08:30:00', '', 0, 2),
(15, 'test', 'sd@gmail.com', 777277577, '2022-11-09', 'cdsd', '02aooLB2fdJWo', 2, 2, '08:30:00', '', 0, 2),
(19, 'princeoi', 'princeoikkk@gml.kjo', 778555422, '2022-11-09', 'Khalid', '7cvbD2x6dg2Gg', 1, 5, '08:30:00', '', 0, NULL),
(20, 'gasmoli', 'gasmoly@gmail.com', 777888999, '2022-11-09', 'gasm', 'f7ear8l/CJ4Rw', 2, 5, '08:30:00', '', 0, NULL),
(22, 'Ahmed Alshahethi', 'ahmed@ifdj.gf', 778554625, '2001-05-22', 'ahmedshah', '123456789', 1, 8, '08:30:00', '', 0, NULL),
(23, 'hjfg hf', 'nhgfdfs@gkj.gf', 777888555, '2004-07-27', 'hgjgf', 'yfdfgdgc', 1, 8, '12:30:00', '', 0, NULL),
(24, 'hgkj kjku', 'kjhkj@fgf.fg', 778444225, '2020-06-23', 'jgfhdg', 'dhf&#039;t;k;fsdf', 1, 8, '08:30:00', '', 0, NULL),
(25, 'hfgf dffgd', 'hgd@fgg.hfg', 774885226, '2004-11-17', 'lhghfh', 'hdfeujykjfgc', 1, 8, '08:30:00', '', 0, NULL),
(26, 'gfkhd gfkj', 'hdgdssd@hdfgd.fgf', 774555233, '2020-02-17', 'yjfghfg', 'rujgkhfkjglj', 2, 7, '08:30:00', '', 0, NULL),
(27, 'gfkhd gfkj', 'hdgdsjfhdfsd@hdfgd.fgf', 778855221, '2020-02-17', 'ytrfgdfh', 'rujgkhfkjglj', 3, 5, '10:30:00', '', 0, NULL),
(28, 'jhgjg fghf', 'hfgdsf@hf.gfg', 775111256, '2004-06-15', 'ghjhfd', 'itijs;gkhfds', 1, 5, '08:30:00', '', 0, NULL),
(29, 'hrt htr', 'htdf@hdg.htf', 778844455, '2000-06-12', 'hfghfdgfd', 'hdfgsgheg', 1, 5, '08:30:00', '', 0, NULL),
(30, 'kghjf fghrt', 'sgfghf@ftj.hft', 777444666, '2022-03-01', 'lukfjdhr', 'gejfhjdfhdj', 1, 7, '08:30:00', '', 0, NULL),
(31, 'kghjf fghrt', 'sgfgdfghf@ftj.hft', 777554666, '2022-03-01', 'lukfjdhrjtdfg', 'gejfhjdfhdj', 2, 5, '08:30:00', '', 0, NULL),
(32, 'jfh trhfgxdx', 'exedx@jfhf.hg', 775111248, '2020-01-27', 'hjghkjgfg', 'duxytsjyjedx', 1, 3, '08:30:00', '', 0, NULL),
(33, 'kfjdfsah tgxdx', 'exhhfgfx@jfhf.hg', 775151248, '2020-01-27', 'hjghfg', 'duxytsjyjedx', 2, 5, '12:30:00', '', 0, NULL),
(34, 'hfghfg nfg', 'thdflkj@gkhfj.jg', 775111222, '2004-10-05', 'lugjfhghkhyg', 'gsdfhksgdkj', 1, 7, '08:30:00', '', 0, NULL),
(35, 'hfghfg nfg', 'thghgfdflkj@gkhfj.jg', 775111333, '2004-10-05', 'lugjffgj55khyg', 'gsdfhksgdkj', 1, 7, '08:30:00', '', 0, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `teachers`
--

CREATE TABLE `teachers` (
  `ID` int(5) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Mobile` int(9) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Salary` decimal(10,0) NOT NULL,
  `Status` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `teachers`
--

INSERT INTO `teachers` (`ID`, `Username`, `Password`, `Mobile`, `Name`, `Email`, `Salary`, `Status`) VALUES
(2, 'kream', 'f7ear8l/CJ4Rw', 771122480, 'kream Alnozily', 'kream@gmail.com', 60000, 1),
(3, 'osama2', '1234567', 774222355, 'osama arbaji', 'jgffdf@hff.fgd', 50000, 0),
(5, 'montather', 'e369EpTHFvtFk', 779844522, 'montather', 'clickright@query.sql', 120000, 1);

-- --------------------------------------------------------

--
-- Table structure for table `teachs`
--

CREATE TABLE `teachs` (
  `ID` int(5) NOT NULL,
  `teacher` int(5) NOT NULL,
  `course` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin_users`
--
ALTER TABLE `admin_users`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD UNIQUE KEY `Mobile` (`Mobile`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD UNIQUE KEY `Username_2` (`Username`);

--
-- Indexes for table `courses`
--
ALTER TABLE `courses`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `marks`
--
ALTER TABLE `marks`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `StudentMarkeKey` (`Student_ID`),
  ADD KEY `coursesk` (`CourseType`);

--
-- Indexes for table `student_inf`
--
ALTER TABLE `student_inf`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD UNIQUE KEY `Phone` (`Phone`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD UNIQUE KEY `Username_2` (`Username`),
  ADD KEY `CourseTypeKey` (`CourseType`),
  ADD KEY `teacherfk` (`teacher`);

--
-- Indexes for table `teachers`
--
ALTER TABLE `teachers`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Username` (`Username`),
  ADD UNIQUE KEY `Mobile` (`Mobile`),
  ADD UNIQUE KEY `Email` (`Email`),
  ADD UNIQUE KEY `Username_2` (`Username`);

--
-- Indexes for table `teachs`
--
ALTER TABLE `teachs`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `teacher_teach` (`teacher`),
  ADD KEY `teacher_course` (`course`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin_users`
--
ALTER TABLE `admin_users`
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `courses`
--
ALTER TABLE `courses`
  MODIFY `ID` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `marks`
--
ALTER TABLE `marks`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `student_inf`
--
ALTER TABLE `student_inf`
  MODIFY `Id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `teachers`
--
ALTER TABLE `teachers`
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `teachs`
--
ALTER TABLE `teachs`
  MODIFY `ID` int(5) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `marks`
--
ALTER TABLE `marks`
  ADD CONSTRAINT `StudentMarkeKey` FOREIGN KEY (`Student_ID`) REFERENCES `student_inf` (`Id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `coursesk` FOREIGN KEY (`CourseType`) REFERENCES `courses` (`ID`) ON UPDATE CASCADE;

--
-- Constraints for table `student_inf`
--
ALTER TABLE `student_inf`
  ADD CONSTRAINT `teacherfk` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`ID`) ON UPDATE CASCADE;

--
-- Constraints for table `teachs`
--
ALTER TABLE `teachs`
  ADD CONSTRAINT `teacher_teach` FOREIGN KEY (`teacher`) REFERENCES `teachers` (`ID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
