using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtashiTheorycraft {
	class Program {
		static void Main(string[] args) {
			Character aselina = new Character();
			aselina.Race = Race.Human;
			aselina.Level = 60;
			aselina.Class = new Classes.Rogue();

			aselina.Equipment.Head = Database.HeadSlotItems.Head_MaskOfTheUnforgiven;
			aselina.Equipment.Neck = Database.NeckSlotItems.Neck_MarkOfFordring;
			aselina.Equipment.Shoulders = Database.ShoulderSlotItems.Neck_TrueStrikeShoulders;
			aselina.Equipment.Back = Database.BackSlotItems.Back_StoneskinGargoyleCape;
			aselina.Equipment.Chest = Database.ChestSlotItems.Chest_CharredLeatherTunic;
			aselina.Equipment.Wrist = Database.WristSlotItems.Wrist_ShadowcraftBracers;
			aselina.Equipment.Hands = Database.HandsSlotItems.Hands_ShadowcraftBracers;
			aselina.Equipment.Waist = Database.WaistSlotItems.Waist_NightslayerBelt;
			aselina.Equipment.Legs = Database.LegsSlotItems.Legs_DevilsaurLeggings;
			aselina.Equipment.Feet = Database.FeetSlotItems.Feet_BlooddrenchedFootpads;
			aselina.Equipment.Ring1 = Database.RingSlotItems.Ring_BlackstoneRing;
			aselina.Equipment.Ring2 = Database.RingSlotItems.Ring_MagnisWill;
			aselina.Equipment.Trinket1 = Database.TrinketSlotItems.Trinket_CounterattackLodestone;
			aselina.Equipment.Trinket2 = Database.TrinketSlotItems.Trinket_HandOfJustice;
			aselina.Equipment.EquipWeapon(Database.WeaponSlotItems.Weapon_ZulianSlicer);
			aselina.Equipment.EquipWeapon(Database.WeaponSlotItems.Weapon_MirahsSong);
			aselina.Equipment.EquipWeapon(Database.RangedSlotItems.Ranged_MandokirsSting);

			Console.WriteLine(aselina);
			Console.Read();
		}
	}
}
