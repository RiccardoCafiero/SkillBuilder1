using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    [SerializeField] GameObject deathParticles;
    private void OnTriggerEnter(Collider other)
    {
        Scorer scorer = transform.GetComponentInParent<Scorer>();
        scorer.SlowTime();
        print("Aww, you got me");
        GameObject body = transform.GetChild(0).gameObject;
        GameObject particles = Instantiate(deathParticles, body.transform.position, Quaternion.identity) as GameObject;
        particles.GetComponent<ParticleSystem>().Play();
        Destroy(gameObject);         
    }
}
