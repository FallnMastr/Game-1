using UnityEngine;
using System.Collections;

public class withoutTNTScript: MonoBehaviour {

	public static bool display;
	bool done;
	// Use this for initialization
	void Start () {
		display = false;
		done = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (display && done) {
			transform.Translate(new Vector3(0,-400,0));
			done = false;
		}
		if (!display && !done) {
			transform.Translate(new Vector3(0,400,0));
		}
	}

}
