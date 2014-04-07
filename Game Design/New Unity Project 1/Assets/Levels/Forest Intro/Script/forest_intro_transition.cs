using UnityEngine;
using System.Collections;

public class forest_intro_transition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		bool skip = Input.anyKey;
		if(skip){
			Application.LoadLevel("Forest");
		}

		if (Time.timeSinceLevelLoad.Equals (54)) {
			Application.LoadLevel("Forest");
		}
	}
}