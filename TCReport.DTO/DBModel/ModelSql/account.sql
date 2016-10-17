/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-17 12:44:42
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `account`
-- ----------------------------
DROP TABLE IF EXISTS `account`;
CREATE TABLE `account` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Role` bigint(20) NOT NULL COMMENT 'ddd',
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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8 COMMENT='ffffffff';

-- ----------------------------
-- Records of account
-- ----------------------------
INSERT INTO `account` VALUES ('1', '1', 'qq123123', '', 'admin', '', null, '', null, '', null, '', '2016-10-12 23:17:15', '');
INSERT INTO `account` VALUES ('2', '1', 'qq123123', '', 'lyw', '', null, '', null, '', null, '', '2016-10-12 23:20:52', 'test');
INSERT INTO `account` VALUES ('3', '1', 'qq123123', '', 'hyl1015', '', null, '', null, '', null, '', '2016-10-15 11:56:23', 'PC');
INSERT INTO `account` VALUES ('4', '1', 'qq12123', '', 'hyl1011', '', null, '', null, '', null, '', '2016-10-15 11:58:21', 'PC');
INSERT INTO `account` VALUES ('5', '1', 'qq12123', '', 'hyl1011d', '', null, '', null, '', null, '', '2016-10-15 11:58:39', 'PC');
INSERT INTO `account` VALUES ('6', '1', 'qq12123', '', 'hyl1011ddddd', '', null, '', null, '', null, '', '2016-10-15 12:01:24', 'PC');
INSERT INTO `account` VALUES ('7', '1', 'dfgdfg', '', 'admin3', '', null, '', null, '', null, '', '2016-10-15 12:02:35', 'PC');
INSERT INTO `account` VALUES ('8', '1', 'sdfsdfsdf', '', 'sdfsdf', '', null, '', null, '', null, '', '2016-10-15 12:03:17', 'PC');
INSERT INTO `account` VALUES ('9', '1', 'qq123123', '', 'qq123123123', '', null, '', null, '', null, '', '2016-10-15 12:33:16', 'PC');
INSERT INTO `account` VALUES ('10', '1', 'werwer', '', 'werwer', '', null, '', null, '', null, '', '2016-10-15 12:33:57', 'PC');
INSERT INTO `account` VALUES ('11', '1', 'qqq', '', 'adminss', '', null, '', null, '', null, '', '2016-10-15 12:38:57', 'PC');
INSERT INTO `account` VALUES ('12', '1', 'qq123123', '', 'liuyunwen', '', null, '', null, '', null, '', '2016-10-15 13:13:23', 'PC');
