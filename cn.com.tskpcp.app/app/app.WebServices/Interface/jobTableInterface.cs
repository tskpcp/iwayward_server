using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
    /// <summary>
    /// 工作经历
    /// </summary>
    public interface jobTableInterface
    {
        string InserJobTable(jobTable job);
        IList<jobTable> GetJobTable();
        jobTable GetJobTable(string jobID);
        string UpdateJobTableByJobID(jobTable job);
        int DeleteJobTableByJobID(string jobID);
    }
}
