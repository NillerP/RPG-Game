internal static class WeaponUtility
    {
        public static float Crit(float damage, float critChance, float critMultiplier)
        {
            Random random = new Random();
            double randValue = random.NextDouble();
            if (randValue < critChance)
            {
                return damage * critMultiplier;
            }
            else
            {
                return 0.0f;
            }
        }
    }