using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EscGame : MonoBehaviour
{
    [SerializeField] GameObject Image;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SettingsPanel();
        }
    }
    

    public void SettingsPanel()
    {
        if (Image != null)
        {
            //When esc is pressed the settings window will appear if it's deactivated 
            //and disapper is it's activated
            bool isActivated = Image.activeSelf;
            Image.SetActive(!isActivated);
        }
    }
}
