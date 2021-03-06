using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public class Rifle : Gun, IGun
    {
        private const int InitialBulletsPerBarrel = 50;
        private const int InitialTotalBullets = 500;
        private const int BulletsPerFire = 5;
        public Rifle(string name) 
            : base(name, InitialBulletsPerBarrel, InitialTotalBullets)
        {

        }

        public override int Fire()
        {
            if (this.BulletsPerBarrel > 0)
            {
                this.BulletsPerBarrel -= BulletsPerFire;
            }
            else if (this.BulletsPerBarrel == 0)
            {
                if (this.TotalBullets > 0)
                {
                    this.BulletsPerBarrel = InitialBulletsPerBarrel;
                    this.TotalBullets -= BulletsPerBarrel;
                    this.BulletsPerBarrel -= BulletsPerFire;
                }
                else
                {
                    CanFire.Equals(false);
                    return 0;
                }
            }
            return BulletsPerFire;
        }
    }
}
