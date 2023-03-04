using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    private SpawnerSO SpawnerSO;
    private int spawnCount;

    public List<EnemyBattleController_Base> aliveEnemy;
    
    public void SetData(SpawnerSO so , float customWeight = 1f)
    {
        SpawnerSO = so;
        aliveEnemy = new List<EnemyBattleController_Base>();

        // Cheat Code
        CheatSpawnOneUnit();
    }
    
    //Cheat Spawn 1 units
    void CheatSpawnOneUnit()
    {
        if (SpawnerSO == null || SpawnerSO.SpawnDatas == null || SpawnerSO.SpawnDatas.Count == 0)
        {
            return;
        }

        spawnCount++;
        //Todo: Use Pool Manager later
        var pick = SpawnerSO.SpawnDatas[0];
        var objEnemy = Instantiate(pick.EnemySO.prefab, 
            this.transform.position + new Vector3(2,0,0), // cheat spawn position
            Quaternion.identity);
        
        objEnemy.name = $"{gameObject.name} [{pick.EnemySO.name_id}] {spawnCount}";
        var enemyCtl = objEnemy.GetComponent<EnemyBattleController_Base>();
        enemyCtl.Init();
        aliveEnemy.Add(enemyCtl);
    }
}
