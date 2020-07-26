using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning_wall_brick : MonoBehaviour {
	public Transform brick;
	int spawn_x = -8;
	int spawn_y = 4;

	void Start() {
	    for (int y = 0; y < 5; y++) {
	        for (int x = 0; x < 15; x++) {
	            Instantiate(brick, new Vector2(spawn_x, spawn_y), Quaternion.identity);
								spawn_x += 1;
	        }
					spawn_y -= 1;
					spawn_x = -8;
	    }
	}
}
