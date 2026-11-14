using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    public AudioClip coinSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="Player" && AudioManager.instance != null)
        {
            PlayerStats.score++;
            AudioManager.instance.PlayMusicsfx(coinSound);
            Debug.Log("Score: " + PlayerStats.score);
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
