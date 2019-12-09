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
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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
            new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.NaturalCave,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spriggan,
                    MobileTypes.Spider,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spriggan,
                    MobileTypes.Spider,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spriggan,
                    MobileTypes.Spider,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                },
            };

            // Coven - Index7
            new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.Coven,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Nymph,
                    MobileTypes.FireDaedra,
                    MobileTypes.FrostDaedra,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.Gargoyle,
                    MobileTypes.Nymph,
                    MobileTypes.FireDaedra,
                    MobileTypes.FrostDaedra,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.Gargoyle,
                    MobileTypes.Nymph,
                    MobileTypes.FireDaedra,
                    MobileTypes.FrostDaedra,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.Gargoyle,
                    MobileTypes.Nymph,
                    MobileTypes.FireDaedra,
                },
            };

            // Vampire Haunt - Index8
            new RandomEncounterTable()
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
            new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.Laboratory,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.FireAtronach,
                    MobileTypes.FleshAtronach,
                    MobileTypes.IronAtronach,
                    MobileTypes.IceAtronach,
                    MobileTypes.Sorcerer,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.FireAtronach,
                    MobileTypes.FleshAtronach,
                    MobileTypes.IronAtronach,
                    MobileTypes.IceAtronach,
                    MobileTypes.Sorcerer,
                    MobileTypes.Mage,
                    MobileTypes.Battlemage,
                    MobileTypes.FireAtronach,
                    MobileTypes.FleshAtronach,
                    MobileTypes.IronAtronach,
                    MobileTypes.IceAtronach,
                    MobileTypes.Sorcerer,
                    MobileTypes.Mage,
                },
            };

            // Harpy Nest - Index10
            new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.HarpyNest,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.Harpy,
                    MobileTypes.GiantBat,
                    MobileTypes.Harpy,
                    MobileTypes.Centaur,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.Harpy,
                    MobileTypes.GiantBat,
                    MobileTypes.Harpy,
                    MobileTypes.Centaur,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.Harpy,
                    MobileTypes.GiantBat,
                    MobileTypes.Harpy,
                    MobileTypes.Centaur,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.Harpy,
                },
            };

            // Ruined Castle - Index11
            new RandomEncounterTable()
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
            new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.SpiderNest,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spriggan,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spriggan,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                    MobileTypes.Spriggan,
                    MobileTypes.Spider,
                    MobileTypes.Spider,
                },
            };

            // Giant Stronghold - Index13
            new RandomEncounterTable()
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
            new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.DragonsDen,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Dragonling,
                    MobileTypes.Gargoyle,
                    MobileTypes.Centaur,
                    MobileTypes.Knight,
                    MobileTypes.Giant,
                    MobileTypes.Werewolf,
                    MobileTypes.DaedraLord,
                    MobileTypes.Dragonling,
                    MobileTypes.Gargoyle,
                    MobileTypes.Centaur,
                    MobileTypes.Knight,
                    MobileTypes.Giant,
                    MobileTypes.Wereboar,
                    MobileTypes.DaedraLord,
                    MobileTypes.Dragonling,
                    MobileTypes.Gargoyle,
                    MobileTypes.Centaur,
                    MobileTypes.Knight,
                    MobileTypes.Giant,
                    MobileTypes.Werewolf,
                },
            };

            // Barbarian Stronghold - Index15
            new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.BarbarianStronghold,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Warrior,
                    MobileTypes.Barbarian,
                    MobileTypes.Archer,
                    MobileTypes.Rogue,
                    MobileTypes.Werewolf,
                    MobileTypes.Warrior,
                    MobileTypes.Barbarian,
                    MobileTypes.Archer,
                    MobileTypes.Rogue,
                    MobileTypes.Wereboar,
                    MobileTypes.Warrior,
                    MobileTypes.Barbarian,
                    MobileTypes.Archer,
                    MobileTypes.Rogue,
                    MobileTypes.Werewolf,
                    MobileTypes.Warrior,
                    MobileTypes.Barbarian,
                    MobileTypes.Archer,
                    MobileTypes.Rogue,
                    MobileTypes.Wereboar,
                },
            };

            // Volcanic Caves - Index16
            new RandomEncounterTable()
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
            new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.ScorpionNest,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.GiantScorpion,
                    MobileTypes.GiantBat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Spriggan,
                    MobileTypes.GiantScorpion,
                    MobileTypes.GiantBat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Spriggan,
                    MobileTypes.GiantScorpion,
                    MobileTypes.GiantBat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Spriggan,
                    MobileTypes.GiantScorpion,
                    MobileTypes.GiantBat,
                },
            };

            // Cemetery - Index18
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.Burglar,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.Thief,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.Burglar,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.Thief,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.Burglar,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.Thief,
                    MobileTypes.GiantBat,
                    MobileTypes.Burglar,
                    MobileTypes.Rat,
                },
            };

            /*
            // Cemetery - DF Unity version
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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
                    MobileTypes.GiantScorpion,
                    MobileTypes.Thief,
                    MobileTypes.Wereboar,
                    MobileTypes.Burglar,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Thief,
                    MobileTypes.Werewolf,
                    MobileTypes.Burglar,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                },
            };

            // Desert, not in location, day - Index21
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.Centaur,
                    MobileTypes.Orc,
                    MobileTypes.Dragonling,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.Centaur,
                    MobileTypes.Orc,
                    MobileTypes.Dragonling,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.Centaur,
                    MobileTypes.Orc,
                    MobileTypes.Dragonling,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                },
            };

            // Desert, not in location, night - Index22
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.Vampire,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Zombie,
                    MobileTypes.Mummy,
                    MobileTypes.GiantScorpion,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.Vampire,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Zombie,
                    MobileTypes.Mummy,
                    MobileTypes.VampireAncient,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.Vampire,
                    MobileTypes.SkeletalWarrior,
                    MobileTypes.Zombie,
                },
            };

            // Mountain, in location, night - Index23
            new RandomEncounterTable()
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
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.Giant,
                    MobileTypes.Rogue,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Sorcerer,
                    MobileTypes.Gargoyle,
                    MobileTypes.Werewolf,
                    MobileTypes.Rat,
                    MobileTypes.Giant,
                    MobileTypes.Rogue,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Sorcerer,
                    MobileTypes.Gargoyle,
                    MobileTypes.Werewolf,
                    MobileTypes.Rat,
                    MobileTypes.Giant,
                    MobileTypes.Rogue,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Sorcerer,
                    MobileTypes.Gargoyle,
                },
            };

            // Mountain, not in location, night - Index25
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Ghost,
                    MobileTypes.Daedroth,
                    MobileTypes.Vampire,
                    MobileTypes.Zombie,
                    MobileTypes.Mummy,
                    MobileTypes.Wraith,
                    MobileTypes.Daedroth,
                    MobileTypes.Vampire,
                    MobileTypes.Zombie,
                    MobileTypes.Mummy,
                    MobileTypes.Ghost,
                    MobileTypes.Daedroth,
                    MobileTypes.Vampire,
                    MobileTypes.Zombie,
                    MobileTypes.Mummy,
                    MobileTypes.Wraith,
                    MobileTypes.Daedroth,
                    MobileTypes.Vampire,
                    MobileTypes.Zombie,
                    MobileTypes.Mummy,
                },
            };

            // Rainforest, in location, night - Index26
            new RandomEncounterTable()
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

            // Rainforest, not in location, day - Index27
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.GrizzlyBear,
                },
            };

            // Rainforest, not in location, night - Index28
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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

            // Subtropical, not in location, day - Index30
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.SabertoothTiger,
                    MobileTypes.Spider,
                    MobileTypes.Gargoyle,
                    MobileTypes.Harpy,
                    MobileTypes.Rat,
                    MobileTypes.GrizzlyBear,
                },
            };

            // Subtropical, not in location, night - Index31
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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

            // Swamp/woodlands, not in location, day - Index33
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.GrizzlyBear,
                    MobileTypes.Spriggan,
                    MobileTypes.Orc,
                    MobileTypes.Centaur,
                    MobileTypes.Dragonling,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Wereboar,
                    MobileTypes.Giant,
                    MobileTypes.Archer,
                    MobileTypes.OrcShaman,
                    MobileTypes.Bard,
                    MobileTypes.Barbarian,
                    MobileTypes.OrcWarlord,
                    MobileTypes.Battlemage,
                    MobileTypes.Assassin,
                    MobileTypes.Ranger,
                    MobileTypes.Rogue,
                    MobileTypes.Knight,
                    MobileTypes.Spellsword,
                },
            };

            // Swamp/woodlands, not in location, night - Index34
            new RandomEncounterTable()
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

            // Haunted woodlands, in location, night - Index35
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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
            new RandomEncounterTable()
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
                    MobileTypes.AncientLich,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                    MobileTypes.VampireAncient,
                    MobileTypes.Wraith,
                    MobileTypes.AncientLich,
                    MobileTypes.Zombie,
                    MobileTypes.Spider,
                    MobileTypes.Vampire,
                    MobileTypes.Lich,
                },
            };

            Debug.Log("Finished mod init: UnleveledMobs");
        }

    }
}