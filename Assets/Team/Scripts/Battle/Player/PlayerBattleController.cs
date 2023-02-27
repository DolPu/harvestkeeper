using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HitableComponent))]
public class PlayerBattleController : MonoBehaviour
{
    private PlayerBattleData currentPlayerBattleData;

    public void Init(PlayerBattleData data)
    {
        currentPlayerBattleData = data;
        // logic
    }
}
