using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Hero
    {
        public static string _heroName;
        public static string _heroType;
        public static int _heroHealth;
        public static int _heroMana;

        
        public Hero(string heroName, string heroType, int heroHealth, int heroMana)
        {
            _heroName = heroName;
            _heroType = heroType;
            _heroHealth = heroHealth;
            _heroMana = heroMana;
        }
    }
}
