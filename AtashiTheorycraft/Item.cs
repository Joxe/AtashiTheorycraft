using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtashiTheorycraft {
	public class Item {
		protected Item() {

		}

		public Item(Predicate<Item> a_initPred) {
			a_initPred(this);
		}
		/*
		* Primary Stats
		*/
		public int Strength  { get; set; }
		public int Agility   { get; set; }
		public int Intellect { get; set; }
		public int Stamina   { get; set; }
		public int Spirit    { get; set; }

		/*
		* Secondary Stats
		*/
		public int AttackPower       { get; set; }
		public int RangedAttackPower { get; set; }
		public int Dodge             { get; set; }
		public int Parry             { get; set; }
		public int Block             { get; set; }
		public int Armor             { get; set; }
		public int CritChance        { get; set; }
		public int Defense           { get; set; }
		public int Hit               { get; set; }

		public virtual void OnStruck(Character a_attacker) {
			//Do nothing if default
		}
	}
}
