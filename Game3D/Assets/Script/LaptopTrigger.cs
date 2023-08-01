using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopTrigger : MonoBehaviour
{
    public GameObject ScreenOnPlayer;
    public GameObject LaptopOpen;
    public GameObject PickupPrompt;
    private bool isPlayerInRange;


    void Start()
    {
        ScreenOnPlayer.SetActive(false);
        PickupPrompt.SetActive(false);
        LaptopOpen.SetActive(false);
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
    // Update is called once per frame
    void Update()
    {
        if (isPlayerInRange == true && Input.GetKeyDown(KeyCode.E))
        {
            ScreenOnPlayer.SetActive(true);
            LaptopOpen.SetActive(true);

        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            ScreenOnPlayer.SetActive(false);
            Cursor.visible = false;
            Screen.lockCursor = true;
        }


    }
}
