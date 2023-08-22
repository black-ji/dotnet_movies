namespace movies.core.Entities.Base;

public interface IEntityBase<TId>
{
    TId Id { get; }
}