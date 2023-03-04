using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySO : BaseSO
{
    [Header("Enemy Base")]
    public float HP = 100;
    public float MP = 10;
    public float HpRegen = 1;
    public float MpRegen = 1;
    public float Armor = 1;
    public float MovementSpeed = 1;
    public float DashSpeed= 2;
    public float DashRegen=5;
    public float AttackDamage = 1;
    public float AttackSpeed = 1;
    public float GoldReward = 10;
}
