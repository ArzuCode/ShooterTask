using System.Security.Cryptography.X509Certificates;

namespace Shooter
{
    public class Program
    {
        static void Main(string[] args)
        {
            M4 m4 = new M4(30,  30);
            m4.Shoot();
            m4.Reload();

            AK47 aK47 = new AK47(32 , 32);
            aK47.Shoot();
            aK47.Reload();

            P92 p92 = new P92(60, 60);
            p92.Zoom();
            p92.Shoot();
            p92.Reload();
            

            AWP aWP = new AWP(10, 10);
            aWP.Zoom();
            aWP.Shoot();
            aWP.Reload();

            




        }
    }
}