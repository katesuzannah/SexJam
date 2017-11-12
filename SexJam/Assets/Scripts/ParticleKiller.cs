using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleKiller : MonoBehaviour {

	public ParticleSystem dustSystem;
//	float delay;
//	public AudioClip [] clips;
//	AudioSource thisSource;
//	public static string tagName;
//	public static ParticleKiller thisKiller;
	//AudioSource aSource;
	//public AudioClip wallHit;

	void Start () {
//		thisKiller = this;
//		switch (tagName) {
//		case "skull":
//			thisSource.clip = clips [0];
//			break;
//		case "heart":
//			thisSource.clip = clips [1];
//			break;
//		case "cat":
//			thisSource.clip = clips [2];
//			break;
//		case "hourglass":
//			thisSource.clip = clips [3];
//			break;
//		case "money":
//			thisSource.clip = clips [4];
//			break;
//		case "paper":
//			thisSource.clip = clips [5];
//			break;
//		case "phone":
//			thisSource.clip = clips [6];
//			break;
//		case "pill":
//			thisSource.clip = clips [7];
//			break;
//		case "pot":
//			thisSource.clip = clips [8];
//			break;
//		case "record":
//			thisSource.clip = clips [9];
//			break;
//		case "tv":
//			thisSource.clip = clips [10];
//			break;
//		case "volume":
//			thisSource.clip = clips [11];
//			break;
//		}
//		if (gameObject.tag == "wallDust") {
//			aSource = GetComponent<AudioSource> ();
//			aSource.PlayOneShot (wallHit);
//		}
		//thisSource = GetComponent<AudioSource> ();
		dustSystem = GetComponent<ParticleSystem> ();
		//delay = 2f;
	}

	void FixedUpdate () {
		//delay -= Time.deltaTime;
		if (dustSystem.particleCount == 0) {//&& delay <= 0f) {
			Destroy (gameObject);
		}
	}

//	public static void GetObject (string tag) {
//		tagName = tag;
//	}
}
