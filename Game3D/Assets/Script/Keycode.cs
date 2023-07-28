using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Keycode : MonoBehaviour
{
    string Code = "4321";
    string Nr = null;
    int NrIndex = 0;
    string alpha;
    public TextMeshProUGUI UiText = null;

    public GameObject LeftDoor1; // Change Object to GameObject here
    public GameObject LeftDoor1OPEN;
    public GameObject LeftDoor2;
    public GameObject LeftDoor2OPEN;
    public GameObject RightDoor1;
    public GameObject RightDoor1OPEN;
    public GameObject RightDoor2;
    public GameObject RightDoor2OPEN;

    public GameObject KeyPadToDisable;
    public GameObject TriggerToDisable;
    public GameObject PromptToDisable;




    public void CursorOn()
    {
        Cursor.visible = true;
        Screen.lockCursor = false;
    }


    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiText.text = Nr;

    }
    public void Enter()
    {
        if (Nr == Code)
        {
            LeftDoor1.SetActive(false);
            LeftDoor1OPEN.SetActive(true);

            LeftDoor2.SetActive(false);
            LeftDoor2OPEN.SetActive(true);

            RightDoor1.SetActive(false);
            RightDoor1OPEN.SetActive(true);

            RightDoor2.SetActive(false);
            RightDoor2OPEN.SetActive(true);

            Cursor.visible = false;
            Screen.lockCursor = true;


            KeyPadToDisable.SetActive(false);
            TriggerToDisable.SetActive(false);
            PromptToDisable.SetActive(false);


        }
    }
    public void Delete()
    {
        NrIndex++;
        Nr = null;
        UiText.text = Nr;
    }
}