using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class FirstScene : MonoBehaviour
{

    float timer = 1;
    float currentTime = 0;
    public FirstPersonController fpc;
    public Image firstFrame;
    public Image secondFrame;
    public Image thirdFrame;
    public Image fourthFrame;
    bool done;
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        

        fpc.enabled = false;
        currentTime = timer;
        done = false;
        firstFrame.canvasRenderer.SetAlpha(1.0f);
        secondFrame.canvasRenderer.SetAlpha(1.0f);
        thirdFrame.canvasRenderer.SetAlpha(1.0f);
        fourthFrame.canvasRenderer.SetAlpha(1.0f);


        firstFrame.transform.GetChild(0).GetComponent<Text>().text =
                "«Вы наверное хотите узнать, как я здесь оказалась. " +
                "Скорее всего, любой бы услышавши мою историю громко" +
                " рассмеялся, а некоторые даже проявили эмоции и покрутили" +
                " у виска пальцем тонко намекая на мое место среди людей," +
                " которые лишились разума, но все не так. Пожалуйста, дорогой читатель, " +
                "поверь мне!»";

        secondFrame.transform.GetChild(0).GetComponent<Text>().text =
                "«Меня зовут Сара. Мне 14 лет учусь в старшей школе," +
                " думаю описывать остальное не будет важным для вас." +
                " Несколько дней назад, покидая школу мне стало не по себе»";

        thirdFrame.transform.GetChild(0).GetComponent<Text>().text =
               "«Мы это мы! Мы нуждаемся в помощи! – Говорили они." +
               " Каждый день и каждую минуту, я слышала голос. " +
               "Помоги нам, ты нас найдешь! …И я пошла…»";

        fourthFrame.transform.GetChild(0).GetComponent<Text>().text =
               "«Не пойму, как я там оказалась, я села на автобус и уснула," +
               " я каждый день ездила на нем, почему он заехал именно сюда!" +
               " Больше вопросов чем ответов, надеюсь, ты поймешь мою историю…»";




        secondFrame.transform.GetChild(0).GetComponent<Text>().enabled = false;
        thirdFrame.transform.GetChild(0).GetComponent<Text>().enabled = false;
        fourthFrame.transform.GetChild(0).GetComponent<Text>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {


        if (fourthFrame.canvasRenderer.GetAlpha() == 0 && i == 0)
        {
            i++;
           
            fpc.enabled = true;
            DestroyFrames();
        }

        if (done == false)
        {
            FirstFrame();
            SecondFrame();
            ThirdFrame();
            FourthFrame();
            currentTime -= Time.deltaTime;
            
        }
        
    }
    
    void FirstFrame()
    {
       
        if (currentTime < 0 && firstFrame.canvasRenderer.GetAlpha() != 0 )
        {
            
            currentTime = timer;
            firstFrame.transform.GetChild(0).GetComponent<Text>().enabled = false;
            secondFrame.transform.GetChild(0).GetComponent<Text>().enabled = true;
            firstFrame.CrossFadeAlpha(0, 1, false);
            

        }
    }

    void SecondFrame()
    {
        if (currentTime < 0 && secondFrame.canvasRenderer.GetAlpha() != 0 && firstFrame.canvasRenderer.GetAlpha() == 0)
        {
           
            currentTime = timer;

            secondFrame.transform.GetChild(0).GetComponent<Text>().enabled = false;
            thirdFrame.transform.GetChild(0).GetComponent<Text>().enabled = true;

            secondFrame.CrossFadeAlpha(0, 1, false);
            
           
        }
    }
    
    void ThirdFrame()
    {
        if (currentTime < 0 && thirdFrame.canvasRenderer.GetAlpha() != 0 && secondFrame.canvasRenderer.GetAlpha() == 0)
        {
           

            currentTime = timer;

            thirdFrame.transform.GetChild(0).GetComponent<Text>().enabled = false;
            fourthFrame.transform.GetChild(0).GetComponent<Text>().enabled = true;

            thirdFrame.CrossFadeAlpha(0, 1, false);
           
        }
        
    }

    void FourthFrame()
    {
        if (currentTime < 0 && fourthFrame.canvasRenderer.GetAlpha() != 0 && thirdFrame.canvasRenderer.GetAlpha() == 0)
        {

           currentTime = timer;


            

            fourthFrame.CrossFadeAlpha(0, 1, false);
           done = true;
        }

        
    }

    void DestroyFrames()
    {
        Destroy(this.gameObject);
    }
}
