﻿using UnityEngine;
using System.Collections;

public class lavaTransfer: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c){
		Application.LoadLevel ("Fortress Intro");
	}
}