using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeDonation : MonoBehaviour
{
    [SerializeField] GameObject Image;

    public void OpenThankYouPanel()
    {
        if(Image != null)
        Image.SetActive(true);
    }
}
