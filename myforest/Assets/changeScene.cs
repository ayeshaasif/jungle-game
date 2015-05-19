using UnityEngine;
using System.Collections;

public class changeScene : MonoBehaviour {

	
	

public 	void changeToScene(string sceneTochangeTo)
    {
        Application.LoadLevel(sceneTochangeTo);
	}
}
