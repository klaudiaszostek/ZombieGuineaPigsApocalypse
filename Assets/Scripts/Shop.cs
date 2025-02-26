using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shop : MonoBehaviour
{
    [SerializeField] private GuineaPig playerGuineaPig;
    [SerializeField] private TextMeshProUGUI coinsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (playerGuineaPig.Coins >= 10) 
            {
                playerGuineaPig = new FoodDecorator(playerGuineaPig);
                collision.GetComponent<PlayerGuineaPig>().CollectFood(playerGuineaPig.HP);
                playerGuineaPig.Coins -= 10;
                coinsText.text = "Coins: " + playerGuineaPig.Coins;
            }
        }
    }
}
