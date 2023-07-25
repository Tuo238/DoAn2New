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
            //SceneManager.LoadScene(1);
            Debug.Log("Hello");
        }
    }
    public void Delete()
    {
        NrIndex++;
        Nr = null;
        UiText.text = Nr;
    }
}