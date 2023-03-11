using UnityEngine;

namespace Team.Scripts.Battle.Player
{
    public abstract class Action : ScriptableObject
    {
        public abstract void Do(PlayerBattleController playerBattleController);

        public abstract bool CanDo(PlayerBattleController playerBattleController);
    }
}