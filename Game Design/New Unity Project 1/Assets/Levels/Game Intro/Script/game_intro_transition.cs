using UnityEngine;
using System.Collections;

public class game_intro_transition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		bool skip = Input.anyKey;
		if(skip){
			Application.LoadLevel("Plains Intro");
		}

		if (Time.timeSinceLevelLoad.Equals (53)) {
			Application.LoadLevel("Plains Intro");
		}
	}
}
