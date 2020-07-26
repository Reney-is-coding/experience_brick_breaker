using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_button : MonoBehaviour {
	int width = Screen.width;
	int height = Screen.height;

	void Start () {

	}
	void Update () {

	}
	void OnGUI () {
    if (GUI.Button(new Rect(width/2-width/20, height/4, width/10, 30), "Play")) {
        SceneManager.LoadScene("scene_1");
    }
		if (GUI.Button(new Rect(width/2-width/20, (height/4)*2, width/10, 30), "How to play")) {
        SceneManager.LoadScene("How_to_play");
    }
		if (GUI.Button(new Rect(width/2-width/20, (height/4)*3, width/10, 30), "Quit")) {
        Application.Quit();
    }
 }
}
