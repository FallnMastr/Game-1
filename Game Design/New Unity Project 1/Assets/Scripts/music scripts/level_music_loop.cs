using UnityEngine;
using System.Collections;

public class level_music_loop : MonoBehaviour {
	public static AudioSource music;
	// Use this for initialization
	void Start () {
		music = GetComponent<AudioSource>();
		//music.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}