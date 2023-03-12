using System;
using UnityEngine;

namespace Team.Scripts.Battle.Player
{
    public class NewLogic: Action
    {
        [SerializeField]
        private PlayerBattleData _playerBattleData;
        
        public override void Do(PlayerBattleController playerBattleController)
        {
            var manaRegen = _playerBattleData.GetData(DataType.ManaRegen);
            if (manaRegen != null)
            {
                // CurrentMana += manaRegen.Value
            }
        }

        public override bool CanDo(PlayerBattleController playerBattleController)
        {
            throw new NotImplementedException();
        }
    }
}