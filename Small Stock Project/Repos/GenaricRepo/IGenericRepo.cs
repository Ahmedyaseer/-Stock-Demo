namespace Small_Stock_Project;

public interface IGenericRepo<TEntity> where TEntity : class
{
    public List<TEntity> GetAll();

    public TEntity? GetById(int id);

    public void Add(TEntity entity);

    public void Update(TEntity entity);

    public void Delete(int? id);

    public void SaveChanges();


}
