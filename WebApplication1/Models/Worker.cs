namespace WebApplication1.Models
{
    public class Worker : Bees
    {
        public override float Damage(int helthpercentage)
        {
            if (!Dead)
            {

                var value = ((float)helthpercentage / Health) * 100;
                Health -= value;
                if (Health <= 70)
                {
                    Health = 70;
                    Dead = true;
                }

            }
            return Health;
            throw new NotImplementedException();
        }
    }
}
