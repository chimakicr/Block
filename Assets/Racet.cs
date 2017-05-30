using System.Collections;
using UnityEngine;

public class Racet : MonoBehaviour {

	private float accel = 1000.0f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody> ().AddForce (
			transform.right * Input.GetAxisRaw ("Horizontal") * accel,
			ForceMode.Impulse);
	}
}
	