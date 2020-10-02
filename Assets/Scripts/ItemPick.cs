using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class ItemPick : MonoBehaviour
{

    public KeyCode takeButton;
    public KeyCode hideButton;
    public GameObject item;
    public GameObject text;
    public GameObject message;
    public GameObject codePanel;
    public FirstPersonController player;
    Text txt;

    // Start is called before the first frame update
    void Start()
    {
        txt = text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 10f))
        {
            if(hit.collider.tag == "Message" || hit.collider.tag == "CodePanel")
            {
               

                if (hit.collider.tag == "Message")
                {
                    txt.text = hit.collider.name;
                    text.SetActive(true);
                    if (Input.GetKeyDown(takeButton))
                    {
                        message.SetActive(true);
                    }




                }
                if (hit.collider.tag == "CodePanel")
                {
                    txt.text = hit.collider.name;
                    text.SetActive(true);
                    if (Input.GetKeyDown(takeButton))
                    {
                        codePanel.SetActive(true);


                    }



                }
            }
            else
            {
                text.SetActive(false);
            }
           
        }


        hideItem();
        
    }


    void hideItem()
    {
       if(message.activeSelf == true)
        {
            if (Input.GetKeyDown(hideButton))
            {
                message.SetActive(false);
            }
        }
    }
}
