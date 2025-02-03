using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenExhibitImage : MonoBehaviour
{
    private GameObject newExhibit;
    private OpenFileImage fileImage;
    private Texture newSprite;

    private Texture2D tex;
    private Sprite mySprite;

    public void ShowExhibitImage()
    {
        fileImage = newExhibit.GetComponent<OpenFileImage>();
        newSprite = fileImage.output.texture;

        //TheTexture = newSprite.texture as Sprite;
        mySprite = Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100.0f);
        GetComponent<Image>().sprite = mySprite;
    }
    
}

