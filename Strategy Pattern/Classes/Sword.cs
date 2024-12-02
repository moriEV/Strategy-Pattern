using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Classes
{
    internal class Sword : IWeapon
    {
        public void UseWeapon()
        {
            Console.WriteLine("Sword Attack");
        }
    }
}
