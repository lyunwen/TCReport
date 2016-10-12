/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-12 23:29:16
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tc_report_instance`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_instance`;
CREATE TABLE `tc_report_instance` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(500) NOT NULL,
  `ReportPropertyID` bigint(20) NOT NULL,
  `ReportTypeID` bigint(20) NOT NULL,
  `CreateBy` bigint(20) NOT NULL,
  `CreateTime` bigint(20) NOT NULL,
  `IsValid` bit(1) NOT NULL,
  `LastEditTime` datetime NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tc_report_instance
-- ----------------------------
