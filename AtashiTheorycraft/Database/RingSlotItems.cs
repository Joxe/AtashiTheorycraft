namespace AtashiTheorycraft.Database {
	public class RingSlotItems {
		public static readonly Item Ring_BlackstoneRing = new Item(x => {
			x.Stamina = 6;
			x.AttackPower = 20;
			x.Hit = 1;
			return true;
		});

		public static readonly Item Ring_MagnisWill = new Item(x => {
			x.Strength = 6;
			x.Stamina = 7;
			x.CritChance = 1;
			return true;
		});
	}
}
