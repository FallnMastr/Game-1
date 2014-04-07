using UnityEngine;
using System.Collections;

public class fade_in : MonoBehaviour {

	float a = 1;
	int count = 500;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		while(this.gameObject.renderer.material.color.a > 0){

			count++;
			if(count % 500 == 0){
				Debug.Log("a:"+this.gameObject.renderer.material.color.a);

				a -= Mathf.Clamp01(Time.deltaTime / 10);
				Color c = new Color(0,0,0,a);
				this.gameObject.renderer.material.color = c;

				count = 0;
			}
		}
	}
}
