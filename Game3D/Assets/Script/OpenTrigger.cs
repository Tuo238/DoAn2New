using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OpenTrigger : MonoBehaviour
{
    public GameObject KeypadOnPlayer;
    public GameObject PickupPrompt;
    private bool isPlayerInRange;


    void Start()
    {
        KeypadOnPlayer.SetActive(false);
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
            KeypadOnPlayer.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            KeypadOnPlayer.SetActive(false);
            Cursor.visible = false;
            Screen.lockCursor = true;
        }

    }

}