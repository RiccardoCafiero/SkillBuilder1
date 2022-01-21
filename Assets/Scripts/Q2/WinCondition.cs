using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            if (collision.gameObject.GetComponent<ColorChanger>().SpriteColor ==
                this.gameObject.GetComponent<ColorChanger>().SpriteColor)
            {
                print("Player Wins!!!");
            }
        }
    }
}
