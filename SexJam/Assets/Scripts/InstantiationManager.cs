using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationManager : MonoBehaviour {

	public Transform circle;

	public static int totalThings;
	public int maxThings = 1;
	public GameObject sperm;
	int choice;
	public static int deflected;
	public float [] spawnX;
	public float[] spawnY;

	void Start () {
		deflected = 0;
	}

	void FixedUpdate () {
		if (totalThings < maxThings) {
			Instantiate (sperm, new Vector3 (spawnX[Random.Range((int)0, spawnX.Length)], spawnY[Random.Range((int)0, spawnY.Length)], 0f), Quaternion.LookRotation(circle.position));
			totalThings++;
		}
	}
}
