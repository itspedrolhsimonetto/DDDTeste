namespace Domain
{
    public class Player : IPlayer
    {
        public Guid Id { get; private set; }

        public DateTime CreatedDate { get; private set; }

        public Player()
        {
            Id = new Guid();
            CreatedDate = new DateTime();
        }

    }
}