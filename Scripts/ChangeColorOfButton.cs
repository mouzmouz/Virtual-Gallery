using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorOfButton : MonoBehaviour
{
    void Start()
    {
        
        var button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        var new_color = GetComponent<Image>().color;
        if (new_color != Color.red)
        {
            new_color = Color.red;
        }
        else
        {
            new_color = Color.blue;
        }
        GetComponent<Image>().color = new_color;

        
    }
}
