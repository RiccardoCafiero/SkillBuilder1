// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;    
    [SerializeField] ObjectColor spriteColor;
    public ObjectColor SpriteColor { get { return spriteColor; } set { ChangeColor(value); } }
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
        spriteColor = newColor;
        mySpriteRenderer.color = colors[(int)newColor];
    }

    
}

public enum ObjectColor { red, blue, green };


