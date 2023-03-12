using System;
using TMPro;
using UnityEngine;

namespace Team.Scripts.Battle.Player
{
    public class HPUI : MonoBehaviour
    {
        // O day neu them mana thi can khai bao mana text, can tim cach generic/flexible hon
        [SerializeField]
        private TextMeshProUGUI _hpText;

        [SerializeField]
        private PlayerBattleData _playerBattleData;

        private void Start()
        {
            _playerBattleData.GetData(DataType.ManaRegen).OnValueChanged += value => _hpText.text = $"{value}";
        }
    }
}