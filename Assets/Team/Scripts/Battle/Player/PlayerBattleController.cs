using System;
using System.Collections;
using System.Collections.Generic;
using Team.Scripts.Battle.Player;
using UnityEngine;
using UnityEngine.Serialization;
using TeamAction = Team.Scripts.Battle.Player.Action;

/// <summary>
/// Can thiet ke de cac member them logic ma khong anh huong lan nhau
/// </summary>
[RequireComponent(typeof(HitableComponent))]
public class PlayerBattleController : MonoBehaviour
{
    private PlayerBattleData currentPlayerBattleData;
    public HitableComponent hitableComponent;

    [FormerlySerializedAs("_jumpAction")]
    // Tao 1 kieu du lieu moi, uy thac logic ra ben ngoai
    public TeamAction[] actions;

    public PlayerBattleData CurrentPlayerBattleData => currentPlayerBattleData;

    public void Init(PlayerBattleData data)
    {
        currentPlayerBattleData = data;
        // logic
        // hitableComponent.Init(currentPlayerBattleData.dataArray.);
    }

    private void Update()
    {
        // CheckEnemyAround();
        // Can nhay
        foreach (var action in actions)
        {
            if (action.CanDo(this))
            {
                action.Do(this);
            }
        }
    }

    private void CheckEnemyAround()
    {
        throw new NotImplementedException();
    }

    // Editor Code
    void OnValidate()
    {
        hitableComponent = GetComponent<HitableComponent>();
    }
}