﻿namespace Vtb24.ServicesExtensions.ServiceLogger
{
    public class Log4NetServiceLoggerFactory : ServiceLoggerFactory
    {
        public override IServiceLogger Create(string serviceName, ServiceLogSide side, object properties)
        {
            return new Log4NetServiceLogger(serviceName, side, properties);
        }
    }
}
