using UnityEngine;
using System.Collections;
public class timer : MonoBehaviour
{
//public GUIText guiscore ;
//public GUIText guitimer;
//	public float time;
	// Use this for initialization
  public float myTimer = 300.0f;
	// Update is called once per frame
	void start(){
		    //guiscore.text = "Score: 0";
		    //guiscore.font.material.color = Color.black;
	}
	void Update () 
    {

        if (myTimer > 0)
        {
            myTimer -= Time.deltaTime;
//			float minutes = myTimer / 60; float minutes1 = 0;
//			float seconds = myTimer % 60; float seconds1 = 0;
//			float fraction = (myTimer * 100) % 100; float fraction1 = 0;
//			guitimer.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);
//			guitimer.font.material.color = Color.black;

        }
        if (myTimer <= 0)
        {
            //Debug.Log("GAME OVER");
            Application.LoadLevel("gameOver");
        }

	}

}
