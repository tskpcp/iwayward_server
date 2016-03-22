using app.WebServices.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace app.WebServices.Interface
{
    /// <summary>
    /// 服务评论
    /// </summary>
    public interface commentsInterface
    {
         int InsertComments(comments comm);
         IList<comments> GetComment();
         comments GetComment(int commID);
    }
}
