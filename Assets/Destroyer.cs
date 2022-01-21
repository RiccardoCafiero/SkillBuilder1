using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Q4;

public class Destroyer : MonoBehaviour
{
    
    private GameHandler gameHandler;
    [SerializeField] ParticleSystem deathParticles;

    private void Start()
    {
        gameHandler = GameObject.FindObjectOfType<GameHandler>();
    }

    private void OnTriggerEnter(Collider other)
    {   
        if (other.gameObject.GetComponent<PlayerMovement>())
        {
            gameHandler.TriggerDeath();
            //Challenge 4:  
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
