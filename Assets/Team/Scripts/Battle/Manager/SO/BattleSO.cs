using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BattleSO", menuName = "Battle/SO/Battle SO", order = 50)]
public class BattleSO : ScriptableObject
{
    public List<BattleSpawnerData> BattleSpawnerDatas;
}


[Serializable]
public class BattleSpawnerData
{
    public SpawnerSO SpawnerSO;
    public Vector3 pos;
}