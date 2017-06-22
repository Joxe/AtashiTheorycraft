using System;

namespace AtashiTheorycraft {
	public enum WeaponTypes {
		Sword,
		Mace,
		Dagger,
		Fist,
		Axe,
		Bow,
		Gun,
		Throwing
	};

	public enum WeaponSlots {
		MainHand,
		OffHand,
		OneHand,
		TwoHand,
		Ranged
	};

	public class Weapon : Item {
		public Weapon(Predicate<Weapon> a_initPred) {
			a_initPred(this);
		}

		public int         MinDamage   { get; set; }
		public int         MaxDamage   { get; set; }
		public float       AttackSpeed { get; set; }
		public WeaponTypes WeaponType  { get; set; }
		public WeaponSlots WeaponSlot  { get; set; }

		public float GetDps() {
			return ((MinDamage + MaxDamage) / 2) / AttackSpeed;
		}
	}
}
