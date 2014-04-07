using UnityEngine;
using System.Collections;

public class cave_intro_transition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		bool skip = Input.anyKey;
		if(skip){
			Application.LoadLevel("Cave");
		}

		if (Time.timeSinceLevelLoad.Equals (48)) {
			Application.LoadLevel("Cave");
		}
	}
}
