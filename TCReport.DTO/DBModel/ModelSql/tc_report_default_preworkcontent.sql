/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-13 22:59:02
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `tc_report_default_workcontent`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_default_preworkcontent`;
CREATE TABLE `tc_report_default_preworkcontent` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Report_DefaultID` bigint(20) NOT NULL,
  `Content` varchar(255) NOT NULL,
  `NeedDay` tinyint(4) NOT NULL,
  `Progress` decimal(3,2) NOT NULL COMMENT '进度',
  `Level` tinyint(4) NOT NULL COMMENT '优先级',
  `State` tinyint(4) NOT NULL COMMENT '状态',
  `Remark` varchar(2000) DEFAULT NULL,
  `LeaderRemark` varchar(2000) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tc_report_default_workcontent
-- ----------------------------
