namespace WebApplication1.Models
{
    public class Drone : Bees
    {
        public override float Damage(int helthpercentage)
        {
            if (!Dead)
            {
                var value = ((float)helthpercentage / Health) * 100;
                Health -= Convert.ToInt32(Math.Round(value, 0));
                if (Health <= 50)
                {
                    Health = 50;
                    Dead =true;
                }
            }
            return Health;
            throw new NotImplementedException();
        }
    }
}
