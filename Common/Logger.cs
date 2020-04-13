using System;
using log4net;
namespace Common
{
    public static class Logger
    {
        public static log4net.ILog log;// = LogManager.GetLogger("FileAppender"); //log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public static void Debub(string message)
        {
            log.Debug(message);
        }
        public static void Debub(string message, Exception exception)
        {
            log.Debug(message, exception);
        }
        public static void DebugFormat(string format, object args0)
        {
            log.DebugFormat(format, args0);
        }
        public static void DebugFormat(string format, params object[] args)
        {
            log.DebugFormat(format, args);
        }
        public static void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            log.DebugFormat(provider, format, args);
        }
        public static void DebugFormat(string format, object args0, object args1)
        {
            log.DebugFormat(format, args0, args1);
        }
        public static void DebugFormat(string format, object args0, object args1, object args2)
        {
            log.DebugFormat(format, args0, args1, args2);
        }
        private static void Error(string strError)
        {
            log.Error(strError);
        }
        private static void Error(string strError, Exception exception)
        {
            log.Error(strError, exception);
        }
        public static void ErrorFormat(string format, object args0)
        {
            log.ErrorFormat(format, args0);
        }
        public static void ErrorFormat(string format, params object[] args)
        {
            log.ErrorFormat(format, args);
        }
        public static void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            log.ErrorFormat(provider, format, args);
        }
        public static void ErrorFormat(string format, object args0, object args1)
        {
            log.ErrorFormat(format, args0, args1);
        }
        public static void ErrorFormat(string format, object args0, object args1, object args2)
        {
            log.ErrorFormat(format, args0, args1, args2);
        }
        private static void Info(string info)
        {
            log.Info(info);
        }

        public static void WriteInfo(string info)
        {

            Info(info);
        }

        public static void WriteError(string info)
        {

            Error(info);
        }


        public static void WriteException(Exception exception)
        {

            Error(exception.Message, exception);
        }

        public static void Info(string info, Exception exception)
        {
            log.Info(info, exception);
        }
        public static void InfoFormat(string format, object args0)
        {
            log.InfoFormat(format, args0);
        }
        public static void InfoFormat(string format, params object[] args)
        {
            log.InfoFormat(format, args);
        }
        public static void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            log.InfoFormat(provider, format, args);
        }
        public static void InfoFormat(string format, object args0, object args1)
        {
            log.InfoFormat(format, args0, args1);
        }
        public static void InfoFormat(string format, object args0, object args1, object args2)
        {
            log.InfoFormat(format, args0, args1, args2);
        }
        public static void Fatal(string fatalMsg)
        {
            log.Fatal(fatalMsg);
        }
        public static void Fatal(string fatalMsg, Exception exception)
        {
            log.Fatal(fatalMsg, exception);
        }
        public static void FatalFormat(string format, object args0)
        {
            log.FatalFormat(format, args0);
        }
        public static void FatalFormat(string format, params object[] args)
        {
            log.FatalFormat(format, args);
        }
        public static void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            log.FatalFormat(provider, format, args);
        }
        public static void FatalFormat(string format, object args0, object args1)
        {
            log.FatalFormat(format, args0, args1);
        }
        public static void FatalFormat(string format, object args0, object args1, object args2)
        {
            log.FatalFormat(format, args0, args1, args2);
        }
        public static void Warn(string message)
        {
            log.Warn(message);
        }
        public static void Warn(string message, Exception exception)
        {
            log.Warn(message, exception);
        }
        public static void WarnFormat(string format, object args0)
        {
            log.WarnFormat(format, args0);
        }
        public static void WarnFormat(string format, params object[] args)
        {
            log.WarnFormat(format, args);
        }
        public static void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            log.WarnFormat(provider, format, args);
        }
        public static void WarnFormat(string format, object args0, object args1)
        {
            log.WarnFormat(format, args0, args1);
        }
        public static void WarnFormat(string format, object args0, object args1, object args2)
        {
            log.WarnFormat(format, args0, args1, args2);
        }

        //public static static void Error(object message)
        //{
        //    log.Error(message);
        //}

        //public static static void Error(string message,Exception ex)
        //{
        //    log.Error(message, ex);
        //}

        //public static static void Info(object message)
        //{
        //    log.Info(message);
        //}
        //public static static void Info(string message, Exception ex)
        //{
        //    log.Info(message, ex);
        //}
        //public static static void Warn(object message)
        //{
        //    log.Warn(message);
        //}
        //public static static void Warn(string message, Exception ex)
        //{
        //    log.Warn(message, ex);
        //}
    }
}
