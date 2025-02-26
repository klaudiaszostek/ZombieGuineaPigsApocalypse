using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Coin : CollectibleItem
{
    protected float healthValue = 0;
    public override float HealthValue
    {
        get { return healthValue; }
        set { healthValue = value; }
    }
    protected float coinsValue = 10;
    public override float CoinsValue
    {
        get { return coinsValue; }
        set { coinsValue = value; }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.GetComponent<PlayerGuineaPig>().CollectCoins(CoinsValue);
            gameObject.SetActive(false);
            Debug.Log(CoinsValue);
        }
    }
}
