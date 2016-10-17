/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-17 12:45:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `account_reportgroup_mapping`
-- ----------------------------
DROP TABLE IF EXISTS `account_reportgroup_mapping`;
CREATE TABLE `account_reportgroup_mapping` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `AccountID` bigint(20) NOT NULL,
  `GroupID` bigint(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of account_reportgroup_mapping
-- ----------------------------
