// Created by chenl3 2020.02.18
// NLog日志适配器

// using NLog;

namespace CX.Framework.Helper
{
    class NLogAdapter : ILog
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public void Log(LogLevel level, object message)
        {
            LogLevel.
        }
    }
}