using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boucing_script : MonoBehaviour {

	public float maxSpeed = 2f;
	Rigidbody2D rigid2D;
	int vertical_move = -2;
	float Horizontal_move = 0;
	int stop = 0;
	public int nb_bricks = 75;
	public bool lose = false;

	// Use this for initialization
	void Start ()
	{
		rigid2D = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update ()
	{
		if (nb_bricks == 0) {
			stop = 2;
			rigid2D.velocity = new Vector2(0,0);
		}
		if (Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene("Home_page");
		}
		if (Input.GetKeyDown(KeyCode.P) && stop == 0) {
			stop = 1;
			rigid2D.velocity = new Vector2(0, 0);
		}
		if (Input.GetKeyDown(KeyCode.Space) && stop == 1) {
			stop = 0;
			rigid2D.velocity = new Vector2(Horizontal_move, vertical_move);
		}
		if (stop == 0)
			rigid2D.velocity = new Vector2(Horizontal_move, vertical_move);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "Bar") {
		vertical_move *= -1;
		Horizontal_move = rigid2D.velocity.x;
	}
		if (col.gameObject.name == "Top_Wall")
			vertical_move *= -1;
		if (col.gameObject.name == "Left_Wall" || col.gameObject.name == "Right_Wall")
				Horizontal_move *= -1;
		if (col.gameObject.tag == "Brick") {
			vertical_move *= -1;
			Destroy(col.gameObject);
			nb_bricks -= 1;
		}
		if (col.gameObject.name == "Main_Camera") {
			stop = 2;
			lose = true;
			rigid2D.velocity = new Vector2(0,0);
		}
	}
	void  OnTriggerEnter2D(Collider2D trig) {
		Horizontal_move *= -1;
		Destroy(trig.gameObject);
		nb_bricks -= 1;
	}
}
