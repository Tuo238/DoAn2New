using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger1 : MonoBehaviour
{
    public GameObject DialogBox;
    public GameObject PickupPrompt;
    private bool isPlayerInRange;


    void Start()
    {
        DialogBox.SetActive(false);
        PickupPrompt.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Player entered trigger area.");
            PickupPrompt.SetActive(true);
            isPlayerInRange = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player EXIT trigger area.");
            PickupPrompt.SetActive(false); // Deactivate PickupPrompt when the player exits the trigger area
            isPlayerInRange = false;
        }
    }

    private void Update()
    {
        if (isPlayerInRange == true && Input.GetKeyDown(KeyCode.E))
        {
            DialogBox.SetActive(true);
        }
    }

}