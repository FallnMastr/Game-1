using UnityEngine;
using System.Collections;

public class Guard01 : MonoBehaviour {


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
			transform.Rotate(0,0,180);
			direction = true;
		} else if (x > 225) {
			x--;
			transform.Rotate (0,0,180);
			direction = false;
		} else {
			if (direction) {
				x++;
			} else if (direction == false) {
				x--;
			}
		}
		transform.Translate(Vector3.down * (Time.deltaTime*10));
	}
}
