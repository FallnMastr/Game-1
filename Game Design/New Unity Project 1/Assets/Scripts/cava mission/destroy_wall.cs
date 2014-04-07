using UnityEngine;
using System.Collections;

public class destroy_wall : MonoBehaviour {

	Animator animate;
	public AudioClip wall_explosion;
	// Use this for initialization
	void Start () {
		animate = GameObject.Find("Explosion").GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision c){
		if (c.gameObject.name.ToString ().Equals ("Player")) {

			if(Player_Movement.hasTNT){
				/*explosion_animator.*/animate.SetTrigger ("explode");
				audio.PlayOneShot(wall_explosion);
				transform.Translate(new Vector3(0,-400,0));
				withoutTNTScript.display = false;
				/*explosion_animator.*/animate.SetTrigger("explode");
			}
			else{
				withoutTNTScript.display = true;
			}

		}

	}
}
