using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Classes
{
    internal class Player
    {
        private IWeapon weapon;
        private string name;
        public Player(IWeapon weapon, string name)
        {
            this.weapon = weapon;
            this.name = name;
        }
        public void SetWeapon(IWeapon weapon)
        {
            this.weapon = weapon;
        }
        public void UseWeapon()
        {
            this.weapon.UseWeapon();
        }
    }
}
