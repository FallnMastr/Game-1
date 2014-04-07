using UnityEngine;
using System.Collections;

public class game_intro_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool start = Input.GetKeyDown (KeyCode.Space);

		if (start) {
			Application.LoadLevel("Game Start");
		}
	}
}
