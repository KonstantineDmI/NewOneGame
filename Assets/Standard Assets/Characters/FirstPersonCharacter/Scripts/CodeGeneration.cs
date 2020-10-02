using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeGeneration : MonoBehaviour
{
    public GameObject letter;
    public GameObject codePanel;
    
    int code;
    // Start is called before the first frame update
    void Start()
    {
       
            code = Random.Range(10000, 99999);
          
       
    }

    // Update is called once per frame
    void Update()
    {
        letter.transform.GetChild(1).GetComponent<Text>().text = code.ToString();
    }

    public void CheckCode()
    {
        
        if(codePanel.transform.GetChild(0).GetChild(0).GetComponent<Text>().text == letter.transform.GetChild(1).GetComponent<Text>().text)
        {
            Debug.Log("success");
            codePanel.SetActive(false);
        }
        else
        {
            Debug.Log("wrong pass");
            codePanel.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = "";
        }
    }

}
