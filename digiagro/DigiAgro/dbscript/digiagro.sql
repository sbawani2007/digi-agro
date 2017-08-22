-- phpMyAdmin SQL Dump
-- version 3.4.5 shahid
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Mar 11, 2014 at 06:41 AM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `digiagro`
--

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

CREATE TABLE IF NOT EXISTS `customers` (
  `customerid` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) DEFAULT NULL,
  `status` int(11) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `mobile` varchar(15) NOT NULL,
  `createdby` int(11) DEFAULT NULL,
  `createdon` date DEFAULT NULL,
  `isdeleted` char(1) DEFAULT NULL,
  `modifyby` int(11) DEFAULT NULL,
  `modifyon` date DEFAULT NULL,
  PRIMARY KEY (`customerid`),
  UNIQUE KEY `mobile` (`mobile`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customerid`, `firstname`, `lastname`, `status`, `email`, `mobile`, `createdby`, `createdon`, `isdeleted`, `modifyby`, `modifyon`) VALUES
(1, 'dfs', 'sf', 1, 'dfs', 'sdf', 1, '0000-00-00', 'F', 0, '0000-00-00'),
(2, 'sf', 'sf', 1, 'sdf', 'sf', 0, NULL, 'F', 0, '0000-00-00'),
(3, 'dg', 'dgdgf', 1, 'dfg', 'dfg', 0, '2014-11-03', 'F', 0, '0000-00-00'),
(5, 'shahid', 'shahid', 1, 'abc@abc.co', '032133333', 0, '2014-11-03', 'F', 0, '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `customer_address`
--

CREATE TABLE IF NOT EXISTS `customer_address` (
  `custaddressid` int(11) NOT NULL AUTO_INCREMENT,
  `customerid` int(11) NOT NULL,
  `house` varchar(20) DEFAULT NULL,
  `street` varchar(20) DEFAULT NULL,
  `area` varchar(20) DEFAULT NULL,
  `city` int(11) DEFAULT NULL,
  `country` int(11) DEFAULT NULL,
  PRIMARY KEY (`custaddressid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `rolerights`
--

CREATE TABLE IF NOT EXISTS `rolerights` (
  `rolerightsid` int(11) NOT NULL AUTO_INCREMENT,
  `ticketstatusid` int(11) NOT NULL,
  `roleid` int(11) NOT NULL,
  `isdeleted` char(1) NOT NULL,
  `createdby` int(11) DEFAULT NULL,
  `createdon` date DEFAULT NULL,
  `modifyby` int(11) DEFAULT NULL,
  `modifyon` date DEFAULT NULL,
  PRIMARY KEY (`rolerightsid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `roles`
--

CREATE TABLE IF NOT EXISTS `roles` (
  `roleid` int(11) NOT NULL AUTO_INCREMENT,
  `rolename` varchar(50) NOT NULL,
  `description` varchar(100) NOT NULL,
  `isdeleted` char(1) NOT NULL,
  `createdby` int(11) DEFAULT NULL,
  `createdon` date DEFAULT NULL,
  `modifiedby` int(11) DEFAULT NULL,
  `modifiedon` date DEFAULT NULL,
  PRIMARY KEY (`roleid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `status`
--

CREATE TABLE IF NOT EXISTS `status` (
  `statusid` int(11) NOT NULL AUTO_INCREMENT,
  `statusname` varchar(50) NOT NULL,
  `isdeleted` char(1) NOT NULL,
  `createdby` int(11) DEFAULT NULL,
  `createdon` date DEFAULT NULL,
  `modifiedby` int(11) DEFAULT NULL,
  `modifiedon` date DEFAULT NULL,
  PRIMARY KEY (`statusid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `status`
--

INSERT INTO `status` (`statusid`, `statusname`, `isdeleted`, `createdby`, `createdon`, `modifiedby`, `modifiedon`) VALUES
(1, 'Active', 'F', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `ticketattachment`
--

CREATE TABLE IF NOT EXISTS `ticketattachment` (
  `ticketattachmentid` int(11) NOT NULL AUTO_INCREMENT,
  `ticketid` int(11) NOT NULL,
  `link` varchar(50) NOT NULL,
  `isdeleted` char(1) DEFAULT NULL,
  PRIMARY KEY (`ticketattachmentid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `ticketfeedback`
--

CREATE TABLE IF NOT EXISTS `ticketfeedback` (
  `ticketfeedbackid` int(11) NOT NULL AUTO_INCREMENT,
  `ticketid` int(11) NOT NULL,
  `userid` int(11) NOT NULL,
  `feedback` varchar(200) NOT NULL,
  `isdeleted` char(1) NOT NULL,
  PRIMARY KEY (`ticketfeedbackid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tickethistory`
--

CREATE TABLE IF NOT EXISTS `tickethistory` (
  `tickethistoryid` int(11) NOT NULL AUTO_INCREMENT,
  `ticketid` int(11) NOT NULL,
  `userid` int(11) NOT NULL,
  `ticketstatusid` int(11) NOT NULL,
  PRIMARY KEY (`tickethistoryid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tickets`
--

CREATE TABLE IF NOT EXISTS `tickets` (
  `ticketid` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(50) DEFAULT NULL,
  `description` varchar(100) DEFAULT NULL,
  `ticketstatusid` int(11) DEFAULT NULL,
  `userid` int(11) DEFAULT NULL,
  `customerid` int(11) DEFAULT NULL,
  `isdeleted` char(1) DEFAULT NULL,
  `createdby` int(11) DEFAULT NULL,
  `createdon` date DEFAULT NULL,
  `modifiedby` int(11) DEFAULT NULL,
  `modifiedon` date DEFAULT NULL,
  PRIMARY KEY (`ticketid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `ticketstatus`
--

CREATE TABLE IF NOT EXISTS `ticketstatus` (
  `ticketstatusid` int(11) NOT NULL AUTO_INCREMENT,
  `ticketstatusname` varchar(50) NOT NULL,
  `description` varchar(100) NOT NULL,
  `isdeleted` char(1) DEFAULT NULL,
  `createdby` int(11) DEFAULT NULL,
  `createdon` date DEFAULT NULL,
  `modifiedby` int(11) DEFAULT NULL,
  `modifiedon` date DEFAULT NULL,
  PRIMARY KEY (`ticketstatusid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `userid` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(100) DEFAULT NULL,
  `lastname` varchar(100) DEFAULT NULL,
  `roleid` int(11) DEFAULT NULL,
  `status` int(11) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `mobile` varchar(15) DEFAULT NULL,
  `createdby` int(11) DEFAULT NULL,
  `createdon` date DEFAULT NULL,
  `modifyby` int(11) DEFAULT NULL,
  `modifyon` date DEFAULT NULL,
  `isdeleted` char(1) DEFAULT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
