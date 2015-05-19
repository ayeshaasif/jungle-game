using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {
    public Canvas quitMenu;
    public Button playButton;
    public Button exitButton;

	// Use this for initialization
	void Start () 
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        playButton = playButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
        quitMenu.enabled = false;
	}
    public void ExitPress()
    {
        quitMenu.enabled = true;
        playButton.enabled = false;
        exitButton.enabled = false;

    }
    public void NoPress() 
    {
        quitMenu.enabled = false;
        playButton.enabled = true;
        exitButton.enabled = true;
    }
    public void startLevel() {
        Application.LoadLevel("forest");
    }
    public void exitGame() 
    {
        Application.Quit();
    }
}
