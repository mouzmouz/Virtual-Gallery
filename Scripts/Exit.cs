using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Exit : MonoBehaviour
{
    public void ExitMuseum()
    {
        Debug.Log("Exiting Museum");
        Application.Quit();
    }
}
