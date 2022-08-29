namespace Domain
{
    public class Level
    {
        public Guid Id { get; private set; }

        public int Number { get; private set; }

        public bool IsDone { get; set; }

        private Level()
        {
            Id = new Guid();
            Number = 1;
            IsDone = false;
        }

        public Level(int number) : this()
        {
            if (number < 1) throw new Exception("parametro number nao pode ser menor que um");

            Number = number;
        }

        public void EndLevel(IPlayerBank playerBank, IPlayerProgress playerProgress)
        {
            if(!IsDone && playerProgress.Level < Number - 1)
            {
                throw new Exception("parametro number nao pode ser menor que o nível atual do jogador");
            }

            playerProgress.UpdateLevel();
            IsDone = true;
        }

    }
}