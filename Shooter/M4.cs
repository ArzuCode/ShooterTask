using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shooter
{
    public  class M4 : Gun
    {
        public M4(int TotalBulletCount,int CurrentBulletCount) : base  (TotalBulletCount, CurrentBulletCount)
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
                Console.WriteLine(  "M4 is Shooting...");
                Console.WriteLine( "current bullet count:" + CurrentBulletCount);

            }
            catch (insufficientBulletCountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
