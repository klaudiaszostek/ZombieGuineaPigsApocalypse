using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuineaPig : MonoBehaviour, IStats
{
    public virtual float HP { get; set; }
    public virtual float CurrentHP { get; set; }
    public virtual float Coins { get; set; }
    public virtual float Damage { get; set; }
    public virtual float Allies { get; set; }
    public virtual void Attack(float damage) { }
    public virtual void TakeDamage(float damage) { }
    public virtual void CollectFood(float power) { }
    public virtual void CollectCoins(float coins) { }
    public virtual void Restart() { }
    public virtual void Create() { }
}
