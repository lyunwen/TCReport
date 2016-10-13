/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50709
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50709
File Encoding         : 65001

Date: 2016-10-13 19:04:12
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `tc_report_default`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_default`;
CREATE TABLE `tc_report_default` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `CreateTime` datetime NOT NULL,
  `CreateBy` varchar(255) NOT NULL,
  `BeginDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `Remark` varchar(500) DEFAULT NULL,
  `LeaderRemark` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tc_report_default
-- ----------------------------
