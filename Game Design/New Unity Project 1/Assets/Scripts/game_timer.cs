using UnityEngine;
using System.Collections;
using System;

public class game_timer : MonoBehaviour {
	private GUIStyle textstyle = new GUIStyle();

	public static float count = 900;

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
		if(FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel >= 1 && Application.loadedLevel <=5) { //playable levels are 1-5
			count -= Time.deltaTime;
		}
		if (count <= 0) {
			deathScript.show = true;
		}


	
			if(Input.GetKeyDown (KeyCode.Q)){
				Application.LoadLevel("Plains Intro");
			}
			if(Input.GetKeyDown (KeyCode.W)){
				Application.LoadLevel("Forest Intro");
			}
			if(Input.GetKeyDown (KeyCode.E)){
				Application.LoadLevel("Cave Intro");
			}
			if(Input.GetKeyDown (KeyCode.R)){
				Application.LoadLevel("Volcano Intro");
			}
			if(Input.GetKeyDown (KeyCode.T)){
				Application.LoadLevel("Fortress Intro");
			}
	
	}

	void OnGUI(){
		textstyle.fontSize = (int)Math.Floor (0.021378*UnityEngine.Screen.width)-1;
		textstyle.fontStyle = FontStyle.Bold;
		textstyle.alignment = TextAnchor.MiddleCenter;
		if (count < 0 || Application.loadedLevel > 5 || Application.loadedLevel == 0) {
			textstyle.normal.textColor = UnityEngine.Color.clear;
		}
		else if (count < 180) {
				textstyle.normal.textColor = UnityEngine.Color.red;		
				} 
		else if (count < 300) {
				textstyle.normal.textColor = UnityEngine.Color.yellow;		
				} 

		else {
				textstyle.normal.textColor = UnityEngine.Color.black;		
		}
		//TimeSpan timerem = new TimeSpan(count);
		//string text = string.Format ("{0,-2}:{1,-2}", (count/60), ((count%60)/60));//("{0:00}:{1:00}", 20, 59);
		string text = string.Format ("O\u2082 Remaining:\n{0:00}:{1:00}", Math.Floor(count/60), Math.Floor(count%60));
		GUI.Label(new Rect((float)0.79*UnityEngine.Screen.width, (float)0.065*UnityEngine.Screen.height, (float)0.065*UnityEngine.Screen.width, (float)0.0128*UnityEngine.Screen.height), text, textstyle);
	}
}
