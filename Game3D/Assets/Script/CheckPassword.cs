using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class CheckPassword : MonoBehaviour
{
    private InputField inputTextField;
    public GameObject doorLocked;
    public GameObject doorUnlocked;
    public GameObject display;
    public GameObject trigger;
    public GameObject prompt;


    //public AudioClip correctSoundClip; // Assign the correct sound clip to play in the Inspector
    //public AudioClip wrongSoundClip;   // Assign the wrong sound clip to play in the Inspector
    //private AudioSource audioSource;

    void Start()
    {
        inputTextField = GetComponent<InputField>();
        //audioSource = GetComponent<AudioSource>();
        Cursor.visible = true;
        Screen.lockCursor = false;
    }

    public void CheckPasswordAndLoadScene()
    {
        switch (inputTextField.text)
        {
            case "werty":
                RightAnswer();
                Debug.Log("right");
                break;
            case "12345":
                Debug.Log("hello2");
                break;

            default:
                Debug.Log("wrong");
                break;
        }
    }

    public void RightAnswer()
    {
        doorLocked.SetActive(false);
        doorUnlocked.SetActive(true);
        display.SetActive(false);
        trigger.SetActive(false);
        prompt.SetActive(false);
        Cursor.visible = false;
        Screen.lockCursor = true;

        // Play the correct sound
        //audioSource.clip = correctSoundClip;
        //audioSource.Play();
    }

    public void WrongAnswer()
    {
        // Play the wrong sound
        //audioSource.clip = wrongSoundClip;
        //audioSource.Play();
    }
}
