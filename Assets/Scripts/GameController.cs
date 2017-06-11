using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private bool gameOver = false;
	public Text scoreText;
	private int score = 0;

	public void addScore(int scoreToAdd){
		score += scoreToAdd;
		scoreText.text = "Score: " + score;
	}

	public void endGame(){
		gameOver = true;
	}

	void Update () {
		if (gameOver) {
			
		}
	}

}
