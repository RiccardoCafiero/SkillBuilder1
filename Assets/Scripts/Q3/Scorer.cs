using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] ParticleSystem celebration;
    bool hasChildren = true;

    void Update()
    {
        if (transform.childCount == 0 && hasChildren == true)
        {
            timer.timerIsRunning = false;
            celebration.Play();
            hasChildren = false;

            Invoke("LoadSameScene", 3f);

        }
    }

    void LoadSameScene()
    {
        Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }

    public void SlowTime()
    {
        print("SlowTime has been called");
        StartCoroutine(TimeSlower());
    }

    IEnumerator TimeSlower()
    {
        Time.timeScale = 0.5f;
        yield return new WaitForSeconds(2f);
        Time.timeScale = 1f;
        
    }
}
