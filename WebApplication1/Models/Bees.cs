namespace WebApplication1.Models
{
    public abstract class Bees
    {
        public float Health { get; set; }
        public bool Dead { get; set; }

        public string Type { get; set; }
        public Bees()
        {
            Dead = false;
            Health= 100;
            Type= GetType().Name.ToString();
        }

        abstract public float Damage(int helthpercentage);

    }
}
