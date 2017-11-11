using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationManager : MonoBehaviour {

	public Transform circle;

	public static int totalThings;
	public int maxThings = 1;
	public GameObject sperm;
	public GameObject [] things;
	int choice;
	public static int deflected;
	public float [] spawnX;
	public float[] spawnY;

	void Start () {
		deflected = 0;
	}

	void FixedUpdate () {
		if (totalThings < maxThings) {
			if (deflected < 5) {
				Instantiate (sperm, new Vector3 (spawnX [Random.Range ((int)0, spawnX.Length)], spawnY [Random.Range ((int)0, spawnY.Length)], 0f), Quaternion.identity);
				totalThings++;
			} else {
				choice = Random.Range ((int)0, things.Length);
				Instantiate (things [choice], new Vector3 (spawnX [Random.Range ((int)0, spawnX.Length)], spawnY [Random.Range ((int)0, spawnY.Length)], 0f), Quaternion.identity);
				totalThings++;
			}
		}
	}
}
