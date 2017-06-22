namespace AtashiTheorycraft.Database {
	public class WeaponSlotItems {
		public static readonly Weapon Weapon_ZulianSlicer = new Weapon(x => {
			x.AttackPower = 12;
			x.AttackSpeed = 2.5f;
			x.MinDamage = 78;
			x.MaxDamage = 146;
			x.WeaponSlot = WeaponSlots.OneHand;
			x.WeaponType = WeaponTypes.Sword;
			return true;
		});

		public static readonly Weapon Weapon_MirahsSong = new Weapon(x => {
			x.Strength = 9;
			x.Agility = 9;
			x.AttackSpeed = 1.8f;
			x.MinDamage = 57;
			x.MaxDamage = 87;
			x.WeaponSlot = WeaponSlots.OneHand;
			x.WeaponType = WeaponTypes.Sword;
			return true;
		});

		public static readonly Weapon Weapon_DalRendsSacredCharge = new Weapon(x => {
			x.Strength = 4;
			x.CritChance = 1;
			x.AttackSpeed = 2.8f;
			x.MinDamage = 81;
			x.MaxDamage = 151;
			x.WeaponSlot = WeaponSlots.MainHand;
			x.WeaponType = WeaponTypes.Sword;
			return true;
		});

		public static readonly Weapon Weapon_SkullforgeReaver = new Weapon(x => {
			x.AttackSpeed = 2.5f;
			x.MinDamage = 72;
			x.MaxDamage = 135;
			x.WeaponSlot = WeaponSlots.OneHand;
			x.WeaponType = WeaponTypes.Sword;
			return true;
		});
	}
}
