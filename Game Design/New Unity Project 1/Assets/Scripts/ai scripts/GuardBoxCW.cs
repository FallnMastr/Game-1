using UnityEngine;
using System.Collections;

public class GuardBoxCW : MonoBehaviour {
	
	int x;

	// Use this for initialization
	void Start () {
		x = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (x > 64) {
			transform.Rotate(0,0,-90);
			x = 0;
		} else {
			x++;
		}
		transform.Translate (new Vector3 (0, -0.3f, 0));
	}
}
