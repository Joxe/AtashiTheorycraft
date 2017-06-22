namespace AtashiTheorycraft.Database {
	public class HeadSlotItems {
		public static readonly Item Head_MaskOfTheUnforgiven = new Item(x => {
			x.Armor = 132;
			x.Stamina = 12;
			x.Hit = 2;
			x.CritChance = 2;
			return true;
		});
	}
}
