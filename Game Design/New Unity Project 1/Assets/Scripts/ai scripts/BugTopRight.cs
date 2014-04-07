using UnityEngine;
using System.Collections;

public class BugTopRight : MonoBehaviour {

	int x;

	// Use this for initialization
	void Start () {
		x = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (x == 99) {
			transform.Rotate(0,0,90);
		} else if (x == 132) {
			transform.Rotate(0,0,90);
		} else if (x == 198) {
			transform.Rotate(0,0,-90);
		} else if (x == 264) {
			transform.Rotate(0,0,90);
		} else if (x == 297) {
			transform.Rotate(0,0,90);
		} else if (x == 396) {
			x = 0;
			transform.Rotate(0,0,90);
		}
		x++;
		transform.Translate (new Vector3(0,-0.3f,0));
	}
}
