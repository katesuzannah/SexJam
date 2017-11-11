using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sperm : MonoBehaviour {

//	Rigidbody2D rb;
	GameObject circle;
//	float xSpeed;
//	float ySpeed;
	float speed;

	void Start () {
//		rb = GetComponent<Rigidbody2D> ();
		circle = GameObject.FindGameObjectWithTag ("circle");
		speed = Random.Range (0.05f, .5f);
	}

	void FixedUpdate () {
		//transform.position += new Vector3 (xSpeed, ySpeed, 0f);
		//transform.position = Vector3.Lerp(transform.position, circle.transform.position, Time.deltaTime*1.5f);
		transform.position = Vector3.MoveTowards (transform.position, circle.transform.position, speed);
	}

//	void Destroy () {
//		InstantiationManager.totalThings--;
//		Destroy (gameObject);
//	}
}
