/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50712
Source Host           : localhost:3306
Source Database       : tcreport

Target Server Type    : MYSQL
Target Server Version : 50712
File Encoding         : 65001

Date: 2016-10-17 12:51:11
*/

SET FOREIGN_KEY_CHECKS=0;

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
