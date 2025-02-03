using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{

    [SerializeField] bool Button_1_On;
    [SerializeField] Button MyButton_1;

    [SerializeField] bool Button_2_On;
    [SerializeField] Button MyButton_2;

    public void BeenClicked_1()
    {
        Button_1_On = !Button_1_On;
        print("\nBeenClicked_1");
        print("1: " + Button_1_On);
        print("2: " + Button_2_On);
        if (Button_1_On && Button_2_On)
        {
            Button_2_On = false;
            MyButton_2.image.color = Color.white;
            MyButton_1.image.color = Color.green;
        }
        else if (Button_1_On)
        {
            MyButton_1.image.color = Color.green;
        }
        else
        {
            MyButton_1.image.color = Color.white;
        }
    }

    public void BeenClicked_2()
    {
        Button_2_On = !Button_2_On;
        print("\nBeenClicked_2");
        print("1: " + Button_1_On);
        print("2: " + Button_2_On);
        if (Button_2_On && Button_1_On)
        {
            Button_1_On = false;
            MyButton_1.image.color = Color.white;
            MyButton_2.image.color = Color.green;
        }
        else if (Button_2_On)
        {
            MyButton_2.image.color = Color.green;
        }
        else
        {
            MyButton_2.image.color = Color.white;
        }
    }

     
}