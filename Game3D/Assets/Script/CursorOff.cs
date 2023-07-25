using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorOff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Screen.lockCursor = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
