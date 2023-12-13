namespace Small_Stock_Project;

public class GenricRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
{
    private readonly StockContext context;

    public GenricRepo(StockContext context)
    {
        this.context = context;
    }


    public List<TEntity> GetAll()
    {
        return context.Set<TEntity>()
            .ToList();     
    }

    public TEntity? GetById(int id)
    {
        return context.Set<TEntity>()
            .Find(id);
    }

    public void Add(TEntity entity)
    {
        context.Set<TEntity>()
            .Add(entity);
    }


    public void Update(TEntity entity)
    {
        context.Set<TEntity>()
            .Update(entity);
    }

    public void Delete(int? id)
    {
       var Entity = context.Set<TEntity>().Find(id);
          if(Entity != null)
        context.Set<TEntity>().Remove(Entity);
    }

    public void SaveChanges()
    {
        context.SaveChanges();  
    }

 
}
