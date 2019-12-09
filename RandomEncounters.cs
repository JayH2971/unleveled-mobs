// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2019 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Gavin Clayton (interkarma@dfworkshop.net)
// Contributors:    
// 
// Notes:
//

using System;
using DaggerfallConnect;
using DaggerfallConnect.Arena2;
using DaggerfallWorkshop.Game.Utility;

namespace DaggerfallWorkshop.Utility
{
    #region Encounter Tables

    /// <summary>
    /// Static definitions for random encounters based on dungeon type, from FALL.EXE.
    /// All lists from classic have 20 entries.
    /// These are generally ordered from low-level through to high-level encounters.
    /// </summary>
    public static class RandomEncounters
    {
        public static RandomEncounterTable[] EncounterTables = new RandomEncounterTable[]
        {
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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

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
            },

            // Unused - Index38
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.Rat,
                    MobileTypes.Thief,
                    MobileTypes.Rat,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.GiantBat,
                    MobileTypes.Zombie,
                    MobileTypes.Ghost,
                    MobileTypes.Rat,
                    MobileTypes.Assassin,
                    MobileTypes.GiantBat,
                    MobileTypes.Rogue,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.GiantBat,
                    MobileTypes.Rat,
                    MobileTypes.Rat,
                    MobileTypes.Vampire,
                },
            },

            // Default building - Index39
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Thief,
                    MobileTypes.Warrior,
                    MobileTypes.Burglar,
                    MobileTypes.Warrior,
                    MobileTypes.Burglar,
                    MobileTypes.Bard,
                    MobileTypes.Warrior,
                    MobileTypes.Acrobat,
                    MobileTypes.Burglar,
                    MobileTypes.Rogue,
                    MobileTypes.Thief,
                    MobileTypes.Warrior,
                    MobileTypes.Burglar,
                    MobileTypes.Nightblade,
                    MobileTypes.Rogue,
                    MobileTypes.Warrior,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Warrior,
                    MobileTypes.Rogue,
                },
            },

            // Guildhall - Index40
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Mage,
                    MobileTypes.Imp,
                    MobileTypes.Battlemage,
                    MobileTypes.Healer,
                    MobileTypes.Nightblade,
                    MobileTypes.Spellsword,
                    MobileTypes.Mage,
                    MobileTypes.Sorcerer,
                    MobileTypes.Battlemage,
                    MobileTypes.Healer,
                    MobileTypes.FireAtronach,
                    MobileTypes.Spellsword,
                    MobileTypes.Mage,
                    MobileTypes.Sorcerer,
                    MobileTypes.Battlemage,
                    MobileTypes.Nightblade,
                    MobileTypes.Spellsword,
                    MobileTypes.Mage,
                    MobileTypes.DaedraSeducer,
                    MobileTypes.Battlemage,
                },
            },

            // Temple - Index41
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Knight,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Knight,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Knight,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Monk,
                    MobileTypes.Knight,
                },
            },

            // Palace, House1 - Index42
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Warrior,
                    MobileTypes.Archer,
                    MobileTypes.Bard,
                    MobileTypes.Spellsword,
                    MobileTypes.Knight,
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                    MobileTypes.Warrior,
                    MobileTypes.Archer,
                    MobileTypes.Bard,
                    MobileTypes.Spellsword,
                    MobileTypes.Knight,
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                    MobileTypes.Warrior,
                    MobileTypes.Archer,
                    MobileTypes.Spellsword,
                    MobileTypes.Knight,
                    MobileTypes.Warrior,
                    MobileTypes.Knight,
                },
            },

            // House2 - Index43
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Bard,
                    MobileTypes.Warrior,
                    MobileTypes.Rogue,
                    MobileTypes.Thief,
                    MobileTypes.Warrior,
                    MobileTypes.Spellsword,
                    MobileTypes.Burglar,
                    MobileTypes.Rogue,
                    MobileTypes.Monk,
                    MobileTypes.Mage,
                    MobileTypes.Nightblade,
                    MobileTypes.Acrobat,
                    MobileTypes.Warrior,
                    MobileTypes.Bard,
                    MobileTypes.Healer,
                    MobileTypes.Sorcerer,
                    MobileTypes.Thief,
                    MobileTypes.Vampire,
                    MobileTypes.Rogue,
                    MobileTypes.Warrior,
                },
            },

            // House3 - Index44
            new RandomEncounterTable()
            {
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Rat,
                    MobileTypes.Rat,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Monk,
                    MobileTypes.Bard,
                    MobileTypes.Healer,
                    MobileTypes.Rogue,
                    MobileTypes.Monk,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Rogue,
                    MobileTypes.Ranger,
                    MobileTypes.Burglar,
                    MobileTypes.Thief,
                    MobileTypes.Bard,
                    MobileTypes.Monk,
                    MobileTypes.Rogue,
                },
            },
        };
        #endregion

        #region Public methods

        // Enemy selection method from classic. Returns an enemy ID based on environment and player level.
        public static MobileTypes ChooseRandomEnemy(bool chooseUnderWaterEnemy)
        {
            int encounterTableIndex = 0;
            Game.PlayerEnterExit playerEnterExit = Game.GameManager.Instance.PlayerEnterExit;
            PlayerGPS playerGPS = Game.GameManager.Instance.PlayerGPS;

            if (!playerEnterExit || !playerGPS)
                return MobileTypes.None;

            if (chooseUnderWaterEnemy)
                encounterTableIndex = 19;
            else if (playerEnterExit.IsPlayerInsideDungeon)
                encounterTableIndex = ((int)playerEnterExit.Dungeon.Summary.DungeonType);
            else if (playerEnterExit.IsPlayerInsideBuilding)
            {
                DFLocation.BuildingTypes buildingType = playerEnterExit.BuildingType;

                if (buildingType == DFLocation.BuildingTypes.GuildHall)
                    encounterTableIndex = 40;
                else if (buildingType == DFLocation.BuildingTypes.Temple)
                    encounterTableIndex = 41;
                else if (buildingType == DFLocation.BuildingTypes.Palace
                    || buildingType == DFLocation.BuildingTypes.House1)
                    encounterTableIndex = 42;
                else if (buildingType == DFLocation.BuildingTypes.House2)
                    encounterTableIndex = 43;
                else if (buildingType == DFLocation.BuildingTypes.House3)
                    encounterTableIndex = 44;
                else
                    encounterTableIndex = 39;
            }
            else
            {
                int climate = playerGPS.CurrentClimateIndex;
                bool isDay = DaggerfallUnity.Instance.WorldTime.Now.IsDay;

                if (playerGPS.IsPlayerInLocationRect)
                {
                    if (isDay)
                        return MobileTypes.None;

                    // Player in location rectangle, night
                    switch (climate)
                    {
                        case (int)MapsFile.Climates.Desert:
                        case (int)MapsFile.Climates.Desert2:
                            encounterTableIndex = 20;
                            break;
                        case (int)MapsFile.Climates.Mountain:
                            encounterTableIndex = 23;
                            break;
                        case (int)MapsFile.Climates.Rainforest:
                            encounterTableIndex = 26;
                            break;
                        case (int)MapsFile.Climates.Subtropical:
                            encounterTableIndex = 29;
                            break;
                        case (int)MapsFile.Climates.Swamp:
                        case (int)MapsFile.Climates.MountainWoods:
                        case (int)MapsFile.Climates.Woodlands:
                            encounterTableIndex = 32;
                            break;
                        case (int)MapsFile.Climates.HauntedWoodlands:
                            encounterTableIndex = 35;
                            break;

                        default:
                            return MobileTypes.None;
                    }
                }
                else
                {
                    if (isDay)
                    {
                        // Player not in location rectangle, day
                        switch (climate)
                        {
                            case (int)MapsFile.Climates.Desert:
                            case (int)MapsFile.Climates.Desert2:
                                encounterTableIndex = 21;
                                break;
                            case (int)MapsFile.Climates.Mountain:
                                encounterTableIndex = 24;
                                break;
                            case (int)MapsFile.Climates.Rainforest:
                                encounterTableIndex = 27;
                                break;
                            case (int)MapsFile.Climates.Subtropical:
                                encounterTableIndex = 30;
                                break;
                            case (int)MapsFile.Climates.Swamp:
                            case (int)MapsFile.Climates.MountainWoods:
                            case (int)MapsFile.Climates.Woodlands:
                                encounterTableIndex = 33;
                                break;
                            case (int)MapsFile.Climates.HauntedWoodlands:
                                encounterTableIndex = 36;
                                break;

                            default:
                                return MobileTypes.None;
                        }
                    }
                    else
                    {
                        // Player not in location rectangle, night
                        switch (climate)
                        {
                            case (int)MapsFile.Climates.Desert:
                            case (int)MapsFile.Climates.Desert2:
                                encounterTableIndex = 22;
                                break;
                            case (int)MapsFile.Climates.Mountain:
                                encounterTableIndex = 25;
                                break;
                            case (int)MapsFile.Climates.Rainforest:
                                encounterTableIndex = 28;
                                break;
                            case (int)MapsFile.Climates.Subtropical:
                                encounterTableIndex = 31;
                                break;
                            case (int)MapsFile.Climates.Swamp:
                            case (int)MapsFile.Climates.MountainWoods:
                            case (int)MapsFile.Climates.Woodlands:
                                encounterTableIndex = 34;
                                break;
                            case (int)MapsFile.Climates.HauntedWoodlands:
                                encounterTableIndex = 37;
                                break;

                            default:
                                return MobileTypes.None;
                        }
                    }
                }
            }

            int roll = Dice100.Roll();
            int playerLevel = Game.GameManager.Instance.PlayerEntity.Level;
            int min;
            int max;

            // Random/player level based adjustments from classic. These assume enemy lists of length 20.
            if (roll > 80)
            {
                if (roll > 95)
                {
                    if (playerLevel <= 5)
                    {
                        min = 0;
                        max = playerLevel + 2;
                    }
                    else
                    {
                        min = 0;
                        max = 19;
                    }
                }
                else
                {
                    min = 0;
                    max = playerLevel + 1;
                }
            }
            else
            {
                min = playerLevel - 3;
                max = playerLevel + 3;
            }
            if (min < 0)
            {
                min = 0;
                max = 5;
            }
            if (max > 19)
            {
                min = 14;
                max = 19;
            }

            RandomEncounterTable encounterTable = EncounterTables[encounterTableIndex];

            // Adding a check here (not in classic) for lists of shorter length than 20
            if (max + 1 > encounterTable.Enemies.Length)
            {
                max = encounterTable.Enemies.Length - 1;
                if (max >= 5)
                    min = max - 5;
                else
                    min = UnityEngine.Random.Range(0, max);
            }

            return encounterTable.Enemies[UnityEngine.Random.Range(min, max + 1)];
        }
    }
    #endregion
}
