
using UnityEngine;

[CreateAssetMenu(fileName = "TowerSO", menuName = "Battle/SO/Tower SO", order = 50)]
public class TowerSO : ScriptableObject
{
    public float HP = 100f;
    public float dmg = 1f;
    public int cost = 1;
    public float attackRange = 1f;
    public float attackSpeed = 1f;
}
