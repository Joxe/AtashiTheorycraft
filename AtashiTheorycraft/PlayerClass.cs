using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtashiTheorycraft {
	public enum Race {
		Human,
		Dwarf,
		NightElf,
		Gnome,
		Undead,
		Tauren,
		Orc,
		Troll
	};

	public abstract class PlayerClass {
		/*
		* Primary Stats
		*/
		public int Strength  { get; protected set; }
		public int Agility   { get; protected set; }
		public int Intellect { get; protected set; }
		public int Stamina   { get; protected set; }
		public int Spirit    { get; protected set; }

		/*
		 * Secondary Stats
		 */
		public int AttackPower       { get; protected set; }
		public int RangedAttackPower { get; protected set; }
		public int Dodge             { get; protected set; }
		public int Parry             { get; protected set; }
		public int Block             { get; protected set; }
		public int Armor             { get; protected set; }
		public int CritChance        { get; protected set; }
		public int Defense           { get; protected set; }
		public int AgilityPerCrit    { get; protected set; }

		public abstract int GetApPerAgility();
		public abstract int GetApPerStrength();
		public abstract int GetRangedApPerAgility();
		public abstract int GetArmorPerAgility();
		public abstract float GetAgilityPerDodge();

	}
}
