// Created by chenl3 2020.02.15
// 日志输出接口

namespace CX.Framework
{
    interface ILog
    {
        void Log(LogLevel level, object message);
    }
}