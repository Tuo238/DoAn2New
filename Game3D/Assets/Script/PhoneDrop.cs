using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PhoneDrop : MonoBehaviour
{
    public GameObject PhoneOnPlayer;
    public GameObject PhoneOnGround;
    public GameObject putDownPrompt;
    public GameObject DialougeBox;
    public GameObject DoorTrigger;


    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    private bool isPlayerHoldingPhone;

    void Start()
    {
        PhoneOnGround.SetActive(false);
        putDownPrompt.SetActive(false);
        DialougeBox.SetActive(false);
        DoorTrigger.SetActive(true);
        textComponent.text = string.Empty;
        StartDialogue();

    }

    private void Update()
    {
        if (PhoneOnPlayer.activeSelf)
        {   
            isPlayerHoldingPhone = true;
            putDownPrompt.SetActive(true);
            DialougeBox.SetActive(true);

            if (Input.GetMouseButtonDown(0))
            {
                if (textComponent.text == lines[index])
                {
                    NextLine();
                    DialougeBox.SetActive(false);
                }
                else
                {
                    StopAllCoroutines();
                    textComponent.text = lines[index];
                }
            }
        }
        else
        {
            isPlayerHoldingPhone = false;
            putDownPrompt.SetActive(false);
        }

        if (isPlayerHoldingPhone && Input.GetKey(KeyCode.Q))
        {
            PhoneOnPlayer.SetActive(false);
            PhoneOnGround.SetActive(true);
            putDownPrompt.SetActive(false);
        }
    }


    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}