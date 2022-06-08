using UnityEngine;

namespace RPG.Stats
{
    [CreateAssetMenu(fileName = "Progression", menuName = "Stats/New Progression", order = 0)]

    public class Progression : ScriptableObject
    {
        // 캐릭터 스탯 SO
        [SerializeField] ProgressionCharacterClass[] characterClasses = null;

        public float GetStat(Stat stat, CharacterClass characterClass, int level)
        {
            foreach(ProgressionCharacterClass progressionClass in characterClasses)
            {   
                if (progressionClass.chaClass != characterClass) continue;

                foreach(ProgressionStats progressionStat in progressionClass.stats)
                {
                    if (progressionStat.stat != stat) continue;

                    if (progressionStat.levels.Length < level) continue;

                    return progressionStat.levels[level -1];
                }
            }
            return 0;
        }

        // SO 컴포넌트
        [System.Serializable]
        class ProgressionCharacterClass
        {
            public CharacterClass chaClass;
            public ProgressionStats[] stats;
        }

        [System.Serializable]
        class ProgressionStats
        {
            public Stat stat;
            public float[] levels;
            
        }
    }
}

