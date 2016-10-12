/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-12 23:29:08
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tc_report_data`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_data`;
CREATE TABLE `tc_report_data` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ReportInstanceID` bigint(20) NOT NULL,
  `ReportPropertyID` bigint(20) NOT NULL,
  `Value` varchar(2000) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tc_report_data
-- ----------------------------
