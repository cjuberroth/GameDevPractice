using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    class PlayerCharacter : Character
    {
        [SerializeField] private UnityEngine.UI.Text HPContainer;

        void Start()
        {
            Health = HealthMax;
        }

        void Update()
        {
            UpdateHPValues();
        }

        private void UpdateHPValues()
        {
            HPContainer.text = string.Concat(this.name, ": ", Health.ToString(), " / ", HealthMax.ToString());
        }
    }
}
