﻿using UnityEngine;
using System.Collections;

public class BugRandom3 : MonoBehaviour {
	
	bool direction;		// true == right; false == left;
	int x;
	
	// Use this for initialization
	void Start () {
		x = 0;
		direction = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (x < 0) {
			x++;
			transform.Rotate(0,0,80);
			direction = true;
		} else if (x > 80) {
			x--;
			transform.Rotate (0,0,80);
			direction = false;
		} else {
			if (direction) {
				x++;
			} else if (direction == false) {
				x--;
			}
		}
		transform.Translate (new Vector3(0,-0.3f,0));
	}
}