using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medicine : MonoBehaviour
{
    [SerializeField] private float life = 3;
    [SerializeField] private float weaponDamage = 1;
    private void Awake()
    {
        Destroy(gameObject, life);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Zombie"))
        {
            collision.GetComponent<ZombieGuineaPig>().TakeDamage(weaponDamage);
        }
    }
}
