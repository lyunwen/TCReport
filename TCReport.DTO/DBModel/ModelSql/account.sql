/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-12 23:29:02
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `account`
-- ----------------------------
DROP TABLE IF EXISTS `account`;
CREATE TABLE `account` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Role` bigint(20) NOT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `PasswordVerify` bit(1) NOT NULL DEFAULT b'0',
  `UserName` varchar(50) DEFAULT NULL,
  `UserNameVerify` bit(1) NOT NULL DEFAULT b'0',
  `Mobile` varchar(20) DEFAULT NULL,
  `MobileVerify` bit(1) NOT NULL DEFAULT b'0',
  `WechatOpenId` varchar(50) DEFAULT NULL,
  `WechatOpenIdVerify` bit(1) NOT NULL DEFAULT b'0',
  `Email` varchar(50) DEFAULT NULL,
  `EmailVerify` bit(1) NOT NULL DEFAULT b'0',
  `CreateTime` datetime DEFAULT NULL,
  `ResgiterIdentify` varchar(50) NOT NULL DEFAULT 'default' COMMENT '注册来源',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of account
-- ----------------------------
INSERT INTO `account` VALUES ('1', '1', 'qq123123', '', 'admin', '', null, '', null, '', null, '', '2016-10-12 23:17:15', '');
INSERT INTO `account` VALUES ('2', '1', 'qq123123', '', 'lyw', '', null, '', null, '', null, '', '2016-10-12 23:20:52', 'test');
