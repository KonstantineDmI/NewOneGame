using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class CodePanelButtons : MonoBehaviour
{
    public Text textOnDisp;
    public GameObject controller;
    public GameObject codePanel;
    public FirstPersonController player;
    CodeGeneration code;
    // Start is called before the first frame update
    void Start()
    {
        code = controller.GetComponent<CodeGeneration>();
    }
    
 

    // Update is called once per frame
    void Update()
    {
        


    }
    public void OnButtonsClick()
    {
        textOnDisp.text += this.transform.GetChild(0).GetComponent<Text>().text;
    }

    public void OnExit()
    {
        codePanel.SetActive(false);
        UnityEngine.Cursor.visible = false;

    }
    public void MinusChar()
    {
        textOnDisp.text = textOnDisp.text.Substring(0, textOnDisp.text.Length - 1);
    }

    public void OK()
    {
        code.CheckCode();
    }
}
