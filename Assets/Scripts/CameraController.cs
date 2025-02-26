using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z); //"transform" is lowercase because it refers to the "Transform" of the same object as the entire component
    }
}
