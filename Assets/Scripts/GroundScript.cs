using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {
	private Player player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player").GetComponent<Player> ();
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			player.setAllowJump (true);
			player.animateJump (false);
		}
	}

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			player.setAllowJump (true);
			player.animateJump (false);
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			player.setAllowJump (false);
			player.animateJump (true);
		}
	}

}
