using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutDown : MonoBehaviour
{
    public GameObject PhoneOnPlayer2;
    public GameObject pickUpPrompt2;
    public GameObject phoneObject2;

    private bool isPhonePickedUp2;

    void Start()
    {
        PhoneOnPlayer2.SetActive(false);
        pickUpPrompt2.SetActive(false);
        isPhonePickedUp2 = false;
    }

    private void Update()
    {
        if (isPhonePickedUp2 && Input.GetKeyDown(KeyCode.P))
        {
            PutDownPhone();
        }
    }

    private void PutDownPhone()
    {
        phoneObject2.SetActive(true);
        PhoneOnPlayer2.SetActive(false);
        pickUpPrompt2.SetActive(true);
        isPhonePickedUp2 = false;
    }
}
