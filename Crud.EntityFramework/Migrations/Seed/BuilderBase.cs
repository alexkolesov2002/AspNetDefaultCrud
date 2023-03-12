namespace Crud.EntityFramework.Migrations.Seed;

public abstract class BuilderBase
{
    protected readonly CrudDbContext _context;

    protected BuilderBase(CrudDbContext context)
    {
        _context = context;
    }

    public abstract void Create();
}