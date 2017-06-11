using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class DeadScript : MonoBehaviour {

	private Text score;

	

	void Start(){
		Destroy(GameObject.FindWithTag("MusicController"));
		score = GameObject.FindWithTag("ScoreText").GetComponent<Text>();
		score.color = new Color(255.0f, 255.0f, 255.0f);
		score.fontSize = 64;
		score.alignment = TextAnchor.MiddleCenter;
		GameObject.FindWithTag("ScoreText").GetComponent<RectTransform>().localPosition = new Vector3(-175,20,0);
		GameObject.FindWithTag("ScoreText").GetComponent<RectTransform>().sizeDelta = new Vector2 (349, 70);
	}

	public void RestartGame(){
		SceneManager.LoadScene("Level 1",LoadSceneMode.Single);
		Destroy(score.gameObject);
		Destroy(GameObject.FindWithTag("GameController"));
	}

	public void QuitGame(){
		Application.Quit();
	}

}
