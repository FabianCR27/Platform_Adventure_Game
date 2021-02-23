using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform spawnPoint;
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Player.transform.position = spawnPoint.transform.position;
        }
        
    }
}
