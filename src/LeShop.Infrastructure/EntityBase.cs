namespace LeShop.Infrastructure;

public interface IEntity
{
    public Guid Id { get; set; }
}

public class EntityBase : IEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();
}

public interface IDeletable
{
    public bool IsDeleted { get; set; }
}

public interface IAuditable:ICreatation, IModification
{
 
}

public interface ICreatation 
{
    public Guid CreateAtId { get; set; }
    public DateTime CreatedAt { get; set; }
}
public interface IModification 
{
    public Guid? UpdatedAtId { get; set; }
    public DateTime? UpdatedAt { get; set; }
}

public interface IEnable
{
    public bool IsEnabled { get; set; }
}

public interface IReadOnly
{    
}
