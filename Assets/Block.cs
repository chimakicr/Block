using System.Collections;
using UnityEngine;

public class Block : MonoBehaviour {

	GameObject manager;


	void Start () {
		this.manager = GameObject.Find ("SceneManager");
	}
	

	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Ball") {
			Destroy (this.gameObject);
			this.manager.GetComponent<SceneManager> ().DestroyBlock ();
		}
	}

}
