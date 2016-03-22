using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
    /// <summary>
    /// 项目经验接口
    /// </summary>
    public interface projectTableInterface
    {
        int IInsertProjectTable(projectTable proj);

        IList<projectTable> IGetProjectTable();

        projectTable IGetProjectTable(string posID);

        int IUpdateProjectTablefoByUserID(projectTable pos);

        int IDeletProjectTableByUserID(string userID);
    }
}
