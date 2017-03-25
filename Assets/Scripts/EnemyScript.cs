using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
	public float speed;
	public float bounce;
	public bool freeMover;

	void turn(){
		if (speed > 0)
			transform.rotation = Quaternion.Euler (new Vector2 (0, 180));
		else
			transform.rotation = Quaternion.Euler (new Vector2 (0, 0));
		speed *= -1;
	}

	void Start () {
		if (freeMover)
			InvokeRepeating("turn",2,2);
	}

	void Update () {
		transform.position = new Vector3(transform.position.x + speed, transform.position.y , 0.0f);
	}

	void OnCollisionEnter2D(Collision2D other){

		if (other.gameObject.tag == "Player") {
			Player player = other.gameObject.GetComponent<Player> ();
			other.collider.enabled = false;
			other.gameObject.GetComponent<Rigidbody2D> ().isKinematic = true;
			player.kill ();

		}
		
		if (other.gameObject.tag == "SafeObject") {
			turn ();
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		print ("OnTriggerEnter2D");
		if (other.gameObject.tag == "Player") {
			Player player = other.GetComponent<Player> ();
			Destroy (gameObject);
			player.setAllowJump(true);
			player.jump(1000);
			player.setAllowJump(false);
		}
	}
}
