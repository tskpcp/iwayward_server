using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace app.WebServices.Utility
{
    public enum LogType
    {
        Deal,
        Noti,
        Error
    }
    public sealed class WriteLog
    {
        
        private WriteLog()
        {
        }

        private static readonly ILog logErr = LogManager.GetLogger("error");
        private static readonly ILog logDeal = LogManager.GetLogger("deal");
        private static readonly ILog logNoti = LogManager.GetLogger("noti");

        /// <summary>
        /// 日志处理
        /// </summary>
        /// <param name="sport">触发地址</param>
        /// <param name="logmsg">日志信息</param>
        /// <param name="logType">日志类型（处理型日志、警告型日志）</param>
        public static void WriteLogMessage(string sport,string logmsg,LogType logType)
        {
            switch (logType)
            {
                case LogType.Error:
                    WriteErrorLog(sport,logmsg);
                    break ;
                case LogType.Deal:
                    WriteDealLogInfo(sport, logmsg);
                    break ;
                case LogType.Noti:
                    WriteNotifyLogInfo(sport, logmsg);
                    break;
            }
        }

        private static void WriteErrorLog(string spot, string errorInfo)
        {
            logErr.Info("***ERROR AT=" + spot + ", MSG=" + errorInfo);
        }

        /// <summary>
        /// 写处理日志
        /// </summary>
        /// <param name="dealinfo">日志信息</param>
        private static void WriteDealLogInfo(string spot, string dealinfo)
        {
            logDeal.Info("***Deal AT=" + spot + ", MSG=" + dealinfo);
        }

        /// <summary>
        /// 写通知、警告日志
        /// </summary>
        /// <param name="notiinfo">日志信息</param>
        private static void WriteNotifyLogInfo(string spot,string notiinfo)
        {
            logNoti.Info("***Noti AT=" + spot + ", MSG=" + notiinfo);
        }
    }

}
