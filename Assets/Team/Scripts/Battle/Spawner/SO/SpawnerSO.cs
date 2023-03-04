using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BattleSpawnerSO", menuName = "Battle/SO/Spawner SO", order = 50)]
public class SpawnerSO : BaseSO
{
    [Header("Spawner Base")]
    public float weight = 1f;
    public List<EnemySpawnData> SpawnDatas;
}

[Serializable]
public class EnemySpawnData
{
    public SpawnerTypeEnum SpawnerTypeEnum;
    public EnemySO EnemySO;
    public float time = 5f;
    public int amount = 1; 
    public int capacity = 10; // total spawn
}

public enum SpawnerTypeEnum
{
    ByTime = 1, //ex: 5s / unit
    ByAmount = 2, // spawn to limit
}