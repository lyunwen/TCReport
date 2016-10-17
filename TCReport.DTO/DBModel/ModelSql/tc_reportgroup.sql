/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-17 12:52:03
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tc_reportgroup`
-- ----------------------------
DROP TABLE IF EXISTS `tc_reportgroup`;
CREATE TABLE `tc_reportgroup` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ParentID` bigint(20) NOT NULL,
  `Name` varchar(255) NOT NULL,
  `IsValid` bit(1) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tc_reportgroup
-- ----------------------------
