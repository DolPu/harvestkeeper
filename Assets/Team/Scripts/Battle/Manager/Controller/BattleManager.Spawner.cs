using UnityEngine;
public partial class BattleManager : Singleton<BattleManager>
{
    private void CreateSpawner()
    {
        foreach (var data in currentBattleSO.BattleSpawnerDatas)
        {
            //Todo: Use Pool Manager later
            var spawnerObj = Instantiate(data.SpawnerSO.prefab, data.pos, Quaternion.identity);
            spawnerObj.name = $"[{data.SpawnerSO.name_id}]";
            var ctl = spawnerObj.GetComponent<SpawnerController>();
            ctl.SetData(data.SpawnerSO);
        }
    }
}
