using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    //////////////////////////////////////////
    //public GUIText guiscore 
    public  Text guitimer;
    ////	public float time;
    //    // Use this for initialization
     public static float  myTimer= 150.0f;
    //    // Update is called once per frame
    //    void start(){
    //        //guitimer = GetComponent<Text>();
    //      //  guitimer = GameObject.Find("GameObject2").GetComponent(GUIText)();
    //        //guitimer = GetComponent<Text>();
    //        //guitimer.text = "time left";
    //            //guiscore.text = "Score: 0";
    //           // guitimer.font.material.color = Color.black;


    //    }
     void Update () 
     {

      if (myTimer > 0)
       {
      myTimer -= Time.deltaTime;
      guitimer.text = "Time left:" + myTimer+"s";

    
    //            //float minutes = myTimer / 60; //float minutes1 = 0;
    //            //float seconds = myTimer % 60; //float seconds1 = 0;
    //           // float fraction = (myTimer * 100) % 100; float fraction1 = 0;
    //           // guitimer = GameObject.Find("timeleftt").GetComponent(GUIText)();
    //          //  guitimer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    //            //guitimer.font.material.color = Color.black;

    }
          if (myTimer <= 0)
    {
    //            //Debug.Log("GAME OVER");
       Application.LoadLevel("gameOver");
      }

     }
    /////////////////////////
    //public Text timer;
    //float minutes = 5;
    //float seconds = 0;
    //float miliseconds = 0;

    //void Update()
    //{

    //    if (miliseconds <= 0)
    //    {
    //        if (seconds <= 0)
    //        {
    //            minutes--;
    //            seconds = 59;
    //        }
    //        else if (seconds >= 0)
    //        {
    //            seconds--;
    //        }

    //        miliseconds = 100;
    //    }

    //    miliseconds -= Time.deltaTime * 100;

    //    //Debug.Log(string.Format("{0}:{1}:{2}", minutes, seconds, (int)miliseconds));
    //    timer.text = "Time Left:" +string.Format("{0}:{1}:{2}", minutes, seconds, (int)miliseconds);
    //}
}
