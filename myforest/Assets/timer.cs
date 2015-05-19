using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour
{

	// Use this for initialization
  public float myTimer = 8.0f;
	// Update is called once per frame
	void Update () 
    {
        if (myTimer > 0)
        {
            myTimer -= Time.deltaTime;
        }
        if (myTimer <= 0)
        {
            //Debug.Log("GAME OVER");
            Application.LoadLevel("gameOver");
        }

	}

}
