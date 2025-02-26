using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private GuineaPig playerGuineaPig;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(playerGuineaPig.Allies >= 10)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
