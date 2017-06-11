using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

  public Button playText;
  public Button quitText;
  
	void Start () {
		playText = playText.GetComponent<Button>();
		quitText = quitText.GetComponent<Button>();
	}
	
	public void PressPlay(){
		 SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
	}

	public void PressQuit(){
		 Application.Quit();
	}

}
