using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowJumpScript : MonoBehaviour {
	private Player player;

	void Start () {
		player = GameObject.FindWithTag ("Player").GetComponent<Player> ();
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			player.setAllowJump (true);
			player.animateJump (false);
		}
	}

	void OnCollisionExit2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			player.setAllowJump (false);
			player.animateJump (true);
		}
	}

}
