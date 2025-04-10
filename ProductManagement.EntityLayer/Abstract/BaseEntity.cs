namespace ProductManagement.EntityLayer.Abstract;

public abstract class BaseEntity
{
    public string Id { get; set; }
    protected BaseEntity()
    {
        Id = Guid.NewGuid().ToString(); 
    }
}
