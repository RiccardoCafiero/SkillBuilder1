using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform teleportTarget;
    [SerializeField] GameObject player;
    [SerializeField] Light areaLight;
    [SerializeField] Light mainWorldLight;
    [SerializeField] Material deactivatedMat;

    void Start() 
    {
        // CHALLENGE TIP: Make sure all relevant lights are turned off until you need them on
        // because, you know, that would look cool.
        // Turn off the lights
        if (areaLight.isActiveAndEnabled)
        {
            areaLight.gameObject.SetActive(false);
        }
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other) 
    {
        // Challenge 2: TeleportPlayer();
        TeleportPlayer();
        // Challenge 3: DeactivateObject();
        DeactivateObject();
        // Challenge 4: IlluminateArea();
        IlluminateArea();
        // Challenge 5: StartCoroutine ("BlinkWorldLight");
        StartCoroutine(BlinkWorldLight());
        // Challenge 6: TeleportPlayerRandom();
    }

    void TeleportPlayer()
    {
        player.transform.SetPositionAndRotation(teleportTarget.transform.position, Quaternion.identity);
    }

    void DeactivateObject()
    {
        BoxCollider box = this.GetComponent<BoxCollider>();
        box.enabled = false;
        MeshRenderer mesh = this.GetComponent<MeshRenderer>();
        mesh.material = deactivatedMat;
    }

    void IlluminateArea()
    {
        areaLight.gameObject.SetActive(true);
    }

    IEnumerator BlinkWorldLight()
    {
        float defaultLightIntensity = mainWorldLight.intensity;
        yield return new WaitForSeconds(0.1f);
        int cycles = 0;
        while(cycles < 10)
        {
            cycles++;
            // flicker light
            if(mainWorldLight.intensity == defaultLightIntensity)
            {
                mainWorldLight.intensity = 1f;
            }
            else
            {
                mainWorldLight.intensity = defaultLightIntensity;
            }

            yield return new WaitForSeconds(.5f);            
        }
     }

    void TeleportPlayerRandom()
    {
        // code goes here... or you could modify one of your other methods to do the job.
    }

}
