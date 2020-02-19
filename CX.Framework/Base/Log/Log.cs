// Created by chenl3 2020.02.15
// 日志

namespace CX.Framework
{
    static class Log
    {
        private static ILog m_Log;

        public static void SetCore(ILog adapter)
        {
            m_Log = adapter;
        }

        public static void Debug()
        {
            // m_Log.Log();
        }
    }
}
