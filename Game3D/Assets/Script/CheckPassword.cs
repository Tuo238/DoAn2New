using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class CheckPassword : MonoBehaviour
{
    private InputField inputTextField;



    void Start()
    {
        inputTextField = GetComponent<InputField>();
        //text = GetComponent<Text>();
        Cursor.visible = true;
        Screen.lockCursor = false;


    }

    public void CheckPasswordAndLoadScene()
    {
        switch (inputTextField.text)
        {
            case "qwerty":
                Debug.Log("hello");
                break;
            case "12345":
                Debug.Log("hello2");
                break;

            default:
                inputTextField.text = "";
                break;
        }
    }

    public void UpdateText()
    {
    }
}
