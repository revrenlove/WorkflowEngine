using Microsoft.EntityFrameworkCore;
using RevrenLove.WorkflowEngine.Entities;

namespace RevrenLove.WorkflowEngine.Persistence;

public class WorkflowEngineContext : DbContext
{
    public WorkflowEngineContext(DbContextOptions options)
        : base(options)
    {

    }

    public DbSet<Workflow> Workflows { get; set; } = default!;
}
