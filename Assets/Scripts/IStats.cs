using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IStats
{
    float HP { get; set; }
    float CurrentHP { get; set; }
    float Coins { get; set; }
    float Damage { get; set; }
    float Allies { get; set; }
    void Attack(float damage);
    void TakeDamage(float damage);
    void CollectFood(float power);
    void CollectCoins(float coins);
    void Restart();
    void Create();
}
