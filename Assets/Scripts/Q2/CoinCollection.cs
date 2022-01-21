using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            if (collision.gameObject.GetComponent<ColorChanger>().SpriteColor ==
                this.gameObject.GetComponent<ColorChanger>().SpriteColor)
            {
                // Destroy Coin
                Destroy(gameObject);
            }
            else
            {
                // play animation
                animator.SetBool("Contact", true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("Contact", false); 
    }
}
