using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{

    [SerializeField] GameObject EscImage;
    [SerializeField] GameObject ExitConfirmationPanel;
    //[SerializeField] GameObject MusemPanel;
    [SerializeField] GameObject ThankYouPanel;
    [SerializeField] GameObject ProcessExhibits;
    [SerializeField] GameObject AddedExhibitConfirmation;
    [SerializeField] GameObject ExhibitPreview;
    [SerializeField] GameObject VisitorsPreview;
    [SerializeField] GameObject VisitorPreview;
    [SerializeField] GameObject SuccesfullyAccount;

    //[SerializeField] Texture2D simple_cursor;

    public void Enter()
    {
        SceneManager.LoadScene("LogInVisitor");
    }
    public void Donation()
    {
        SceneManager.LoadScene("Donation");
    }
    public void LogIn()
    {
        SceneManager.LoadScene("Museum");
    }
    public void LogInAsAdmin()
    {
        SceneManager.LoadScene("LogInCurator");
    }
    public void LogInCurator()
    {
        SceneManager.LoadScene("CuratorOptions");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void SignUp()
    {
        Scene current_scene = SceneManager.GetActiveScene();
        
        if (current_scene.name == "SignUp")
        {
            SceneManager.LoadScene("LogInVisitor");
        }
        else
        {
            SceneManager.LoadScene("SignUp");
        }
    }
    public void LogInAsGuest()
    {
        SceneManager.LoadScene("Museum");
    }
    public void ExitMusem()
    {
        SceneManager.LoadScene("Start");
    }

    public void Back()
    {
        Scene current_scene = SceneManager.GetActiveScene();
        if (current_scene.name == "LogInVisitor")
        {
            SceneManager.LoadScene("Start");
        }
        if (current_scene.name == "LogInCurator")
        {
            SceneManager.LoadScene("Start");
        }
        if (current_scene.name == "Donation")
        {
            SceneManager.LoadScene("Start");
        }
        if (current_scene.name == "Settings")
        {
            SceneManager.LoadScene("Start");
        }
        if (current_scene.name == "CuratorOptions")
        {
            SceneManager.LoadScene("LogInCurator");
        }
        if (current_scene.name == "AddExhibit")
        {
            SceneManager.LoadScene("CuratorOptions");
        }
        if (current_scene.name == "EditExhibit")
        {
            SceneManager.LoadScene("CuratorOptions");
        }
        if (current_scene.name == "SignUp")
        {
            SceneManager.LoadScene("LogInVisitor");
        }
    }    

    public void AddExhibit()
    {
        SceneManager.LoadScene("AddExhibit");
    }
    public void EditExhibit()
    {
        SceneManager.LoadScene("EditExhibit");
    }

    public void CloseSettings()
    {
        EscImage.SetActive(false);
        //Cursor.SetCursor(simple_cursor, Vector2.zero, CursorMode.Auto);
    }

    public void OpenExitConfirmation()
    {
        ExitConfirmationPanel.SetActive(true);
        //MusemPanel.SetActive(false);
    }

    public void CloseExitConfirmation()
    {
        ExitConfirmationPanel.SetActive(false);
        //MusemPanel.SetActive(true);
    }

    public void OpenAddedExhibitConfirmation()
    {
        AddedExhibitConfirmation.SetActive(true);
       // MusemPanel.SetActive(false);
    }

    public void CloseAddedExhibitConfirmation()
    {
        AddedExhibitConfirmation.SetActive(false);
       // MusemPanel.SetActive(true);
    }

    public void OpenProcessExhibits()
    {
        if (ProcessExhibits != null)
        {
            bool isActivated = ProcessExhibits.activeSelf;
            ProcessExhibits.SetActive(!isActivated);
            //hide visitors preview
            VisitorsPreview.SetActive(false);
        }
    }

    public void ShowPreviewOfExhibit()
    {
        if (ExhibitPreview != null)
        {
            bool isActivated = ExhibitPreview.activeSelf;
            ExhibitPreview.SetActive(!isActivated);
        }
    }

    public void OpenViewVisitors()
    {
        if (VisitorsPreview != null)
        {
            bool isActivated = VisitorsPreview.activeSelf;
            VisitorsPreview.SetActive(!isActivated);
            //hide process exhibits panel
            ProcessExhibits.SetActive(false);
        }
    }
    public void ShowPreviewOfVisitor()
    {
        if (VisitorPreview != null)
        {
            bool isActivated = VisitorPreview.activeSelf;
            VisitorPreview.SetActive(!isActivated);
        }
    }
    public void ThankYou()
    {
        ThankYouPanel.SetActive(true);
    }
    public void SuccesfulAccount()
    {
        SuccesfullyAccount.SetActive(true);
    }

}