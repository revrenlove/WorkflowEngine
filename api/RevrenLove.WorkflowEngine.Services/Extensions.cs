using RevrenLove.WorkflowEngine.Services;
using RevrenLove.WorkflowEngine.Services.Interfaces;

namespace Microsoft.Extensions.DependencyInjection;

public static class Extensions
{
    public static IServiceCollection AddWorkflowEngineServices(this IServiceCollection services)
    {
        services.AddTransient<IWorkflowService, WorkflowService>();

        return services;
    }
}
