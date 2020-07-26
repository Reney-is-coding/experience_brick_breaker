using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Light_script : MonoBehaviour {
	Light halo;
  double size  = 0;

	void Start () {
		halo = GetComponent<Light>();
		halo.enabled = true;
		halo.range = (float)size;
	}

	void Update () {
		if (size < 2 && size != 0)
			size += 0.2;
		if (size > 2)
			size = 0;
		halo.range = (float)size;
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "Top_Wall" && size == 0)
			size = 1;
		if ((col.gameObject.name == "Left_Wall" || col.gameObject.name == "Right_Wall") && size == 0)
			size = 1;
	}

}
