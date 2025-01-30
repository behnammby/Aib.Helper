using System;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace Behnammby.Common.Extensions
{
    public static class ConfigurationExtensions 
    {
        public static Version GetMySqlVersion(this IConfiguration configuration)
        {
            var mysql = configuration.GetSection("MySqlVersion");
            
            return new Version(
                major: mysql.GetValue<int>("Major"),
                minor: mysql.GetValue<int>("Minor"),
                build: mysql.GetValue<int>("Build")
            );
        }

        public static ServerType GetMySqlServerType(this IConfiguration configuration)
        {
            var mysql = configuration.GetSection("MySqlVersion");
            var serverType = mysql.GetValue<string>("ServerType");

            if (Enum.TryParse(serverType, true, out ServerType type))
            {
                return type;
            }

            return default;
        }
    }
}