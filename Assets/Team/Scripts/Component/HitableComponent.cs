using System.Collections;
using System.Collections.Generic;
using FarmingEngine;
using UnityEngine;
using UnityEngine.Events;

public class HitableComponent : MonoBehaviour
{
    public float maxHP;
    public float currentHP;

    public UnityAction<HitableComponent> onDamagedBy;
    public UnityAction<AttackableComponent> onDamagedByAttacker;
    public UnityAction onDamaged;
    public UnityAction onDead;
    public UnityAction<float> onHPChanged;
    
    public void Init(float hp)
    {
        maxHP = hp;
        currentHP = maxHP;
    }
    
    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        if (IsDead())
        {
            onDead?.Invoke();
        }
        else
        {
            onHPChanged?.Invoke(currentHP);
        }
    }
    
    public void TakeDamage(float damage, AttackableComponent attacker)
    {
        currentHP -= damage;
        if (IsDead())
        {
            onDead?.Invoke();
        }
        else
        {
            onHPChanged?.Invoke(currentHP);
            onDamagedByAttacker?.Invoke(attacker);
        }
    }

    public void TakeDamage(float damage, HitableComponent hitable)
    {
        currentHP -= damage;
        if (IsDead())
        {
            onDead?.Invoke();
        }
        else
        {
            onHPChanged?.Invoke(currentHP);
            onDamagedBy?.Invoke(hitable);
        }
    }

    public bool IsDead()
    {
        return currentHP <= 0;
    }
    
}
