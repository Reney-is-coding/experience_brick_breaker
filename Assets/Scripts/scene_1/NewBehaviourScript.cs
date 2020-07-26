using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

	{
	    public float maxSpeed = 2f;
	    Rigidbody2D rigid2D;
			Boucing_script Bouncy;
			int stop = 0;
			float move = 0;

	    void Start()
	    {
	        rigid2D = GetComponent<Rigidbody2D>();
	    }

	    void Update()
	    {
				Bouncy = GameObject.Find("Ball").GetComponent<Boucing_script>();

				if (Bouncy.nb_bricks == 0 || Bouncy.lose)
					stop = 2;
				if (Input.GetKeyDown(KeyCode.P) && stop == 0) {
					stop = 1;
				}
				if (Input.GetKeyDown(KeyCode.Space) && stop == 1) {
					stop = 0;
					rigid2D.velocity = new Vector2(move * maxSpeed, 0);
				}
				if (stop == 0) {
	        move = Input.GetAxis("Horizontal");
	        rigid2D.velocity = new Vector2(move * maxSpeed, 0);
				}
	    }
	}
