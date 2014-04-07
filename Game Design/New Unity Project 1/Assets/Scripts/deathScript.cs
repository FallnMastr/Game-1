using UnityEngine;
using System.Collections;

public class deathScript : MonoBehaviour {

	int count = 500;
	public AudioClip deathmusic;
	public static bool show;
	bool done;
	// Use this for initialization
	void Start () {
		show = false;
		done = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (show && done) {
			Player_Movement.isDead = true;
			level_music_loop.music.Stop();
			audio.PlayOneShot(deathmusic);
			transform.Translate(new Vector3(0,-400,0));
			done = false;		
		}
		if (done == false) {
			count--;
		}
		if (count <= 0) {
			game_timer.count = 780;
			Application.LoadLevel("Home Screen");
		}
	}
}
