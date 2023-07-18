using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public AudioSource AudioRing;
    public AudioClip ringtone;
    public GameObject PhoneOnPlayer;
    public GameObject pickUpPrompt;

    private bool isPlayerInRange;
    private bool isPhonePickedUp;

    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;


    void Start()
    {
        PhoneOnPlayer.SetActive(false);
        pickUpPrompt.SetActive(false);
        isPhonePickedUp = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            if (!isPhonePickedUp)
                pickUpPrompt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            pickUpPrompt.SetActive(false);
        }
    }

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            PickUpPhone();
        }
    }

    private void PickUpPhone()
    {
        gameObject.SetActive(false);
        PhoneOnPlayer.SetActive(true);
        pickUpPrompt.SetActive(false);
        isPhonePickedUp = true;
        AudioRing.clip = ringtone;
        AudioRing.Play();
    }

}

