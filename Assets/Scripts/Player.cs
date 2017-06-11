using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed;
	public float jumpSpeed;
	private Rigidbody2D rb;
	private Animator animator;
	private bool allowJump = true;
	private bool isDead = false;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		if(!isDead){
			float movementHorizontal = Input.GetAxis ("Horizontal");
			animator.SetBool ("Run", false);
			if (movementHorizontal > 0 || movementHorizontal < 0) {
				if (movementHorizontal < 0)
					transform.rotation = Quaternion.Euler (new Vector2 (0, 180));
				else
					transform.rotation = Quaternion.Euler (new Vector2 (0, 0));
		
				rb.velocity = new Vector2 (speed * movementHorizontal, rb.velocity.y);
				animator.SetBool ("Run", true);

			}
			if (Input.GetKeyDown ("w") && allowJump == true) {
				animator.SetBool ("Run", false);
				jump (jumpSpeed);
			}
		}
	}

	public void kill(){
		isDead = true;
		animator.SetBool ("Dead", true);
		rb.velocity = new Vector2 (0.0f, 0.0f);
		Invoke("End", 1);
	}

	void End(){
		SceneManager.LoadScene("Dead",LoadSceneMode.Single);
	}

	public void animateJump(bool state){
		animator.SetBool ("Jump", state);
	}

	public void jump (float speedOfJump){
		rb.AddForce (new Vector2 (0, speedOfJump), ForceMode2D.Impulse);
	}

	public void setAllowJump(bool state){
		allowJump = state;
	}

}
