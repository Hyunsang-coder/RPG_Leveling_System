using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RPG.Attributes
{
    public class XPDisplay : MonoBehaviour
    {
        Experience exp;

        void Awake()
        {
            exp = GameObject.FindWithTag("Player").GetComponent<Experience>();
        }
        
        public void Update()
        {
            GetComponent<Text>().text = String.Format("{0}", exp.GetPoints());
        }
    }

}
