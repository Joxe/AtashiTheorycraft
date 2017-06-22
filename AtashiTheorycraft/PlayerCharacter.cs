using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtashiTheorycraft {
	public class Character {
		public Race        Race  { get; set; }
		public int         Level { get; set; }
		public PlayerClass Class { get; set; }
		public Equipment Equipment { get; private set; } = new Equipment();

		public int GetStrength() {
			return Class.Strength + Equipment.GetStrength();
		}

		public int GetAgility() {
			return Class.Agility + Equipment.GetAgility();
		}

		public int GetIntellect() {
			return Class.Intellect + Equipment.GetIntellect();
		}

		public int GetStamina() {
			return Class.Stamina + Equipment.GetStamina();
		}

		public int GetSpirit() {
			return Class.Spirit + Equipment.GetSpirit();
		}

		public float GetDodge() {
			float classDodge = Class.Dodge;
			float equipDodge = Equipment.GetDodge();
			float statDodge  = (Class.Agility + Equipment.GetAgility()) / Class.GetAgilityPerDodge();

			return classDodge + equipDodge + statDodge;
		}

		public float GetParry(Character a_attacker) {
			float classParry = Class.Parry;
			float equipParry = Equipment.GetParry();
			float statParry  = (Class.Defense - (a_attacker != null ? a_attacker.GetDefense() : 315)) * 0.04f;

			return classParry + equipParry + statParry;
		}

		public float GetBlock(Character a_attacker) {
			float classBlock = Class.Block;
			float equipBlock = Equipment.GetBlock();
			float statBlock  = (Class.Defense - (a_attacker != null ? a_attacker.GetDefense() : 315)) * 0.04f;

			return classBlock + equipBlock + statBlock;
		}

		private int GetDefense() {
			int classDefense = 5 * Level;
			int equipDefense = Equipment.GetDefense();

			return classDefense + equipDefense;
		}

		public int GetArmor() {
			int classArmor = Class.Armor;
			int equipArmor = Equipment.GetArmor();
			int statArmor = GetAgility() * Class.GetArmorPerAgility();

			return classArmor + equipArmor + statArmor;
		}

		public float GetCritChance() {
			float classCrit = Class.CritChance;
			float equipCrit = Equipment.GetCritChance();
			float statCrit = (Class.Agility + Equipment.GetAgility()) / Class.AgilityPerCrit;

			return classCrit + equipCrit + statCrit;
		}

		public int GetAttackPower() {
			int classAp = Class.AttackPower;
			int agility = Class.Agility + Equipment.GetAgility(); 
			int strength = Class.Strength + Equipment.GetStrength();

			return classAp + (agility * Class.GetApPerAgility()) + (strength * Class.GetApPerStrength()) + Equipment.GetAttackPower();
		}

		public int GetRangedAttackPower() {
			int classRAp = Class.RangedAttackPower;
			int equipRAp = Equipment.GetAttackPower() + Equipment.GetRangedAttackPower();
			int agility = Class.Agility + Equipment.GetAgility();

			return ((classRAp + agility) * Class.GetRangedApPerAgility()) + equipRAp;
		}

		public override string ToString() {
			StringBuilder sb = new StringBuilder();

			sb.Append("Strength: ");
			sb.AppendLine(GetStrength().ToString());
			sb.Append("Agility: ");
			sb.AppendLine(GetAgility().ToString());
			sb.Append("Stamina: ");
			sb.AppendLine(GetStamina().ToString());
			sb.Append("Intellect: ");
			sb.AppendLine(GetIntellect().ToString());
			sb.Append("Spirit: ");
			sb.AppendLine(GetSpirit().ToString());

			sb.AppendLine();

			sb.Append("Attack Power: ");
			sb.AppendLine(GetAttackPower().ToString());
			sb.Append("Ranged Attack Power: ");
			sb.AppendLine(GetRangedAttackPower().ToString());
			sb.Append("Defense: ");
			sb.AppendLine(GetDefense().ToString());
			sb.Append("Armor: ");
			sb.AppendLine(GetArmor().ToString());
			sb.Append("Dodge: ");
			sb.AppendLine(GetDodge().ToString());
			sb.Append("Parry: ");
			sb.AppendLine(GetParry(null).ToString());
			sb.Append("Block: ");
			sb.AppendLine(GetBlock(null).ToString());

			return sb.ToString();
		}
	}
}
