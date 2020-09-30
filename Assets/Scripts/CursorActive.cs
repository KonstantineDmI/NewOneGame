using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CursorActive : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject CodePanel;
    MouseLook ms = new MouseLook();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(CodePanel.activeSelf == true)
        {
            ms.XSensitivity = 0f;
            ms.YSensitivity = 0f;
        }
        else
        {
            ms.XSensitivity = 2f;
            ms.YSensitivity = 2f;

        }
    }
}
