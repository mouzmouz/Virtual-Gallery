using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChat : MonoBehaviour
{
    [SerializeField] GameObject Chat;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            //if (Chat != null)
            //{
            bool isActivated = Chat.activeSelf;
            Chat.SetActive(!isActivated);
            //Chat.SetActive(true);
            //}
        }
    }
}
