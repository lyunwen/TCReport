using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCReport.DTO.BOModel;
using TCReport.DTO.DBModel;

namespace TCReport.Dal.Aspects.Report
{
    public interface IReportBaseAct
    {
        /// <summary>
        /// 报表完整信息获取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Report_DefaultBO Report_DefaultBOGetByID(long id);

        /// <summary>
        /// 报表完整信息插入
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        int Report_Default_BOInsert(Report_DefaultBO report);
    }
    public class ReportBaseAct : IReportBaseAct
    {
        Report_DefaultBO IReportBaseAct.Report_DefaultBOGetByID(long id)
        {
            Report_DefaultBO result = null;
            StringBuilder sqlCmd = new StringBuilder(@"SELECT * FROM tc_report_default AS tb_report");
            sqlCmd.Append(" LEFT JOIN tc_report_default_preworkcontent tb_precontent ON tb_precontent.Report_DefaultID=tb_report.ID");
            sqlCmd.Append(" LEFT JOIN tc_report_default_workcontent tb_content ON tb_content.Report_DefaultID=tb_report.ID");
            sqlCmd.Append(" WHERE tb_report.ID=@ID");
            using (var conn = MDBQuery.Open())
            {
                result = conn.Query<Report_DefaultBO, Report_Default_WorkContent, Report_DefaultBO>(sqlCmd.ToString(), (report, workContent) =>
                  {
                      if (report == null)
                          return null; 
                      report.WorkContents.Add(workContent);
                      return report;
                  }, new { ID = id }).FirstOrDefault();
            }
            return result;
        }

        int IReportBaseAct.Report_Default_BOInsert(Report_DefaultBO report)
        {
            int result = 0;
            if (report == null)
                return 0;
            report.UUID = Guid.NewGuid().ToString();
            StringBuilder reportSql = new StringBuilder();
            reportSql.Append("INSERT INTO tc_report_default  ");
            reportSql.Append("(UUID ,CreateTime ,CreateBy ,BeginDate ,EndDate ,Remark ,LeaderRemark ) ");
            reportSql.Append(" VALUES ");
            reportSql.Append("(@UUID,@CreateTime,@CreateBy,@BeginDate,@EndDate,@Remark,@LeaderRemark)");
            StringBuilder workContentSql = new StringBuilder();
            workContentSql.Append("INSERT INTO tc_report_default_workcontent");
            workContentSql.Append(" (Report_DefaultUUID ,Content ,NeedDay ,Progress ,Level ,State ,Remark ,LeaderRemark )");
            workContentSql.Append(" VALUES ");
            workContentSql.Append(" (@Report_DefaultUUID,@Content,NeedDay,@Progress,@Level,@State,@Remark,@LeaderRemark)");
            using (var conn = MDBCommander.Open())
            { 
                result = conn.Execute(reportSql.ToString(), report); 
                result = conn.Execute(reportSql.ToString(), report);
                if (report.WorkContents != null)
                {
                    foreach (var item in report.WorkContents)
                    {
                        item.Report_DefaultUUID = report.UUID;
                        result += conn.Execute(workContentSql.ToString(), item);
                    }
                }
            }
            return result;
        }
    }
}