using Shooter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    public abstract class Gun
    {

        protected Gun(int totalBulletCount, int currentBulletCount)
        {
            TotalBulletCount = totalBulletCount;
            CurrentBulletCount = currentBulletCount;
        }



        public int TotalBulletCount { get; set; }

        public int CurrentBulletCount { get; set; }

        public virtual void Shoot()
        {
            CurrentBulletCount--;
            if (CurrentBulletCount == 0)
            {
                return;
            }
            Reload();
        }

        public virtual void Reload()
        {
            CurrentBulletCount = TotalBulletCount;
            Console.WriteLine("Bullet Reloading...");
            Console.WriteLine("current bullet count:" + TotalBulletCount);
        }
        
    }   
}
