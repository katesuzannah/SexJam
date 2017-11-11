using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour {

//	public float radius;
//	float ang;
//	public float speed;
//	public Transform center;

	void Start () {
		
	}

	void FixedUpdate () {
//		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
//			ang -= speed;
//		}
//		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
//			ang += speed;
//		}
//		transform.position = (Vector2) center.position + Geo.ToVect(ang) * radius;
	}
	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "sperm") {
			InstantiationManager.totalThings--;
			InstantiationManager.deflected++;
			Destroy (col.gameObject);
		}
	}
}