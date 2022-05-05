using System;

namespace TamagotchiAPI.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; } = DateTime.Now;
        public int HungerLevel { get; set; }
        public int HappinessLevel { get; set; }

        // Adventure mode
        public DateTime LastInteractedWith { get; set; } = DateTime.Now;
        public bool IsDead { get; set; } = false;

        public bool HasPulse()
        {
            if (LastInteractedWith.AddDays(3) < DateTime.Now)
            {
                IsDead = true;
            }
            else
            {
                IsDead = false;
            }
            return IsDead;
        }

    }
}