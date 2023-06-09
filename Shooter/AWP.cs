using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    public class AWP : Gun, IGun
    {
        public AWP(int totalBulletCount, int currentBulletCount) : base(totalBulletCount, currentBulletCount)
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
                Console.WriteLine("AWP is Shooting...");
                Console.WriteLine("current bullet count:" + CurrentBulletCount);

            }
            catch (insufficientBulletCountException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Zoom()
        {
            Console.WriteLine("zooming");
        }
    }
}
