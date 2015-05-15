using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {

	
	
	// Update is called once per frame
public 	void changeToScene(string sceneTochangeTo)
    {
        Application.LoadLevel(sceneTochangeTo);
	}
}
