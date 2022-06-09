using UnityEngine;
using RPG.Saving;

namespace RPG.Attributes
{
    // 캐릭터에게만 요구되는 class로 enemy는 필요 없음
    public class Experience : MonoBehaviour, ISaveable
    {
        [SerializeField] float experiencePoints = 0;

        public void GainExperience(float experience)
        {
            experiencePoints += experience;
        }
        public object CaptureState()
        {
            return experiencePoints;
        }


        public void RestoreState(object state)
        {
            experiencePoints = (float) state;
        }

        public float GetPoints()
        {
            return experiencePoints;
        }
    }
}