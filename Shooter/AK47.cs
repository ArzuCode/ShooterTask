using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    public class AK47 : Gun
    {
        public AK47(int totalBulletCount, int currentBulletCount) : base(totalBulletCount, currentBulletCount)
        {
        }
        public override void Shoot()
        {
            try
            {
                if (CurrentBulletCount <= 0)
                {
                    throw new insufficientBulletCountException();

                }
                CurrentBulletCount--;
                Console.WriteLine ( "AK47 is Shooting...");
                Console.WriteLine ( "current bullet count:" + CurrentBulletCount);

            }
            catch (insufficientBulletCountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}