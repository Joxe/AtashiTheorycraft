namespace AtashiTheorycraft.Database {
	public class HandsSlotItems {
		public static readonly Item Hands_ShadowcraftBracers = new Item(x => {
			x.Armor = 103;
			x.Stamina = 9;
			x.AttackPower = 28;
			x.CritChance = 1;
			return true;
		});
	}
}
