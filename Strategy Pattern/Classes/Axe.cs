using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Classes
{
    internal class Axe : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Sword Attack");
        }
    }
}
