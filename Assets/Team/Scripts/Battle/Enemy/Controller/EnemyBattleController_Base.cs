using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HitableComponent))]
public class EnemyBattleController_Base : MonoBehaviour
{
    [SerializeField]
    protected EnemySO EnemySO;

    public HitableComponent hitableComponent;
    public virtual void Init()
    {
        hitableComponent.Init(EnemySO.HP);
    }
    
    // Editor
    void OnValidate()
    {
        hitableComponent = GetComponent<HitableComponent>();
    }
}
