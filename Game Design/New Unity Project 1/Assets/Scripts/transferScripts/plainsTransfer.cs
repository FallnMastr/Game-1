using UnityEngine;
using System.Collections;

public class plainsTransfer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c){
		Application.LoadLevel ("Forest Intro");
	}
}
