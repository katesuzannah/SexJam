﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour {

	float direction;
	public float speed;

	void Start () {
		
	}

	void FixedUpdate () {
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
//			direction = speed;
			transform.Rotate (0f, 0f, -speed);
		}
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
//			direction = -speed;
			transform.Rotate (0f, 0f, speed);
		}
//		transform.localEulerAngles += new Vector3 (0f, 0f, direction);
	}
}
