using UnityEngine;
using System.Collections;

public class outroTransfer : MonoBehaviour {

	int count = 100;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		count--;
		if(count < 0){
			bool skip = Input.anyKey;
			if(skip){
				Application.LoadLevel("Home Screen");
			}
		}
		
		if (Time.timeSinceLevelLoad >= 300) {
			Application.LoadLevel("Home Screen");
		}
	}
}
