using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Chat : MonoBehaviour{
    public GameObject chatPanel, textObject;
    public int maxMessages;
    public InputField chatBox;
    // Start is called before the first frame update
    [SerializeField]
    List<Message> messageList = new List<Message>();
    void Start()
    {
        
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if(chatBox.text != ""){
            if (Input.GetKeyDown(KeyCode.Return)){
                sendMessage(chatBox.text);
                chatBox.text = "";
                ResumeGame();
                chatBox.DeactivateInputField();
                EventSystem.current.SetSelectedGameObject(null);
            }
        }
        else{
            if(!chatBox.isFocused && Input.GetKeyDown(KeyCode.Return)){
                chatBox.ActivateInputField();
                PauseGame();
            }
        }
    }

    public void sendMessage(string text){
        if(messageList.Count >= maxMessages){
            Destroy(messageList[0].textObject.gameObject);
            messageList.Remove(messageList[0]);
        }
        Message mymsg = new Message();
        mymsg.text = "  "+text;
        GameObject newText = Instantiate(textObject, chatPanel.transform);
        mymsg.textObject = newText.GetComponent<Text>();
        mymsg.textObject.text = mymsg.text;
        messageList.Add(mymsg);
    }
}

[System.Serializable]
public class Message{
    public string text;
    public Text textObject;
}
