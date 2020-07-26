using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win_condition : MonoBehaviour {

  public Text winText;
	Boucing_script Bouncy;
	void Start () {
		winText.text = "";
	}

	// Update is called once per frame
	void Update () {
		Bouncy = GameObject.Find("Ball").GetComponent<Boucing_script>();
		if (Bouncy.nb_bricks <= 0 && !Bouncy.lose) {
		 	winText.text = "Victory";
		} else if (Bouncy.lose) {
			winText.text = "Defeat";
		}
	}
}
