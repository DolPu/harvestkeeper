using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HitableComponent))]
public class PlayerBattleController : MonoBehaviour
{
    private PlayerBattleData currentPlayerBattleData;
    public HitableComponent hitableComponent;
    public void Init(PlayerBattleData data)
    {
        currentPlayerBattleData = data;
        // logic
        hitableComponent.Init(currentPlayerBattleData.MaxHP);
    }
    
    
    // Editor Code
    void OnValidate()
    {
        hitableComponent = GetComponent<HitableComponent>();
    }
}
