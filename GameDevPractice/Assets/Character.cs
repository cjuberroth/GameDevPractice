using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    // Properties
    [SerializeField] public int HealthMax;
    [SerializeField] private int AttackDamage;

    // Accessors
    public int Health { get; set; }
}
