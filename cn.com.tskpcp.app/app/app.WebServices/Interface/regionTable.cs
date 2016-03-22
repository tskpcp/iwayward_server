using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
    /// <summary>
    /// 地区接口
    /// </summary>
    public interface regionTable
    {
        int IInsertRegionTable(regionTable region);

        IList<regionTable> IGetRegionTable();

        regionTable IGetRegionTable(string regionID);

        int IUpdateRegionTablefoByUserID(regionTable pos);

        int IDeletRegionTableByUserID(string userID);
    }
}
