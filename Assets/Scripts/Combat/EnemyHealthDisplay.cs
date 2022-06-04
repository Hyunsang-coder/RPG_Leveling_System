using System;
using UnityEngine;
using UnityEngine.UI;
using RPG.Attributes;

namespace RPG.Combat
{
    public class EnemyHealthDisplay : MonoBehaviour
    {
        Fighter fighter;
        void Awake()
        {
            fighter = GameObject.FindWithTag("Player").GetComponent<Fighter>();  
        }
        
        public void Update()
        {   
            if (fighter.GetTarget() == null)
            {
                GetComponent<Text>().text = "N/A";
                return;
                // 위의 return이 없으면 에러 발생
            }
            Health health = fighter.GetTarget();
            GetComponent<Text>().text = String.Format("{0:0.0}%", health.GetPercentage());
        }
    }
}
