﻿using Hos.ScheduleMaster.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hos.ScheduleMaster.Core.Log
{
    public class LogHelper
    {

        public static void Info(string message)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Info,
                Message = message
            });
        }

        public static void Info(string message, Guid sid)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Info,
                Message = message,
                ScheduleId = sid
            });
        }

        public static void Info(string message, Guid sid, Guid traceId)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Info,
                Message = message,
                ScheduleId = sid,
                TraceId = traceId
            });
        }

        public static void Warn(string message)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Warn,
                Message = message
            });
        }

        public static void Warn(string message, Guid sid)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Warn,
                Message = message,
                ScheduleId = sid
            });
        }

        public static void Error(Exception ex)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Error,
                Message = ex.Message,
                StackTrace = ex.StackTrace
            });
        }

        public static void Error(Exception ex, Guid sid)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Error,
                Message = ex.Message,
                StackTrace = ex.StackTrace,
                ScheduleId = sid
            });
        }

        public static void Error(string message, Exception exp)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Error,
                Message = $"{message}，ERROR：{exp.Message}",
                StackTrace = exp.StackTrace
            });
        }

        public static void Error(string message, Guid sid)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Error,
                Message = message,
                ScheduleId = sid
            });
        }

        public static void Error(string message, Exception exp, Guid sid)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Error,
                Message = $"{message}，ERROR：{exp.Message}",
                StackTrace = exp.StackTrace,
                ScheduleId = sid
            });
        }

        public static void Error(string message, Exception exp, Guid sid, Guid traceId)
        {
            LogManager.Queue.Write(new SystemLogEntity
            {
                Category = (int)LogCategory.Error,
                Message = $"{message}，ERROR：{exp.Message}",
                StackTrace = exp.StackTrace,
                ScheduleId = sid,
                TraceId = traceId
            });
        }
    }

}
