using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private float speed = 10.0f;


	void Start () {

		this.GetComponent<Rigidbody> ().AddForce (
			(transform.forward + transform.right) * speed,
			ForceMode.VelocityChange);
	}
	

	void Update () {
		
	}
		
		
}


