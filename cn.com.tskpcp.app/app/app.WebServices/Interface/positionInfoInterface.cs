using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
    
    /// <summary>
    /// 招聘信息
    /// </summary>
    public interface positionInfoInterface
    {
        int IInsertPositionInfo(positionInfo pos);

        IList<positionInfo> IGetPositionInfo();

        positionInfo IGetPositionInfo(string posID);

        int IUpdatePositionInfofoByUserID(positionInfo pos);

        int IDeletePositionInfoByUserID(string userID);
    }
}
