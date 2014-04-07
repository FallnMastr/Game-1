using UnityEngine;
using System.Collections;

public class lava38_10 : MonoBehaviour {
	
	int frame_count = 0;
	int move_speed = 6;
	
	int activation = 3170 + offsetlava.offset;
	int movement = 120;
	
	bool init = true;
	
	// Use this for initialization
	void Start () {
		renderer.enabled = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (frame_count >= activation && movement > 0) {
			if(init){
				transform.Translate(new Vector3(0,-400,0));
				init = false;
			}
			renderer.enabled = true;
			transform.Translate(Vector3.right * Time.deltaTime * move_speed);
			movement--;
		}
		else{
			frame_count++;
		}
	}
}
