namespace AtashiTheorycraft.Database {
	public class TrinketSlotItems {
		public static readonly Item Trinket_HandOfJustice = new Item(x => {
			x.AttackPower = 20;
			return true;
		});

		public static readonly Item Trinket_CounterattackLodestone = new Item(x => {
			x.Parry = 1;
			x.AttackPower = 22;
			return true;
		});
	}
}
