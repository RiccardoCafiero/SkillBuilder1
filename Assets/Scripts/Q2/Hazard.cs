// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    private GameManager gameHandler;

    void Start()
    {
        gameHandler = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            if(collision.gameObject.GetComponent<ColorChanger>().SpriteColor ==
                this.gameObject.GetComponent<ColorChanger>().SpriteColor)
            {
                return;
            }
            if (collision.gameObject.GetComponent<BlockMovement>().isActiveBool)
            {
                Destroy(collision.gameObject);
                gameHandler.AllPlayerBlocksArrayUpdate();
                gameHandler.DestroyedBlockUpdate();
            }
            else
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
