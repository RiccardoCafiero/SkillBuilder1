// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;    
    public ObjectColor spriteColor;
    private Color[] colors = { Color.red, Color.blue, Color.green };

    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        ChangeColor(spriteColor);
    }

    public void ChangeColor(ObjectColor newColor)
    {
        mySpriteRenderer.color = colors[(int)newColor];
        print("Changed internally color to " + newColor);
    }

    
}

public enum ObjectColor { red, blue, green };
