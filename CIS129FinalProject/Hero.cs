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

        
        public Hero(string _heroName, string _heroType, int _heroHealth, int _heroMana)
        {
            _heroName = _heroName;
            _heroType = _heroType;
            _heroHealth = _heroHealth;
            _heroMana = _heroMana;
        } 
    }
}
