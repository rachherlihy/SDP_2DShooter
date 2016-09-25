﻿using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour
{
	public Vector2 speed = new Vector2 (50, 50);
	public Vector2 direction = new Vector2 (-1, 0);
	
	// Update is called once per frame
	void Update ()
    {
		Vector3 movement = new Vector3 (speed.x * direction.x, speed.y * direction.y, 0);
        movement *= Time.deltaTime;
		transform.Translate (movement);
	}
}
