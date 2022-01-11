﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using NewRelic.LogEnrichers.Serilog;
using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Formatting.Json;
using Serilog.Sinks.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19PCR.TestManagement.Infrastructure.Logging
{
    public static class Logging
    {
        public static Action<HostBuilderContext, LoggerConfiguration> ConfigureLogger =>

            (hostBuilderContext, loggerConfiguration) =>
            {
                var env = hostBuilderContext.HostingEnvironment;

                var serviceName = hostBuilderContext.Configuration.GetValue<string>("Serilog:LogIndexName");

                loggerConfiguration.MinimumLevel.Information()
                .Enrich.FromLogContext()
                .Enrich.WithProperty("ApplicationName", env.ApplicationName)
                .Enrich.WithProperty("EnvironmentName", env.EnvironmentName)
                .Enrich.WithExceptionDetails()
                //.Enrich.WithThreadName()
                //.Enrich.WithThreadId()
                .Enrich.WithNewRelicLogsInContext()
                .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                .MinimumLevel.Override("System.Net.Http", LogEventLevel.Warning)
                .MinimumLevel.Override("Microsoft.Hosting.LifeTime", LogEventLevel.Information)
                .WriteTo.File(new JsonFormatter(), @$"c:\{serviceName}\logs\{serviceName}-{DateTime.Today:yyyy-MM-dd}.json")
                .WriteTo.File(formatter: new NewRelicFormatter(),path: @$"c:\{serviceName}\logs\NewRelic 
                                {serviceName}-{DateTime.Today:yyyy-MM-dd}.json")
                .WriteTo.Console();

                if (hostBuilderContext.HostingEnvironment.IsDevelopment())
                {
                    loggerConfiguration.MinimumLevel.Override("COVIDPCR.Service", LogEventLevel.Debug);
                }

                var elasticUri = hostBuilderContext.Configuration.GetValue<string>("Serilog:ElasticUri");

                if (!string.IsNullOrEmpty(elasticUri))
                {
                    loggerConfiguration.WriteTo.Elasticsearch(

                    new ElasticsearchSinkOptions(new Uri(elasticUri))
                    {
                        AutoRegisterTemplate = true,
                        AutoRegisterTemplateVersion = AutoRegisterTemplateVersion.ESv7,
                        IndexFormat = "COVIDPCR-logs-{0:yyyy.MM.dd}",
                        MinimumLogEventLevel = LogEventLevel.Debug
                    }
                    );
                }
            };
    }
}
