using UnityEngine;

namespace RPG.Attributes
{
    // 캐릭터에게만 요구되는 class로 enemy는 필요 없음
    public class Experience : MonoBehaviour 
    {
        [SerializeField] float experiencePoints = 0;

        public void GainExperience(float experience)
        {
            experiencePoints += experience;
        }

    }
}