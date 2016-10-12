/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-12 23:29:22
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tc_report_property`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_property`;
CREATE TABLE `tc_report_property` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(50) NOT NULL,
  `Type` tinyint(4) NOT NULL COMMENT '属性类型',
  `Regx` varchar(255) DEFAULT NULL,
  `CreateTime` datetime NOT NULL,
  `CreateBy` datetime NOT NULL,
  `IsValid` bit(1) NOT NULL DEFAULT b'0',
  `ReportTypeID` bigint(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tc_report_property
-- ----------------------------
