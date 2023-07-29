using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject PickupPrompt;
    private bool isPlayerInRange;
    //public string sceneNameToLoad;


    void Start()
    {
        PickupPrompt.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickupPrompt.SetActive(true);
            isPlayerInRange = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickupPrompt.SetActive(false); // Deactivate PickupPrompt when the player exits the trigger area
            isPlayerInRange = false;
        }
    }

    private void Update()
    {
        if (isPlayerInRange == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(sceneName: "DemoSchool");
        }
    }

}