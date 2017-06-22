namespace AtashiTheorycraft.Database {
	public class WaistSlotItems {
		public static readonly Item Waist_NightslayerBelt = new Item(x => {
			x.Armor = 113;
			x.Strength = 9;
			x.Agility = 17;
			x.Stamina = 18;
			x.CritChance = 1;
			return true;
		});
	}
}
