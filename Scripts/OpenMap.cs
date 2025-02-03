using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMap : MonoBehaviour
{
    [SerializeField] GameObject Map;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            //if (Chat != null)
            //{
            bool isActivated = Map.activeSelf;
            Map.SetActive(!isActivated);
            //Chat.SetActive(true);
            //}
        }
    }
}