using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowControls : MonoBehaviour
{
    [SerializeField] GameObject controlsPanel;
    private GameObject player;

    private Transform other;
    private float dist;
    private bool check;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            controlsPanel.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        controlsPanel.SetActive(false);
    }
}
