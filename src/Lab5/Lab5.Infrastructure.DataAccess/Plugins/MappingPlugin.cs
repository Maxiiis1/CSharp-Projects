using Itmo.Dev.Platform.Postgres.Plugins;
using Lab5.Application.Models.Users;
using Npgsql;

namespace Lab5.Infrastrucure.DataAccess.Plugins;

public class MappingPlugin : IDataSourcePlugin
{
    public void Configure(NpgsqlDataSourceBuilder builder)
    {
        builder.MapEnum<UserRole>();
    }
}