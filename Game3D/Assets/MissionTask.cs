using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MissionTask : MonoBehaviour
{

    public GameObject UIObject;
    public GameObject UIObject2;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        UIObject.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UIObject.SetActive(true);
            UIObject2.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider other)
    {
        UIObject.SetActive(true);
        UIObject2.SetActive(false);
        Destroy(cube);
    }
}
