namespace Domain
{
    public interface IPlayer
    {
        Guid Id { get; }
        DateTime CreatedDate { get; }
    }
}