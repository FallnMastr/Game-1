using UnityEngine;
using System.Collections;

public class forestTransfer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c){
		Application.LoadLevel ("Cave Intro");
	}
}
