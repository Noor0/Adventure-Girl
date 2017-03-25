using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = player.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if ( rb.transform.position.x > 0)
			transform.position = new Vector3( (rb.transform.position.x - transform.position.x)/2 + transform.position.x, 13.73f, -10.0f);
	}
}
