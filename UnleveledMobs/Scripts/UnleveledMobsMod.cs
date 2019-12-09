// Project:         UnleveledMobs mod for Daggerfall Unity (http://www.dfworkshop.net)
// Copyright:       Copyright (C) 2019 JayH
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Author:          JayH

using DaggerfallConnect;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Utility;
using UnityEngine;

namespace UnleveledMobs
{
    public class UnleveledMobsMod : MonoBehaviour
    {
        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject(mod.Title);
            go.AddComponent<UnleveledMobsMod>();
        }

        void Awake()
        {
            InitMod();

            mod.IsReady = true;
        }

        private static void InitMod()
        {
            Debug.Log("Begin mod init: UnleveledMobs");

            // Set new encounter tables.

            // Crypt - Index0
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.Crypt] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.Crypt,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Mummy,
                    MobileTypes.Ghost,
                    MobileTypes.Wraith,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Mummy,
                    MobileTypes.Ghost,
                    MobileTypes.Wraith,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Mummy,
                    MobileTypes.Ghost,
                    MobileTypes.Wraith,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Mummy,
                    MobileTypes.Ghost,
                    MobileTypes.Wraith,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Mummy,
                    MobileTypes.Ghost,
                    MobileTypes.Wraith,
                },
            };

            // Orc Stronghold - Index1
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.OrcStronghold] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.OrcStronghold,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.OrcSergeant,
                    MobileTypes.OrcShaman,
                    MobileTypes.OrcWarlord,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.OrcSergeant,
                    MobileTypes.OrcShaman,
                    MobileTypes.OrcWarlord,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.OrcSergeant,
                    MobileTypes.OrcShaman,
                    MobileTypes.OrcWarlord,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                },
            };

            // Human Stronghold - Index2
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.HumanStronghold] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.HumanStronghold,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                    MobileTypes.Archer,
                    MobileTypes.Spellsword,
                    MobileTypes.Archer,
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                    MobileTypes.Archer,
                    MobileTypes.Spellsword,
                    MobileTypes.Archer,
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                    MobileTypes.Archer,
                    MobileTypes.Spellsword,
                    MobileTypes.Archer,
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                    MobileTypes.Archer,
                    MobileTypes.Spellsword,
                    MobileTypes.Archer,
                },
            };

            // Prison - Index3
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.Prison] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.Prison,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Thief,
                    MobileTypes.Rogue,
                    MobileTypes.Nightblade,
                    MobileTypes.Thief,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Rogue,
                    MobileTypes.Nightblade,
                    MobileTypes.Thief,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Rogue,
                    MobileTypes.Nightblade,
                    MobileTypes.Thief,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Rogue,
                    MobileTypes.Nightblade,
                    MobileTypes.Thief,
                    MobileTypes.Burglar,
                },
            };

            // Desecrated Temple - Index4
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.DesecratedTemple] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.DesecratedTemple,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Imp,
                    MobileTypes.Imp,
                    MobileTypes.Mage,
                    MobileTypes.Healer,
                    MobileTypes.Imp,
                    MobileTypes.DaedraSeducer,
                    MobileTypes.Imp,
                    MobileTypes.Mage,
                    MobileTypes.Healer,
                    MobileTypes.Imp,
                    MobileTypes.Imp,
                    MobileTypes.Imp,
                    MobileTypes.Mage,
                    MobileTypes.Healer,
                    MobileTypes.Imp,
                    MobileTypes.DaedraSeducer,
                    MobileTypes.Imp,
                    MobileTypes.Mage,
                    MobileTypes.Healer,
                    MobileTypes.Imp,
                },
            };

            // Mine - Index5
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.Mine] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.Mine,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.GiantScorpion,
                },
            };

            // Natural Cave - Index6
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.NaturalCave] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.NaturalCave,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Healer,
                    MobileTypes.Spider,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Healer,
                    MobileTypes.Spider,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Healer,
                    MobileTypes.Spider,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                },
            };

            // Coven - Index7
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.Coven] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.Coven,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.DaedraSeducer,
                    MobileTypes.FireDaedra,
                    MobileTypes.FrostDaedra,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.Gargoyle,
                    MobileTypes.DaedraSeducer,
                    MobileTypes.FireDaedra,
                    MobileTypes.FrostDaedra,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.Gargoyle,
                    MobileTypes.DaedraSeducer,
                    MobileTypes.FireDaedra,
                    MobileTypes.FrostDaedra,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.Gargoyle,
                    MobileTypes.DaedraSeducer,
                    MobileTypes.FireDaedra,
                },
            };

            // Vampire Haunt - Index8
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.VampireHaunt] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.VampireHaunt,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Vampire,
                    MobileTypes.Vampire,
                    MobileTypes.Mummy,
                    MobileTypes.Zombie,
                    MobileTypes.Vampire,
                    MobileTypes.VampireAncient,
                    MobileTypes.Vampire,
                    MobileTypes.Vampire,
                    MobileTypes.Mummy,
                    MobileTypes.Zombie,
                    MobileTypes.Vampire,
                    MobileTypes.VampireAncient,
                    MobileTypes.Vampire,
                    MobileTypes.Vampire,
                    MobileTypes.Mummy,
                    MobileTypes.Zombie,
                    MobileTypes.Vampire,
                    MobileTypes.VampireAncient,
                    MobileTypes.Vampire,
                    MobileTypes.Vampire,
                },
            };

            // Laboratory - Index9
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.Laboratory] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.Laboratory,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.FireAtronach,
                    MobileTypes.FleshAtronach,
                    MobileTypes.IronAtronach,
                    MobileTypes.IceAtronach,
                    MobileTypes.Spellsword,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.FireAtronach,
                    MobileTypes.FleshAtronach,
                    MobileTypes.IronAtronach,
                    MobileTypes.IceAtronach,
                    MobileTypes.Spellsword,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.FireAtronach,
                    MobileTypes.FleshAtronach,
                    MobileTypes.IronAtronach,
                    MobileTypes.IceAtronach,
                    MobileTypes.Spellsword,
                    MobileTypes.Mage,
                },
            };

            // Harpy Nest - Index10
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.HarpyNest] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.HarpyNest,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.Harpy,
                    MobileTypes.GiantBat,
                    MobileTypes.Harpy,
                    MobileTypes.Harpy,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.Harpy,
                    MobileTypes.GiantBat,
                    MobileTypes.Harpy,
                    MobileTypes.Harpy,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.Harpy,
                    MobileTypes.GiantBat,
                    MobileTypes.Harpy,
                    MobileTypes.Harpy,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.Harpy,
                },
            };

            // Ruined Castle - Index11
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.RuinedCastle] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.RuinedCastle,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Assassin,
                    MobileTypes.Bard,
                    MobileTypes.Barbarian,
                    MobileTypes.Orc,
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                    MobileTypes.Assassin,
                    MobileTypes.Bard,
                    MobileTypes.Barbarian,
                    MobileTypes.Orc,
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                    MobileTypes.Assassin,
                    MobileTypes.Bard,
                    MobileTypes.Barbarian,
                    MobileTypes.Orc,
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                    MobileTypes.Assassin,
                    MobileTypes.Bard,
                },
            };

            // Spider Nest - Index12
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.SpiderNest] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.SpiderNest,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.GiantBat,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Rat,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.GiantBat,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Rat,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.GiantBat,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Rat,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                },
            };

            // Giant Stronghold - Index13
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.GiantStronghold] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.GiantStronghold,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Giant,
                    MobileTypes.Gargoyle,
                    MobileTypes.Giant,
                    MobileTypes.Giant,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Giant,
                    MobileTypes.Giant,
                    MobileTypes.Gargoyle,
                    MobileTypes.Giant,
                    MobileTypes.Giant,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Giant,
                    MobileTypes.Giant,
                    MobileTypes.Giant,
                    MobileTypes.Gargoyle,
                    MobileTypes.Giant,
                    MobileTypes.Giant,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Giant,
                    MobileTypes.Giant,
                },
            };

            // Dragon's Den - Index14
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.DragonsDen] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.DragonsDen,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Dragonling,
                    MobileTypes.Gargoyle,
                    MobileTypes.OrcWarlord,
                    MobileTypes.Knight,
                    MobileTypes.Giant,
                    MobileTypes.Werewolf,
                    MobileTypes.DaedraLord,
                    MobileTypes.Dragonling,
                    MobileTypes.Gargoyle,
                    MobileTypes.OrcWarlord,
                    MobileTypes.Knight,
                    MobileTypes.Giant,
                    MobileTypes.Wereboar,
                    MobileTypes.DaedraLord,
                    MobileTypes.Dragonling,
                    MobileTypes.Gargoyle,
                    MobileTypes.OrcWarlord,
                    MobileTypes.Knight,
                    MobileTypes.Giant,
                    MobileTypes.Werewolf,
                },
            };

            // Barbarian Stronghold - Index15
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.BarbarianStronghold] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.BarbarianStronghold,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Warrior,
                    MobileTypes.Barbarian,
                    MobileTypes.Archer,
                    MobileTypes.Rogue,
                    MobileTypes.Werewolf,
                    MobileTypes.VampireAncient,
                    MobileTypes.Barbarian,
                    MobileTypes.Archer,
                    MobileTypes.Rogue,
                    MobileTypes.Wereboar,
                    MobileTypes.VampireAncient,
                    MobileTypes.Barbarian,
                    MobileTypes.Archer,
                    MobileTypes.Rogue,
                    MobileTypes.Werewolf,
                    MobileTypes.VampireAncient,
                    MobileTypes.Barbarian,
                    MobileTypes.Archer,
                    MobileTypes.Rogue,
                    MobileTypes.Wereboar,
                },
            };

            // Volcanic Caves - Index16
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.VolcanicCaves] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.VolcanicCaves,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.FireAtronach,
                    MobileTypes.Mage,
                    MobileTypes.FireDaedra,
                    MobileTypes.Sorcerer,
                    MobileTypes.Barbarian,
                    MobileTypes.Thief,
                    MobileTypes.FireAtronach,
                    MobileTypes.Mage,
                    MobileTypes.FireDaedra,
                    MobileTypes.Sorcerer,
                    MobileTypes.Barbarian,
                    MobileTypes.Thief,
                    MobileTypes.FireAtronach,
                    MobileTypes.Mage,
                    MobileTypes.FireDaedra,
                    MobileTypes.Sorcerer,
                    MobileTypes.Barbarian,
                    MobileTypes.Thief,
                    MobileTypes.FireAtronach,
                    MobileTypes.Mage,
                },
            };

            // Scorpion Nest - Index17
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.ScorpionNest] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.ScorpionNest,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.GiantScorpion,
                    MobileTypes.GiantBat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Warrior,
                    MobileTypes.GiantScorpion,
                    MobileTypes.GiantBat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Warrior,
                    MobileTypes.GiantScorpion,
                    MobileTypes.GiantBat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Warrior,
                    MobileTypes.GiantScorpion,
                    MobileTypes.GiantBat,
                },
            };

            // Cemetery - Index18
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.Cemetery] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Burglar,
                    MobileTypes.Mummy,
                    MobileTypes.GiantBat,
                    MobileTypes.Thief,
                    MobileTypes.GiantBat,
                    MobileTypes.GiantBat,
                    MobileTypes.Burglar,
                    MobileTypes.Zombie,
                    MobileTypes.GiantBat,
                    MobileTypes.Mummy,
                    MobileTypes.GiantBat,
                    MobileTypes.GiantBat,
                    MobileTypes.Zombie,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.GiantBat,
                    MobileTypes.Thief,
                    MobileTypes.GiantBat,
                    MobileTypes.Burglar,
                    MobileTypes.GiantBat,
                },
            };

            /*
            // Cemetery - DF Unity version
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.OrcStronghold] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.Cemetery,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.GiantBat,
                    MobileTypes.Mummy,
                    MobileTypes.Spider,
                    MobileTypes.Zombie,
                    MobileTypes.Ghost,
                    MobileTypes.Wraith,
                    MobileTypes.Vampire,
                    MobileTypes.VampireAncient,
                    MobileTypes.Lich,
                },
            },*/

            // Underwater - Index19
            RandomEncounters.EncounterTables[19] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Slaughterfish,
                    MobileTypes.Slaughterfish,
                    MobileTypes.IceAtronach,
                    MobileTypes.Dreugh,
                    MobileTypes.Slaughterfish,
                    MobileTypes.Lamia,
                    MobileTypes.Slaughterfish,
                    MobileTypes.Slaughterfish,
                    MobileTypes.IceAtronach,
                    MobileTypes.Dreugh,
                    MobileTypes.Slaughterfish,
                    MobileTypes.Lamia,
                    MobileTypes.Slaughterfish,
                    MobileTypes.Slaughterfish,
                    MobileTypes.IceAtronach,
                    MobileTypes.Dreugh,
                    MobileTypes.Slaughterfish,
                    MobileTypes.Lamia,
                    MobileTypes.Slaughterfish,
                    MobileTypes.Slaughterfish,
                },
            };

            // Desert, in location, night - Index20
            RandomEncounters.EncounterTables[20] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Thief,
                    MobileTypes.Werewolf,
                    MobileTypes.Burglar,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.Vampire,
                    MobileTypes.Thief,
                    MobileTypes.Wereboar,
                    MobileTypes.Burglar,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.Vampire,
                    MobileTypes.Thief,
                    MobileTypes.Werewolf,
                    MobileTypes.Burglar,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                },
            };

            // Desert, not in location, day - Index21
            RandomEncounters.EncounterTables[21] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.GiantScorpion,
                    MobileTypes.Nymph,
                    MobileTypes.GiantBat,
                    MobileTypes.Centaur,
                    MobileTypes.Orc,
                    MobileTypes.Dragonling,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Nymph,
                    MobileTypes.GiantBat,
                    MobileTypes.Centaur,
                    MobileTypes.Orc,
                    MobileTypes.Dragonling,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Nymph,
                    MobileTypes.GiantBat,
                    MobileTypes.Centaur,
                    MobileTypes.Orc,
                    MobileTypes.Dragonling,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Nymph,
                },
            };

            // Desert, not in location, night - Index22
            RandomEncounters.EncounterTables[22] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.GiantScorpion,
                    MobileTypes.Lich,
                    MobileTypes.GiantBat,
                    MobileTypes.Vampire,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Zombie,
                    MobileTypes.VampireAncient,
                    MobileTypes.GiantScorpion,
                    MobileTypes.AncientLich,
                    MobileTypes.GiantBat,
                    MobileTypes.Vampire,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Zombie,
                    MobileTypes.Mummy,
                    MobileTypes.VampireAncient,
                    MobileTypes.Lich,
                    MobileTypes.GiantBat,
                    MobileTypes.Vampire,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Zombie,
                },
            };

            // Mountain, in location, night - Index23
            RandomEncounters.EncounterTables[23] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.Warrior,
                    MobileTypes.Rogue,
                    MobileTypes.Thief,
                    MobileTypes.Nightblade,
                    MobileTypes.Assassin,
                    MobileTypes.Werewolf,
                    MobileTypes.Rat,
                    MobileTypes.Warrior,
                    MobileTypes.Rogue,
                    MobileTypes.Thief,
                    MobileTypes.Nightblade,
                    MobileTypes.Assassin,
                    MobileTypes.Wereboar,
                    MobileTypes.Rat,
                    MobileTypes.Warrior,
                    MobileTypes.Rogue,
                    MobileTypes.Thief,
                    MobileTypes.Nightblade,
                    MobileTypes.Assassin,
                },
            };

            // Mountain, not in location, day - Index24
            RandomEncounters.EncounterTables[24] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Nymph,
                    MobileTypes.Giant,
                    MobileTypes.Rogue,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Sorcerer,
                    MobileTypes.Gargoyle,
                    MobileTypes.Werewolf,
                    MobileTypes.Nymph,
                    MobileTypes.Giant,
                    MobileTypes.Rogue,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Sorcerer,
                    MobileTypes.Gargoyle,
                    MobileTypes.Werewolf,
                    MobileTypes.Nymph,
                    MobileTypes.Giant,
                    MobileTypes.Rogue,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Sorcerer,
                    MobileTypes.Gargoyle,
                },
            };

            // Mountain, not in location, night - Index25
            RandomEncounters.EncounterTables[25] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.AncientLich,
                    MobileTypes.Daedroth,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.Mummy,
                    MobileTypes.Wraith,
                    MobileTypes.Daedroth,
                    MobileTypes.AncientLich,
                    MobileTypes.Zombie,
                    MobileTypes.Mummy,
                    MobileTypes.Lich,
                    MobileTypes.Daedroth,
                    MobileTypes.Vampire,
                    MobileTypes.Zombie,
                    MobileTypes.AncientLich,
                    MobileTypes.Wraith,
                    MobileTypes.Daedroth,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.Mummy,
                },
            };

            // Rainforest, in location, night - Index26
            RandomEncounters.EncounterTables[26] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Vampire,
                    MobileTypes.Barbarian,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Werewolf,
                    MobileTypes.Acrobat,
                    MobileTypes.Vampire,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Acrobat,
                    MobileTypes.Wereboar,
                    MobileTypes.Vampire,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Acrobat,
                    MobileTypes.Barbarian,
                },
            };

            // Rainforest, not in location, day - Index27
            RandomEncounters.EncounterTables[27] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Nymph,
                    MobileTypes.Spriggan,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Nymph,
                    MobileTypes.Spriggan,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Nymph,
                    MobileTypes.Spriggan,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Nymph,
                    MobileTypes.Spriggan,
                },
            };

            // Rainforest, not in location, night - Index28
            RandomEncounters.EncounterTables[28] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.Zombie,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.VampireAncient,
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.Zombie,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.VampireAncient,
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.Zombie,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                },
            };

            // Subtropical, in location, night - Index29
            RandomEncounters.EncounterTables[29] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Vampire,
                    MobileTypes.Barbarian,
                    MobileTypes.Wereboar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Acrobat,
                    MobileTypes.Vampire,
                    MobileTypes.Burglar,
                    MobileTypes.Wereboar,
                    MobileTypes.Bard,
                    MobileTypes.Acrobat,
                    MobileTypes.Barbarian,
                    MobileTypes.Vampire,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Wereboar,
                    MobileTypes.Barbarian,
                },
            };

            // Subtropical, not in location, day - Index30
            RandomEncounters.EncounterTables[30] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rogue,
                    MobileTypes.Nymph,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Barbarian,
                    MobileTypes.Nymph,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Archer,
                    MobileTypes.Nymph,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Thief,
                    MobileTypes.Nymph,
                },
            };

            // Subtropical, not in location, night - Index31
            RandomEncounters.EncounterTables[31] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.Zombie,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.VampireAncient,
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.Zombie,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.VampireAncient,
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.Zombie,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                },
            };

            // Swamp/woodlands, in location, night - Index32
            RandomEncounters.EncounterTables[32] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Vampire,
                    MobileTypes.Werewolf,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Wereboar,
                    MobileTypes.Vampire,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Werewolf,
                    MobileTypes.Acrobat,
                    MobileTypes.Barbarian,
                    MobileTypes.Vampire,
                    MobileTypes.Thief,
                    MobileTypes.Wereboar,
                    MobileTypes.Acrobat,
                    MobileTypes.Werewolf,
                },
            };

            // Swamp/woodlands, not in location, day - Index33
            RandomEncounters.EncounterTables[33] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Giant,
                    MobileTypes.Werewolf,
                    MobileTypes.Spriggan,
                    MobileTypes.Orc,
                    MobileTypes.Centaur,
                    MobileTypes.Dragonling,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Wereboar,
                    MobileTypes.Giant,
                    MobileTypes.Werewolf,
                    MobileTypes.OrcShaman,
                    MobileTypes.Bard,
                    MobileTypes.Werewolf,
                    MobileTypes.Archer,
                    MobileTypes.Battlemage,
                    MobileTypes.Assassin,
                    MobileTypes.Wereboar,
                    MobileTypes.Werewolf,
                    MobileTypes.Knight,
                    MobileTypes.Spellsword,
                },
            };

            // Swamp/woodlands, not in location, night - Index34
            RandomEncounters.EncounterTables[34] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.Zombie,
                    MobileTypes.Werewolf,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.VampireAncient,
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.Zombie,
                    MobileTypes.Wereboar,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.VampireAncient,
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.Zombie,
                    MobileTypes.Werewolf,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                },
            };

            // Haunted woodlands, in location, night - Index35
            RandomEncounters.EncounterTables[35] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Vampire,
                    MobileTypes.Barbarian,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Acrobat,
                    MobileTypes.Vampire,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Acrobat,
                    MobileTypes.Barbarian,
                    MobileTypes.Vampire,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Acrobat,
                    MobileTypes.Barbarian,
                },
            };

            // Haunted woodlands, not in location, day - Index36
            RandomEncounters.EncounterTables[36] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Imp,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.Spriggan,
                    MobileTypes.Spider,
                    MobileTypes.Centaur,
                    MobileTypes.Nymph,
                    MobileTypes.Dragonling,
                    MobileTypes.Harpy,
                    MobileTypes.Giant,
                    MobileTypes.Imp,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.Spriggan,
                    MobileTypes.Spider,
                    MobileTypes.Centaur,
                    MobileTypes.Nymph,
                    MobileTypes.Dragonling,
                    MobileTypes.Harpy,
                    MobileTypes.Giant,
                    MobileTypes.Imp,
                    MobileTypes.GrizzlyBear,
                },
            };

            // Haunted woodlands, not in location, night - Index37
            RandomEncounters.EncounterTables[37] = new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.AncientLich,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.VampireAncient,
                    MobileTypes.Wraith,
                    MobileTypes.Ghost,
                    MobileTypes.AncientLich,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.VampireAncient,
                    MobileTypes.Wraith,
                    MobileTypes.AncientLich,
                    MobileTypes.Ghost,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                },
            };

            Debug.Log("Finished mod init: UnleveledMobs");
        }

    }
}