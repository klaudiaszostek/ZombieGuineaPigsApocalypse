using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject zombiePrefab;
    private GameObject currentPoint;
    private int index;

    void Start()
    {
        index = Random.Range(0, spawnPoints.Length);
        currentPoint = spawnPoints[index];
        Debug.Log(currentPoint.name);
    }
    private void Update()
    {
        Instantiate(zombiePrefab, currentPoint.transform.position, currentPoint.transform.rotation);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(zombiePrefab, currentPoint.transform.position, currentPoint.transform.rotation);
        }
    }
}
