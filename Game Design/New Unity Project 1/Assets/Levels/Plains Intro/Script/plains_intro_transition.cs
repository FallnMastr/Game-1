﻿using UnityEngine;
using System.Collections;

public class plains_intro_transition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		bool skip = Input.anyKey;
		if(skip){
			Application.LoadLevel("Plains");
		}

		if (Time.timeSinceLevelLoad.Equals (48)) {
			Application.LoadLevel("Plains");
		}
	}
}
