namespace Domain
{
    public class PlayerProgress : IPlayerProgress
    {
        public Guid Id { get; private set; }

        public int Level { get; private set; }
        private PlayerProgress()
        {
            Id = Guid.Empty;
            Level = 1;
        }

        public PlayerProgress(IPlayer player) : this()
        {
            Id = player.Id;
        }

        public void UpdateLevel()
        {
            Level ++;
        }

    }

    public interface IPlayerProgress
    {
        Guid Id { get; }
        int Level { get; }

        void UpdateLevel();
    }
}
