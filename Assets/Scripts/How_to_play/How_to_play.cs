using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class How_to_play : MonoBehaviour {

	public Text winText;
	// Use this for initialization
	void Start () {
		winText.text = "On this brick breaker game, you can interact with differents elements.\n You can move the bar (which is the same as the one at the bottom of the screen) by using rigth and left arrows.\n Whenever you want you can press \"Escape\" to return to the home page.\n You can also use  \"P\" to pause the game and use \"Space\" to left the pause.\n You win the game when all bricks are destoryed.\n You lose when the ball go exit the screen by going throught the bottom of the screen.";
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene("Home_page");
		}
	}
}
