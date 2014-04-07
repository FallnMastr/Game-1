using UnityEngine;
using System.Collections;

public class cave_music : MonoBehaviour {
	public static AudioSource music;
	// Use this for initialization
	void Start () {
		music = GetComponent<AudioSource>();
		music.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
