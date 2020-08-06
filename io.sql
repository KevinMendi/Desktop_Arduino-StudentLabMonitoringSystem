-- phpMyAdmin SQL Dump
-- version 4.1.6
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 19, 2017 at 01:46 AM
-- Server version: 5.6.16
-- PHP Version: 5.5.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `io`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE IF NOT EXISTS `login` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `studentid` varchar(10) NOT NULL,
  `tblsbjctid` varchar(50) NOT NULL,
  `timeIn` varchar(50) NOT NULL,
  `dateIn` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`id`, `studentid`, `tblsbjctid`, `timeIn`, `dateIn`) VALUES
(1, '1001', '1234', '12:14 PM', '18/03/2017');

-- --------------------------------------------------------

--
-- Table structure for table `logout`
--

CREATE TABLE IF NOT EXISTS `logout` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `studentid` varchar(10) NOT NULL,
  `tblsbjctid` varchar(50) NOT NULL,
  `timeOut` varchar(50) NOT NULL,
  `dateOut` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `mst_course`
--

CREATE TABLE IF NOT EXISTS `mst_course` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `course` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `mst_course`
--

INSERT INTO `mst_course` (`id`, `course`) VALUES
(1, 'BS CPE'),
(2, 'EDP 11');

-- --------------------------------------------------------

--
-- Table structure for table `mst_student`
--

CREATE TABLE IF NOT EXISTS `mst_student` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `rfid` varchar(50) NOT NULL,
  `idno` int(5) NOT NULL,
  `name` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `course` varchar(50) NOT NULL,
  `year` varchar(50) NOT NULL,
  `photo` longblob NOT NULL,
  `tag` varchar(5) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `mst_student`
--

INSERT INTO `mst_student` (`id`, `rfid`, `idno`, `name`, `gender`, `course`, `year`, `photo`, `tag`) VALUES
(1, '542C2C5', 1001, 'INA', 'Female', 'BS CPE', '5TH', 0xffd8ffe000104a46494600010101006000600000ffe1005a4578696600004d4d002a00000008000503010005000000010000004a030300010000000100000000511000010000000101000000511100040000000100000ec3511200040000000100000ec300000000000186a00000b18fffdb004300080606070605080707070909080a0c140d0c0b0b0c1912130f141d1a1f1e1d1a1c1c20242e2720222c231c1c2837292c30313434341f27393d38323c2e333432ffdb0043010909090c0b0c180d0d1832211c213232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232323232ffc0001108004c004c03012200021101031101ffc4001f0000010501010101010100000000000000000102030405060708090a0bffc400b5100002010303020403050504040000017d01020300041105122131410613516107227114328191a1082342b1c11552d1f02433627282090a161718191a25262728292a3435363738393a434445464748494a535455565758595a636465666768696a737475767778797a838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae1e2e3e4e5e6e7e8e9eaf1f2f3f4f5f6f7f8f9faffc4001f0100030101010101010101010000000000000102030405060708090a0bffc400b51100020102040403040705040400010277000102031104052131061241510761711322328108144291a1b1c109233352f0156272d10a162434e125f11718191a262728292a35363738393a434445464748494a535455565758595a636465666768696a737475767778797a82838485868788898a92939495969798999aa2a3a4a5a6a7a8a9aab2b3b4b5b6b7b8b9bac2c3c4c5c6c7c8c9cad2d3d4d5d6d7d8d9dae2e3e4e5e6e7e8e9eaf2f3f4f5f6f7f8f9faffda000c03010002110311003f00f9fe8a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a0028a28a00fffd9, '0');

-- --------------------------------------------------------

--
-- Table structure for table `mst_subject`
--

CREATE TABLE IF NOT EXISTS `mst_subject` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `sbjctcode` varchar(10) NOT NULL,
  `sbjctname` varchar(50) NOT NULL,
  `description` varchar(150) NOT NULL,
  `sched` varchar(10) NOT NULL,
  `type` varchar(11) NOT NULL,
  `time` varchar(50) NOT NULL,
  `department` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `mst_subject`
--

INSERT INTO `mst_subject` (`id`, `sbjctcode`, `sbjctname`, `description`, `sched`, `type`, `time`, `department`) VALUES
(1, '1234', 'MICROS', 'test', 'MON-FRI', '1ST TERM', '10:00-12:00 AM', 'CPE'),
(2, '321', 'Input Output', 'test2', 'MON-FRI', '2ND TERM', '8:00-10:00 AM', 'ECE'),
(4, '222', 'MATH', 'trigo', 'MON-FRI', '1st Term', '2:30-4:30', 'CPE'),
(5, '1004', 'TEST', 'TEST', 'MON-FRI', 'SEM', '1:30-2:30', 'ECE'),
(6, '12345', 'ALGEBRA', 'qwerty', 'M-F', 'Sem', '8:00-9:00AM', 'CEE'),
(7, '213', 'ASD', 'asd', 'MON-FRI', 'SEM', '1000M-1200', 'CEE');

-- --------------------------------------------------------

--
-- Table structure for table `mst_teacher`
--

CREATE TABLE IF NOT EXISTS `mst_teacher` (
  `id` int(50) NOT NULL AUTO_INCREMENT,
  `idNo` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `department` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `mst_teacher`
--

INSERT INTO `mst_teacher` (`id`, `idNo`, `name`, `gender`, `department`) VALUES
(1, '123', 'TEACHER 2', 'Male', 'BS CPE'),
(2, '10011', 'TEACHER 1', 'Male', 'BS CPE'),
(3, '12345', 'QWERTY QWERTY', 'Male', 'BS CPE');

-- --------------------------------------------------------

--
-- Table structure for table `mst_user`
--

CREATE TABLE IF NOT EXISTS `mst_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `access` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `mst_user`
--

INSERT INTO `mst_user` (`id`, `name`, `gender`, `access`, `username`, `password`) VALUES
(1, 'ALAGAO', 'Male', 'Admin', 'admin', '1a1dc91c907325c69271ddf0c944bc72'),
(3, 'HANNAH ANGELIA', 'Female', 'ADMIN', 'hannah', 'eb09d5e396183f4b71c3c798158f7c07'),
(4, 'BENITO GALLARDO II', 'Male', 'STA', 'benz', '827ccb0eea8a706c4c34a16891f84e7b');

-- --------------------------------------------------------

--
-- Table structure for table `mst_usertype`
--

CREATE TABLE IF NOT EXISTS `mst_usertype` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `type` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `mst_usertype`
--

INSERT INTO `mst_usertype` (`id`, `type`) VALUES
(1, 'ADMIN'),
(2, 'STA'),
(3, 'FACULTY');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_studentsbjct`
--

CREATE TABLE IF NOT EXISTS `tbl_studentsbjct` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `studentid` varchar(50) NOT NULL,
  `tblsbjctid` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `tbl_studentsbjct`
--

INSERT INTO `tbl_studentsbjct` (`id`, `studentid`, `tblsbjctid`) VALUES
(1, '1001', '1234'),
(2, '1001', '321'),
(3, '1001', '213');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_subject`
--

CREATE TABLE IF NOT EXISTS `tbl_subject` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `sbjctcode` varchar(50) NOT NULL,
  `teacherid` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `tbl_subject`
--

INSERT INTO `tbl_subject` (`id`, `sbjctcode`, `teacherid`) VALUES
(2, '1234', '123'),
(3, '321', '123'),
(4, '222', '123'),
(5, '1234', '10011'),
(6, '321', '10011'),
(7, '1004', '10011'),
(8, '213', '12345');

-- --------------------------------------------------------

--
-- Table structure for table `test`
--

CREATE TABLE IF NOT EXISTS `test` (
  `id` int(1) NOT NULL,
  `q1` int(1) NOT NULL,
  `q` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
