namespace AtashiTheorycraft.Database {
	public class RangedSlotItems {
		public static readonly Weapon Ranged_MandokirsSting = new Weapon(x => {
			x.Agility = 11;
			x.Stamina = 8;
			x.AttackSpeed = 2.6f;
			x.MinDamage = 68;
			x.MaxDamage = 127;
			x.WeaponSlot = WeaponSlots.Ranged;
			x.WeaponType = WeaponTypes.Bow;
			return true;
		});
	}
}
