using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtashiTheorycraft {
	public class Equipment {
		public Item Head      { get; set; }
		public Item Neck      { get; set; }
		public Item Shoulders { get; set; }
		public Item Back      { get; set; }
		public Item Chest     { get; set; }
		public Item Wrist     { get; set; }
		public Item Hands     { get; set; }
		public Item Waist     { get; set; }
		public Item Legs      { get; set; }
		public Item Feet      { get; set; }
		public Item Ring1     { get; set; }
		public Item Ring2     { get; set; }
		public Item Trinket1  { get; set; }
		public Item Trinket2  { get; set; }
		public Item MainHand  { get; private set; }
		public Item OffHand   { get; private set; }
		public Item Ranged    { get; set; }

		private List<Item> GetAllEquipment() {
			return new List<Item> {
				Head,     Neck,     Shoulders, Back,    Chest, Wrist, 
				Hands,    Waist,    Legs,      Feet,    Ring1, Ring2, 
				Trinket1, Trinket2, MainHand,  OffHand, Ranged
			};
		}

		public void EquipWeapon(Weapon a_weapon) {
			switch (a_weapon.WeaponSlot) {
				case WeaponSlots.MainHand: {
					MainHand = a_weapon;
					break;
				}
				case WeaponSlots.OffHand: {
					OffHand = a_weapon;
					break;
				}
				case WeaponSlots.OneHand: {
					if (MainHand == null) {
						MainHand = a_weapon;
					} else {
						if (OffHand == null) {
							OffHand = a_weapon;
						} else {
							MainHand = a_weapon;
						}
					}
					break;
				}
				case WeaponSlots.Ranged: {
					Ranged = a_weapon;
					break;
				}
				case WeaponSlots.TwoHand: {
					MainHand = a_weapon;
					OffHand = null;
					break;
				}
			}
		}

		public int GetAttackPower() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.AttackPower);
		}

		public int GetRangedAttackPower() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.RangedAttackPower);
		}

		internal float GetParry() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Parry);
		}

		public int GetStrength() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Strength);
		}

		internal float GetBlock() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Block);
		}

		public int GetAgility() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Agility);
		}

		public int GetIntellect() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Intellect);
		}

		public int GetDefense() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Defense);
		}

		internal int GetArmor() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Armor);
		}

		public int GetStamina() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Stamina);
		}

		public int GetSpirit() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Spirit);
		}

		internal float GetCritChance() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.CritChance);
		}

		public float GetDodge() {
			return GetAllEquipment().Where(x => x != null).Sum(x => x.Dodge);
		}
	}
}
