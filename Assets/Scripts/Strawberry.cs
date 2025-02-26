using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Strawberry : CollectibleItem
{
    protected float healthValue = 1;
    public override float HealthValue
    {
        get { return healthValue; }
        set { healthValue = value; }
    }
    protected float coinsValue = 0;
    public override float CoinsValue
    {
        get { return coinsValue; }
        set { coinsValue = value; }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        { 
            collision.GetComponent<PlayerGuineaPig>().CollectFood(HealthValue);
            gameObject.SetActive(false);
            Debug.Log(HealthValue);
        }
    }
}
