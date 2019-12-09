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

            // Orc Stronghold - Index1
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.OrcStronghold] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.OrcStronghold,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Orc,
                    MobileTypes.OrcSergeant,
                    MobileTypes.OrcWarlord,
                    MobileTypes.OrcShaman,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Orc,
                    MobileTypes.OrcSergeant,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.OrcShaman,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.OrcWarlord,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                    MobileTypes.Orc,
                }
            };

            // Vampire Haunt - Index8
            RandomEncounters.EncounterTables[(int)DFRegion.DungeonTypes.VampireHaunt] = new RandomEncounterTable()
            {
                DungeonType = DFRegion.DungeonTypes.VampireHaunt,
                Enemies = new MobileTypes[]
                {
                    MobileTypes.Vampire,
                    MobileTypes.VampireAncient,
                    MobileTypes.Mummy,
                    MobileTypes.Zombie,
                    MobileTypes.Vampire,
                    MobileTypes.VampireAncient,
                    MobileTypes.Mummy,
                    MobileTypes.Zombie,
                    MobileTypes.Vampire,
                    MobileTypes.VampireAncient,
                    MobileTypes.Mummy,
                    MobileTypes.Zombie,
                    MobileTypes.Vampire,
                    MobileTypes.VampireAncient,
                    MobileTypes.Mummy,
                    MobileTypes.Zombie,
                    MobileTypes.Vampire,
                    MobileTypes.VampireAncient,
                    MobileTypes.Mummy,
                    MobileTypes.Zombie,
                }
            };

            Debug.Log("Finished mod init: UnleveledMobs");
        }

    }
}