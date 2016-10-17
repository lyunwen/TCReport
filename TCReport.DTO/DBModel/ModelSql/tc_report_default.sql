/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-17 12:48:50
*/

SET FOREIGN_KEY_CHECKS=0;

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
