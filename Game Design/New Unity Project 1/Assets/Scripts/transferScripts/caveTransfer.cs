using UnityEngine;
using System.Collections;

public class caveTransfer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c){
		Application.LoadLevel ("Volcano Intro");
	}
}
