using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorDonateButton : MonoBehaviour
{
    void Start()
    {

        var button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }
    public void OnClick()
    {
        var new_color = GetComponent<Image>().color;
        if (new_color != Color.grey)
        {
            new_color = Color.grey;
        }
        else
        {
            new_color = Color.white;
        }
        GetComponent<Image>().color = new_color;


    }
}
