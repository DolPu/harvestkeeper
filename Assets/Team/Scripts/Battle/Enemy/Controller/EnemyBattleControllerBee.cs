using UnityEngine;

public class EnemyBattleControllerBee : EnemyBattleController_Base
{
    private EnemyBeeSO EnemyBeeSO;

    public override void Init()
    {
        base.Init();
        EnemyBeeSO = (EnemyBeeSO) EnemySO;
    }
}
