/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-17 12:47:48
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `resourcegroup`
-- ----------------------------
DROP TABLE IF EXISTS `resourcegroup`;
CREATE TABLE `resourcegroup` (
  `ID` bigint(20) NOT NULL,
  `ResourceID` bigint(20) NOT NULL,
  `Name` bigint(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of resourcegroup
-- ----------------------------
