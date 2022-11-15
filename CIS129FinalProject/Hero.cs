using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Hero
    {
        private string _heroName;
        private string _heroType;
        private int _heroHealth;
        private int _heroMana;

        
        public Hero(string _heroName, string _heroType, int _heroHealth, int _heroMana)
        {
            _heroName = _heroName;
            _heroType = _heroType;
            _heroHealth = _heroHealth;
            _heroMana = _heroMana;
        } 
    }
}
