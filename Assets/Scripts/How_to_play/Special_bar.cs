using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Special_bar : MonoBehaviour {
	public float maxSpeed = 2f;
	Rigidbody2D rigid2D;
	float move = 0;

	void Start()
	{
			rigid2D = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
			move = Input.GetAxis("Horizontal");
			rigid2D.velocity = new Vector2(move * maxSpeed, rigid2D.velocity.y);
	}
}
