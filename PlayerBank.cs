namespace Domain
{
    public class PlayerBank : IPlayerBank
    {
        public Guid Id { get; private set; }
        public int Coins { get; private set; }
        public bool CanPlay => LastPlayed.Add(TimeSpan.FromHours(1)) <= DateTime.Now;

        public DateTime LastPlayed { get; set; }

        private PlayerBank()
        {
            Id = Guid.Empty;
            Coins = 0;
            LastPlayed = DateTime.Now;
        }

        public PlayerBank(IPlayer player) : this()
        {
            Id = player.Id;
        }
        

    }

    public interface IPlayerBank
    {
        Guid Id { get;}
        int Coins { get;}
        bool CanPlay { get; }
    }
}