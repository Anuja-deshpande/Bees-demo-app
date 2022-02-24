namespace WebApplication1.Models
{
    public class Queen : Bees
    {
        public override float Damage(int helthpercentage)
        {
            if (!Dead)
            {
                var value = ((float)helthpercentage / Health) * 100;
                Health -= Convert.ToInt32(Math.Round(value, 0));
                if (Health <= 20)
                {
                    Health = 20;
                    Dead =true;
                }
            }
            return Health;
            throw new NotImplementedException();
        }
    }
}
