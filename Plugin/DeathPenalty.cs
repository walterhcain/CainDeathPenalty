using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Steamworks;
using Rocket.Unturned.Events;
using Rocket.Core.Logging;
using System;

namespace walterhcain.DeathPenalty
{
    public class DeathPenalty : RocketPlugin<DeathPenaltyConfiguration>
    {

        private string version = "Version 1.0.0";
        private int invPages = PlayerInventory.PAGES - 1;
        private System.Random rand = new Random();

        protected override void Load()
        {
            UnturnedPlayerEvents.OnPlayerDeath += UnturnedPlayerEvents_OnPlayerDeath;
            Logger.Log("Cain's Custom Death Penalties has successfully loaded", ConsoleColor.Yellow);
            Logger.Log(version, ConsoleColor.Yellow);
        }

        protected override void Unload()
        {
            UnturnedPlayerEvents.OnPlayerDeath -= UnturnedPlayerEvents_OnPlayerDeath;
            Logger.Log("Cain's Custom Death Penalties has successfully unloaded", ConsoleColor.Yellow);
        }

        private void UnturnedPlayerEvents_OnPlayerDeath(UnturnedPlayer player, EDeathCause cause, ELimb limb, CSteamID murderer)
        {
            if (Configuration.Instance.logOnPlayerDeath)
            {

                if (cause == EDeathCause.ACID)
                {
                    if (Configuration.Instance.AcidClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.AcidIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.AcidIPercentage);
                    }
                    if (Configuration.Instance.Acidpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Acidpercentage);
                    }
                }
                else if (cause == EDeathCause.ANIMAL)
                {
                    if (Configuration.Instance.AnimalClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.AnimalIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.AnimalIPercentage);
                    }
                    if (Configuration.Instance.Animalpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Animalpercentage);
                    }
                }
                else if (cause == EDeathCause.ARENA)
                {
                    if (Configuration.Instance.ArenaClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.ArenaIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.ArenaIPercentage);
                    }
                    if (Configuration.Instance.Arenapercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Arenapercentage);
                    }
                }
                else if (cause == EDeathCause.BLEEDING)
                {
                    if (Configuration.Instance.BleedingClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.BleedingIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.BleedingIPercentage);
                    }
                    if (Configuration.Instance.Bleedingpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Bleedingpercentage);
                    }
                }
                else if (cause == EDeathCause.BONES)
                {
                    if (Configuration.Instance.BonesClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.BonesIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.BonesIPercentage);
                    }
                    if (Configuration.Instance.Bonespercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Bonespercentage);
                    }
                }
                else if (cause == EDeathCause.BOULDER)
                {
                    if (Configuration.Instance.BoulderClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.BoulderIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.BoulderIPercentage);
                    }
                    if (Configuration.Instance.Boulderpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Boulderpercentage);
                    }
                }
                else if (cause == EDeathCause.BREATH)
                {
                    if (Configuration.Instance.BreathClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.BreathIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.BreathIPercentage);
                    }
                    if (Configuration.Instance.Breathpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Breathpercentage);
                    }
                }
                else if (cause == EDeathCause.BURNER)
                {
                    if (Configuration.Instance.BurnerClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.BurnerIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.BurnerIPercentage);
                    }
                    if (Configuration.Instance.Burnerpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Burnerpercentage);
                    }
                }
                else if (cause == EDeathCause.BURNING)
                {
                    if (Configuration.Instance.BurningClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.BurningIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.BurningIPercentage);
                    }
                    if (Configuration.Instance.Burningpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Burningpercentage);
                    }
                }
                else if (cause == EDeathCause.CHARGE)
                {
                    if (Configuration.Instance.ChargeClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.ChargeIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.ChargeIPercentage);
                    }
                    if (Configuration.Instance.Chargepercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Chargepercentage);
                    }
                }
                else if (cause == EDeathCause.FOOD)
                {
                    if (Configuration.Instance.FoodClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.FoodIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.FoodIPercentage);
                    }
                    if (Configuration.Instance.Foodpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Foodpercentage);
                    }
                }
                else if (cause == EDeathCause.FREEZING)
                {
                    if (Configuration.Instance.FreezingClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.FreezingIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.FreezingIPercentage);
                    }
                    if (Configuration.Instance.Freezingpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Freezingpercentage);
                    }
                }
                else if (cause == EDeathCause.GRENADE)
                {
                    if (Configuration.Instance.GrenadeClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.GrenadeIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.GrenadeIPercentage);
                    }
                    if (Configuration.Instance.Grenadepercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Grenadepercentage);
                    }
                }
                else if (cause == EDeathCause.GUN)
                {
                    if (Configuration.Instance.GunClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.GunIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.GunIPercentage);
                    }
                    if (Configuration.Instance.Gunpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Gunpercentage);
                    }
                }
                else if (cause == EDeathCause.INFECTION)
                {
                    if (Configuration.Instance.InfectionClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.InfectionIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.InfectionIPercentage);
                    }
                    if (Configuration.Instance.Infectionpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Infectionpercentage);
                    }
                }
                else if (cause == EDeathCause.LANDMINE)
                {
                    if (Configuration.Instance.LandmineClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.LandmineIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.LandmineIPercentage);
                    }
                    if (Configuration.Instance.Landminepercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Landminepercentage);
                    }
                }
                else if (cause == EDeathCause.MELEE)
                {
                    if (Configuration.Instance.MeleeClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.MeleeIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.MeleeIPercentage);
                    }
                    if (Configuration.Instance.Meleepercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Meleepercentage);
                    }
                }
                else if (cause == EDeathCause.MISSILE)
                {
                    if (Configuration.Instance.MissileClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.MissileIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.MissileIPercentage);
                    }
                    if (Configuration.Instance.Missilepercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Missilepercentage);
                    }
                }
                else if (cause == EDeathCause.PUNCH)
                {
                    if (Configuration.Instance.PunchClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.PunchIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.PunchIPercentage);
                    }
                    if (Configuration.Instance.Punchpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Punchpercentage);
                    }
                }
                else if (cause == EDeathCause.ROADKILL)
                {
                    if (Configuration.Instance.RoadkillClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.RoadkillIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.RoadkillIPercentage);
                    }
                    if (Configuration.Instance.Roadkillpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Roadkillpercentage);
                    }
                }
                else if (cause == EDeathCause.SENTRY)
                {
                    if (Configuration.Instance.SentryClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.SentryIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.SentryIPercentage);
                    }
                    if (Configuration.Instance.Sentrypercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Sentrypercentage);
                    }
                }
                else if (cause == EDeathCause.SHRED)
                {
                    if (Configuration.Instance.ShredClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.ShredIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.ShredIPercentage);
                    }
                    if (Configuration.Instance.Shredpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Shredpercentage);
                    }
                }
                else if (cause == EDeathCause.SPARK)
                {
                    if (Configuration.Instance.SparkClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.SparkIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.SparkIPercentage);
                    }
                    if (Configuration.Instance.Sparkpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Sparkpercentage);
                    }
                }
                else if (cause == EDeathCause.SPIT)
                {
                    if (Configuration.Instance.SpitClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.SpitIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.SpitIPercentage);
                    }
                    if (Configuration.Instance.Spitpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Spitpercentage);
                    }
                    player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Spitpercentage);
                }
                else if (cause == EDeathCause.SPLASH)
                {
                    if (Configuration.Instance.SplashClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.SplashIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.SplashIPercentage);
                    }
                    if (Configuration.Instance.Splashpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Splashpercentage);
                    }
                }
                else if (cause == EDeathCause.SUICIDE)
                {
                    if (Configuration.Instance.SuicideClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.SuicideIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.SuicideIPercentage);
                    }
                    if (Configuration.Instance.Suicidepercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Suicidepercentage);
                    }
                }
                else if (cause == EDeathCause.VEHICLE)
                {
                    if (Configuration.Instance.VehicleClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.VehicleIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.VehicleIPercentage);
                    }
                    if (Configuration.Instance.Vehiclepercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Vehiclepercentage);
                    }
                }
                else if (cause == EDeathCause.WATER)
                {
                    if (Configuration.Instance.WaterClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.WaterIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.WaterIPercentage);
                    }
                    if (Configuration.Instance.Waterpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Waterpercentage);
                    }
                }
                else if (cause == EDeathCause.ZOMBIE)
                {
                    if (Configuration.Instance.ZombieClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if (Configuration.Instance.ZombieIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.ZombieIPercentage);
                    }
                    if (Configuration.Instance.Zombiepercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Zombiepercentage);
                    }
                }
                else if (cause == EDeathCause.KILL)
                {
                    if (Configuration.Instance.KillClothes)
                    {
                        ClearAllClothes(player);
                    }
                    if(Configuration.Instance.KillIPercentage != 0)
                    {
                        int itemc = player.Player.inventory.items.Length;
                        ClearRandomItems(player, itemc, Configuration.Instance.KillIPercentage);
                    }
                    if(Configuration.Instance.Killpercentage != 1)
                    {
                        player.Experience = Convert.ToUInt32(player.Experience * Configuration.Instance.Killpercentage);
                    }
                    
                }
            }
        }

        private void ClearRandomItems(UnturnedPlayer player, int oldamount, double percent)
        {
            
            int amount = (int)(oldamount * percent);
            while (amount > 0)
            {
                byte page = Convert.ToByte(rand.Next(0, invPages));
                byte itemsCountOnPage = player.Player.inventory.getItemCount(page);

                if (itemsCountOnPage > 0)
                {
                    byte index = Convert.ToByte(rand.Next(0, itemsCountOnPage));
                    try
                    {
                        player.Player.inventory.askDropItem(player.CSteamID, page, player.Inventory.getItem(page, index).x, player.Inventory.getItem(page, index).y);
                        amount--;
                    }
                    catch (Exception e)
                    {
                        
                            Logger.LogWarning("Warning: Cant ClearRandomItem for player " + player.CharacterName);
                            Logger.LogWarning("Warning: Full problem description: " + e.Message);
                        
                    }
                }
            }
        }

        private void ClearAllClothes(UnturnedPlayer player)
        {
            try
            {
                player.Player.clothing.askWearBackpack(0, 0, new byte[0], true);
                ClearAllItems(player);

                player.Player.clothing.askWearGlasses(0, 0, new byte[0], true);
                ClearAllItems(player);

                player.Player.clothing.askWearHat(0, 0, new byte[0], true);
                ClearAllItems(player);

                player.Player.clothing.askWearMask(0, 0, new byte[0], true);
                ClearAllItems(player);

                player.Player.clothing.askWearPants(0, 0, new byte[0], true);
                ClearAllItems(player);

                player.Player.clothing.askWearShirt(0, 0, new byte[0], true);
                ClearAllItems(player);

                player.Player.clothing.askWearVest(0, 0, new byte[0], true);
                ClearAllItems(player);
            }
            catch (Exception e)
            { 
                    Logger.LogWarning("Warning: Cant clean clothes for player " + player.CharacterName);
                    Logger.LogWarning("Warning: Full problem description: " + e.Message);
                
            }
        }

        private void ClearAllItems(UnturnedPlayer player)
        {
            for (byte page = 0; page < invPages; page++)
            {
                byte itemCount = player.Player.inventory.getItemCount(page);

                for (byte index = 0; index < itemCount; index++)
                {
                    try
                    {
                        player.Player.inventory.askDropItem(player.CSteamID, page, player.Inventory.getItem(page, index).x, player.Inventory.getItem(page, index).y);
                        index--;
                        itemCount--;
                    }
                    catch (Exception e)
                    {
                   
                            Logger.LogWarning("Warning: Cant clean inventory for player " + player.CharacterName);
                            Logger.LogWarning("Warning: Full problem description: " + e.Message);
                        
                    }
                }
            }
        }
    }
}
