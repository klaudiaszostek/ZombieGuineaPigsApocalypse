using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private GuineaPig playerGuineaPig;
    [SerializeField] private TextMeshProUGUI coinsText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerGuineaPig = new CoinDecorator(playerGuineaPig);
            collision.GetComponent<PlayerGuineaPig>().CollectCoins(playerGuineaPig.Coins);
            gameObject.SetActive(false);
        }
    }
}
