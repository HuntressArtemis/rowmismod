using rowmismod.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace rowmismod.Content.Items.Weapons
{
	public class FireWhip : ModItem
	{
		public override void SetDefaults() {
			// Call this method to quickly set some of the properties below.
			//Item.DefaultToWhip(ModContent.ProjectileType<ExampleWhipProjectileAdvanced>(), 20, 2, 4);

			Item.DamageType = DamageClass.Magic;
			Item.damage = 100;
			Item.knockBack = 3;
			Item.rare = ItemRarityID.Yellow;

			Item.shoot = ModContent.ProjectileType<FireWhipProjectile>();
			Item.shootSpeed = 4;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 30;
			Item.useAnimation = 30;
			Item.UseSound = SoundID.Item152;
			Item.noMelee = true;
			Item.noUseGraphic = true;
			Item.mana = 20;
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Wood,5)
				.AddTile(TileID.WorkBenches)
				.Register();
		}

		// Makes the whip receive melee prefixes
		public override bool MagicPrefix() {
			return true;
		}
	}
}