using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
    float  myTimer = 6.67;
	// Update is called once per frame
	void Update () {
        if (myTimer > 0)
        {
            myTimer -= Time.deltaTime;
        }
        if (myTimer <= 0)
        {
            Debug.Log("GAME OVER");
        }
	}
}
