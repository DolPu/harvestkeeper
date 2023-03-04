using System;
using System.Collections.Generic;

[Serializable]
public class PlayerBattleData
{
    public float MaxHP = 100;
    public float MaxShieldHP = 10;
    public float HPRegen = 1;
    public int MaxGem = 1; // to create tower 
    public float moveSpeed = 1f;
    public float attackSpeed = 1f;
}
