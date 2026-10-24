using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGhost : MonoBehaviour
{
    public Transform enemy;

    public Transform spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RespawnEnemy()
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            RespawnEnemy();
        }
    }
}
