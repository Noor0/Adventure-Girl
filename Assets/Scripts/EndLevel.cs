using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour {

	public int levelTo;

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "Player")
			StartCoroutine(Go());
	}

	IEnumerator Go(){
		yield return new WaitForSeconds(1);
		switch(levelTo){
			case 2:
				SceneManager.LoadScene("Level 2", LoadSceneMode.Single);
				break;
			case 3:
				SceneManager.LoadScene("Level 3", LoadSceneMode.Single);
				break;
			case 4:
				SceneManager.LoadScene("Finish", LoadSceneMode.Single);
				break;
		}
	}

}
