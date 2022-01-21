using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorChange : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Block"))
        {
            ObjectColor thisColor = GetComponent<ColorChanger>().SpriteColor;
            other.gameObject.GetComponent<ColorChanger>().ChangeColor(thisColor);
        }
    }
}
