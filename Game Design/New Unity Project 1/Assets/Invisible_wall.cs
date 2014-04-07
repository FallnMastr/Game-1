using UnityEngine;
using System.Collections;

public class Invisible_wall : MonoBehaviour {
	bool intro;
	private Vector3 introv = new Vector3(0,(float)73.5,-1);
	// Use this for initialization
	void Start () {
		intro = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(intro){
			transform.position = Vector3.Lerp(transform.position,introv,Time.deltaTime);
			if(transform.position.y <= 74)
			{
				intro = false;
			}
		}
	}
}
