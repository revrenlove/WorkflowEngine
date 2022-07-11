using Microsoft.EntityFrameworkCore;
using RevrenLove.WorkflowEngine.Persistence;

namespace Microsoft.Extensions.DependencyInjection;

public static class Extensions
{
    public static IServiceCollection AddWorkflowEnginePersistence(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<WorkflowEngineContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
}