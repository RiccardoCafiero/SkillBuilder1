using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField]
    Vector3[] positions = {
        new Vector3(0,0,0),
        new Vector3(3,0,0),
        new Vector3(0,0,3),
        new Vector3(-3,0,0),
        new Vector3(0,0,-3) };


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MovementCoroutine());
    }

    IEnumerator MovementCoroutine()
    {
        yield return new WaitForSeconds(1f);
        Vector3 originalPos = transform.position;
        while (true)
        {
            int random = Random.Range(0, 5);
            
            Vector3 newPos = originalPos + positions[random];
            transform.localPosition = newPos;
            
            yield return new WaitForSeconds(1.5f);
        }
    }
}
