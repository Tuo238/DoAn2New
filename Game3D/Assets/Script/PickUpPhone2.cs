using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Flash : MonoBehaviour
{
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
            //    StartDialogue();
            //    if (Input.GetMouseButtonDown(0))
            //    {
            //        if (textComponent.text == lines[index])
            //        {
            //            NextLine();
            //        }
            //        else
            //        {
            //            StopAllCoroutines();
            //            textComponent.text = lines[index];
            //        }
            //    }
            //}
            //else if (Input.GetKeyDown(KeyCode.P))
            //{
            //    PutDownPhone();
            //}
        }
    }

    private void PickUpPhone()
    {
        gameObject.SetActive(false);
        PhoneOnPlayer.SetActive(true);
        pickUpPrompt.SetActive(false);
        isPhonePickedUp = true;
    }

    //private void PutDownPhone()
    //{
    //    gameObject.SetActive(true);
    //    PhoneOnPlayer.SetActive(false);
    //    pickUpPrompt.SetActive(true);
    //    //isPhonePickedUp = false;
    //}


    //void StartDialogue()
    //{
    //    index = 0;
    //    StartCoroutine(TypeLine());
    //}

    //IEnumerator TypeLine()
    //{
    //    foreach (char c in lines[index].ToCharArray())
    //    {
    //        textComponent.text += c;
    //        yield return new WaitForSeconds(textSpeed);
    //    }
    //}

    //void NextLine()
    //{
    //    if (index < lines.Length - 1)
    //    {
    //        index++;
    //        textComponent.text = string.Empty;
    //        StartCoroutine(TypeLine());
    //    }
    //    else
    //    {
    //        gameObject.SetActive(false);
    //    }
    //}
}

