using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {
	GameObject scoreCount;
	int score = 0;

	public void DestroyBlock(){
		this.score += 300;
	}

	void Start () {
		this.scoreCount = GameObject.Find ("Score");
	}
	

	void Update () {
		this.scoreCount.GetComponent<Text> ().text =
				"Score" + this.score.ToString ();
	}
}
