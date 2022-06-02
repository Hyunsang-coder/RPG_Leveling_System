using UnityEngine;

namespace RPG.Stats
{
    [CreateAssetMenu(fileName = "Progression", menuName = "Stats/New Progression", order = 0)]

    public class Progression : ScriptableObject
    {
        // 캐릭터 컴포넌트
        [SerializeField] ProgressionCharacterClass[] characterClasses = null;

        public float GetHealth(CharacterClass characterClass, int level)
        {
            foreach(ProgressionCharacterClass progressionClass in characterClasses)
            {   
                if (progressionClass.chaClass == characterClass)
                {
                    return progressionClass.health[level -1];
                }
            }
            return 0;
        }

        // SO 컴포넌트
        [System.Serializable]
        class ProgressionCharacterClass
        {
            public CharacterClass chaClass;
            public float[] health; 
        }
    }
}

