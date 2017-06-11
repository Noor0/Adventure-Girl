using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour {

	public int coinValue;
	private GameController gameController;
	// Use this for initialization
	void Start () {
		gameController = GameObject.FindWithTag ("GameController").GetComponent<GameController> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player") {
			gameController.addScore (coinValue);
			Destroy (gameObject);
		}
	}
}
