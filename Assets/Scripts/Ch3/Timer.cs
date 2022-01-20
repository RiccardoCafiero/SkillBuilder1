using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text timerText; 
    float elapsedTime;
    public bool timerIsRunning = true;
    
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        int roundedTime = Mathf.RoundToInt(elapsedTime);
        if (timerIsRunning)
        {
            timerText.text = roundedTime.ToString();
        }
        
    }

    
}
