// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Q4
{
    public class GameHandler : MonoBehaviour
{
    [SerializeField] private GameObject youWinText = null;
        [SerializeField] private GameObject deathText = null;

        [SerializeField] private List<PlayerMovement> allPlayerCubes = new List<PlayerMovement>();

    private void Start()
    {
        allPlayerCubes.AddRange(FindObjectsOfType<PlayerMovement>());
    }

    public void RemovePlayerCubeFromList(PlayerMovement thisCube)
    {
        allPlayerCubes.Remove(thisCube);
        CheckIfLevelComplete();
    }

    private void CheckIfLevelComplete()
    {
        // Challenge 5:  
        if(allPlayerCubes.Count == 0)
            {
                //trigger win
                youWinText.gameObject.SetActive(true);
            }
    }

        public void TriggerDeath()
        {
            deathText.gameObject.SetActive(true);
            foreach(PlayerMovement cube in allPlayerCubes)
            {
                cube.enabled = false;
            }
        }


}

}


