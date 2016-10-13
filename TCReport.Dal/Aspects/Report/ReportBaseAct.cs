using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCReport.DTO.BOModel;

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
            throw new NotImplementedException();
        }

        int IReportBaseAct.Report_Default_BOInsert(Report_DefaultBO report)
        {
            throw new NotImplementedException();
        }
    }
}