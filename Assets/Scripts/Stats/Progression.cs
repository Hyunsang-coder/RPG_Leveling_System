using UnityEngine;
using System.Collections.Generic;
using System;

namespace RPG.Stats
{
    [CreateAssetMenu(fileName = "Progression", menuName = "Stats/New Progression", order = 0)]

    public class Progression : ScriptableObject
    {
        // 캐릭터 스탯 SO
        [SerializeField] ProgressionCharacterClass[] characterClasses = null;

        Dictionary<CharacterClass, Dictionary<Stat, float[]>> lookupTable = null;

        
        public float GetStat(Stat stat, CharacterClass characterClass, int level)
        {
            BuildLookup();

            float[] levels = lookupTable[characterClass][stat];

            if (levels.Length < level) return 0;

            return levels[level-1];
        }

        private void BuildLookup()
        {
            if (lookupTable != null) return;

            lookupTable = new Dictionary<CharacterClass, Dictionary<Stat, float[]>>();

            foreach (ProgressionCharacterClass progressionClass in characterClasses)
            {
                var statLookupTable = new Dictionary<Stat, float[]>();

                foreach (ProgressionStat ProgressionStat in progressionClass.stats)
                {
                    statLookupTable[ProgressionStat.stat] = ProgressionStat.levels;
                }

                lookupTable[progressionClass.chaClass] = statLookupTable;
            }

        }

        // SO에 추가할 컴포넌트
        [System.Serializable]
        class ProgressionCharacterClass
        {
            // 클래스별 스탯
            public CharacterClass chaClass;
            public ProgressionStat[] stats;
        }

        [System.Serializable]
        class ProgressionStat
        {
            // 각 스탯의 레벨별 값
            public Stat stat;
            public float[] levels;
            
        }
    }
}

