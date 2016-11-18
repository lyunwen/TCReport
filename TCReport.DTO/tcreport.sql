/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50709
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50709
File Encoding         : 65001

Date: 2016-11-18 16:47:36
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COMMENT='ffffffff';

-- ----------------------------
-- Records of account
-- ----------------------------
INSERT INTO `account` VALUES ('1', '1', 'qq123123', '', 'admin', '', null, '\0', null, '\0', null, '\0', '2016-10-12 23:17:15', '');
INSERT INTO `account` VALUES ('2', '1', 'qq123123', '', 'lyw', '', null, '\0', null, '\0', null, '\0', '2016-10-12 23:20:52', 'test');
INSERT INTO `account` VALUES ('3', '1', 'qq123123', '', 'hyl1015', '', null, '\0', null, '\0', null, '\0', '2016-10-15 11:56:23', 'PC');
INSERT INTO `account` VALUES ('4', '1', 'qq12123', '', 'hyl1011', '', null, '\0', null, '\0', null, '\0', '2016-10-15 11:58:21', 'PC');
INSERT INTO `account` VALUES ('5', '1', 'qq12123', '', 'hyl1011d', '', null, '\0', null, '\0', null, '\0', '2016-10-15 11:58:39', 'PC');
INSERT INTO `account` VALUES ('6', '1', 'qq12123', '', 'hyl1011ddddd', '', null, '\0', null, '\0', null, '\0', '2016-10-15 12:01:24', 'PC');
INSERT INTO `account` VALUES ('7', '1', 'dfgdfg', '', 'admin3', '', null, '\0', null, '\0', null, '\0', '2016-10-15 12:02:35', 'PC');
INSERT INTO `account` VALUES ('8', '1', 'sdfsdfsdf', '', 'sdfsdf', '', null, '\0', null, '\0', null, '\0', '2016-10-15 12:03:17', 'PC');
INSERT INTO `account` VALUES ('9', '1', 'qq123123', '', 'qq123123123', '', null, '\0', null, '\0', null, '\0', '2016-10-15 12:33:16', 'PC');
INSERT INTO `account` VALUES ('10', '1', 'werwer', '', 'werwer', '', null, '\0', null, '\0', null, '\0', '2016-10-15 12:33:57', 'PC');
INSERT INTO `account` VALUES ('11', '1', 'qqq', '', 'adminss', '', null, '\0', null, '\0', null, '\0', '2016-10-15 12:38:57', 'PC');
INSERT INTO `account` VALUES ('12', '1', 'qq123123', '', 'liuyunwen', '', null, '\0', null, '\0', null, '\0', '2016-10-15 13:13:23', 'PC');
INSERT INTO `account` VALUES ('13', '1', 'qq123123', '', 'qq123123', '', null, '\0', null, '\0', null, '\0', '2016-10-17 19:00:15', 'PC');
INSERT INTO `account` VALUES ('14', '1', 'qq123', '', 'qq123', '', null, '\0', null, '\0', null, '\0', '2016-10-17 19:09:14', 'PC');

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

-- ----------------------------
-- Table structure for `account_resourcegroup_mapping`
-- ----------------------------
DROP TABLE IF EXISTS `account_resourcegroup_mapping`;
CREATE TABLE `account_resourcegroup_mapping` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `AccountID` bigint(20) NOT NULL,
  `ResourceGroupID` bigint(20) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of account_resourcegroup_mapping
-- ----------------------------

-- ----------------------------
-- Table structure for `resource`
-- ----------------------------
DROP TABLE IF EXISTS `resource`;
CREATE TABLE `resource` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Value` varchar(255) NOT NULL,
  `CreateBy` varchar(255) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of resource
-- ----------------------------

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

-- ----------------------------
-- Table structure for `tc_report_data_copy`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_data_copy`;
CREATE TABLE `tc_report_data_copy` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `ReportInstanceID` bigint(20) NOT NULL,
  `ReportPropertyID` bigint(20) NOT NULL,
  `Value` varchar(2000) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tc_report_data_copy
-- ----------------------------

-- ----------------------------
-- Table structure for `tc_report_default`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_default`;
CREATE TABLE `tc_report_default` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `UUID` varchar(36) NOT NULL,
  `CreateTime` datetime NOT NULL,
  `CreateBy` varchar(255) NOT NULL,
  `BeginDate` date NOT NULL,
  `EndDate` date NOT NULL,
  `Remark` varchar(500) DEFAULT NULL,
  `LeaderRemark` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of tc_report_default
-- ----------------------------
INSERT INTO `tc_report_default` VALUES ('1', '', '2010-10-10 00:00:00', '1', '2010-10-10', '2010-10-10', null, null);
INSERT INTO `tc_report_default` VALUES ('2', '39166596-cd29-43d3-8fc4-ae571edc99a9', '2016-10-16 11:40:32', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('3', '0315708d-0b9d-4cf6-99d3-7f3fff90c8dd', '2016-10-16 11:42:27', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('4', '0315708d-0b9d-4cf6-99d3-7f3fff90c8dd', '2016-10-16 11:42:27', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('5', 'd5d8f6b7-a361-4b1a-80be-3243a73ab107', '2016-10-16 11:49:39', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('6', 'd5d8f6b7-a361-4b1a-80be-3243a73ab107', '2016-10-16 11:49:39', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('7', '5ef0df1b-3907-41f4-b86e-6c902e57662b', '2016-10-16 11:53:01', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('8', '5ef0df1b-3907-41f4-b86e-6c902e57662b', '2016-10-16 11:53:01', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('9', 'e4c116e4-2289-415f-9874-b787986db39e', '2016-10-16 11:58:43', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('10', 'e4c116e4-2289-415f-9874-b787986db39e', '2016-10-16 11:58:43', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('11', 'fc28ec1e-7ba1-4969-bc42-41f5b243a940', '2016-10-16 12:01:17', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('12', 'fc28ec1e-7ba1-4969-bc42-41f5b243a940', '2016-10-16 12:01:17', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('13', '664c6944-2e7a-42ab-9cb8-f1617ea4190e', '2016-10-16 12:01:55', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('14', '664c6944-2e7a-42ab-9cb8-f1617ea4190e', '2016-10-16 12:01:55', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('15', '1f25abe8-d7e7-43be-8f6b-60bb4a149cfb', '2016-10-16 12:04:39', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('16', '1f25abe8-d7e7-43be-8f6b-60bb4a149cfb', '2016-10-16 12:04:39', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('17', 'f333e5c7-d8a6-4734-bf97-5c5ec53e3459', '2016-10-16 12:04:45', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('18', 'f333e5c7-d8a6-4734-bf97-5c5ec53e3459', '2016-10-16 12:04:45', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('19', 'f6cd23af-0a13-4105-8f22-ffc4c04751b9', '2016-10-16 12:08:54', '1', '2016-10-16', '2016-10-23', null, null);
INSERT INTO `tc_report_default` VALUES ('20', 'f6cd23af-0a13-4105-8f22-ffc4c04751b9', '2016-10-16 12:08:54', '1', '2016-10-16', '2016-10-23', null, null);

-- ----------------------------
-- Table structure for `tc_report_default_preworkcontent`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_default_preworkcontent`;
CREATE TABLE `tc_report_default_preworkcontent` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Report_DefaultUUID` varchar(16) NOT NULL,
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
-- Records of tc_report_default_preworkcontent
-- ----------------------------

-- ----------------------------
-- Table structure for `tc_report_default_workcontent`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_default_workcontent`;
CREATE TABLE `tc_report_default_workcontent` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Report_DefaultUUID` varchar(36) CHARACTER SET latin1 NOT NULL,
  `Content` varchar(255) CHARACTER SET latin1 NOT NULL,
  `NeedDay` tinyint(4) NOT NULL,
  `Progress` decimal(5,2) NOT NULL COMMENT '进度',
  `Level` tinyint(4) NOT NULL COMMENT '优先级',
  `State` tinyint(4) NOT NULL COMMENT '状态',
  `Remark` varchar(2000) CHARACTER SET latin1 DEFAULT NULL,
  `LeaderRemark` varchar(2000) CHARACTER SET latin1 DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=gbk;

-- ----------------------------
-- Records of tc_report_default_workcontent
-- ----------------------------
INSERT INTO `tc_report_default_workcontent` VALUES ('1', 'kkkk', 'content', '1', '11.11', '1', '1', '', '');
INSERT INTO `tc_report_default_workcontent` VALUES ('2', 'kkkk', 'content', '1', '11.00', '1', '1', '', '');
INSERT INTO `tc_report_default_workcontent` VALUES ('3', 'kkkk', 'content', '1', '11.00', '1', '1', null, null);
INSERT INTO `tc_report_default_workcontent` VALUES ('4', 'oooo', 'jjj', '1', '11.00', '1', '1', null, null);
INSERT INTO `tc_report_default_workcontent` VALUES ('5', '664c6944-2e7a-42ab-9cb8-f1617ea4190e', 'jjj', '0', '1.00', '2', '0', '11', null);
INSERT INTO `tc_report_default_workcontent` VALUES ('6', 'f6cd23af-0a13-4105-8f22-ffc4c04751b9', 'duty11111', '0', '1.00', '2', '0', '11', null);
INSERT INTO `tc_report_default_workcontent` VALUES ('7', 'f6cd23af-0a13-4105-8f22-ffc4c04751b9', 'duty11111', '0', '1.00', '2', '0', '11', null);
INSERT INTO `tc_report_default_workcontent` VALUES ('8', 'f6cd23af-0a13-4105-8f22-ffc4c04751b9', 'duty11111', '0', '1.00', '2', '0', '11', null);

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

-- ----------------------------
-- Table structure for `tc_report_type`
-- ----------------------------
DROP TABLE IF EXISTS `tc_report_type`;
CREATE TABLE `tc_report_type` (
  `ID` bigint(20) NOT NULL AUTO_INCREMENT,
  `Name` varchar(225) NOT NULL,
  `CreateTime` datetime NOT NULL,
  `CreateBy` bigint(20) NOT NULL,
  `Description` varchar(2000) NOT NULL,
  `IsValid` bit(1) NOT NULL,
  `Type` tinyint(4) NOT NULL COMMENT '报表类型',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of tc_report_type
-- ----------------------------

-- ----------------------------
-- Procedure structure for `fff`
-- ----------------------------
DROP PROCEDURE IF EXISTS `fff`;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `fff`()
begin
declare n int default 0; 
 
DECLARE Namet varchar(20); 

declare allCount int default 0; 
SELECT count(*) INTO allCount from account;
while n<allCount do
SELECT 
	Namet=a.UserName
FROM account a WHERE a.ID=n;
UPDATE ff a SET  
	a.`Name`=Namet WHERE a.ID=n ;
SET n=n+1; 
end while;
end
;;
DELIMITER ;
