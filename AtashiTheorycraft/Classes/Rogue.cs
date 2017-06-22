using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtashiTheorycraft.Classes {
	public class Rogue : PlayerClass {
		public Rogue() {
			Agility = 130;
			Strength = 80;
			Stamina = 75;
			Intellect = 35;
			Spirit = 54;

			AttackPower = 100;
			RangedAttackPower = 50;
			Dodge = 0;
			Parry = 5;
			Block = 0;
			CritChance = 0;
			AgilityPerCrit = 29;
		}

		public override float GetAgilityPerDodge() {
			return 14.5f;
		}

		public override int GetApPerAgility() {
			return 1;
		}

		public override int GetApPerStrength() {
			return 1;
		}

		public override int GetArmorPerAgility() {
			return 2;
		}

		public override int GetRangedApPerAgility() {
			return 1;
		}
	}
}
