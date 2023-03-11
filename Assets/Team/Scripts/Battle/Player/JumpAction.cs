using UnityEngine;

namespace Team.Scripts.Battle.Player
{
    public class JumpAction : Action
    {
        public override void Do(PlayerBattleController playerBattleController)
        {
            var data = playerBattleController.CurrentPlayerBattleData;
            var maxHP = data.GetData(DataType.MaxHP);
            
            
            
            // Jump logic
        }
        
        

        public override bool CanDo(PlayerBattleController playerBattleController)
        {
            // Logic check xem action co nen thuc hien hay khong
            return true;
        }
    }
}