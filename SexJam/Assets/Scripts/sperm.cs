using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sperm : MonoBehaviour {

//	Rigidbody2D rb;
	GameObject circle;
	public GameObject particle;
//	float xSpeed;
//	float ySpeed;
	float speed;
	//GameObject thisParticle;
	Sound sound;
	public AudioClip [] clips;
	public AudioClip spermDeflect;
	public AudioClip spermFail;
	int clipChoice;

//	GameObject flowchart;

	void Start () {
		//flowchart = GameObject.FindGameObjectWithTag ("flowchart");
		sound = GameObject.FindGameObjectWithTag ("audioManager").GetComponent<Sound> ();
//		rb = GetComponent<Rigidbody2D> ();
		circle = GameObject.FindGameObjectWithTag ("circle");
		speed = Random.Range (0.05f, .5f);
		transform.localEulerAngles = new Vector3 (0f, 0f, Geo.ToAng(transform.position, circle.transform.position)+90f);

		switch (gameObject.tag) {
		case "skull":
			clipChoice = 0;
			break;
		case "heart":
			clipChoice = 1;
			break;
		case "cat":
			clipChoice = 2;
			break;
		case "hourglass":
			clipChoice = 3;
			break;
		case "money":
			clipChoice = 4;
			break;
		case "paper":
			clipChoice = 5;
			break;
		case "phone":
			clipChoice = 6;
			break;
		case "pill":
			clipChoice = 7;
			break;
		case "pot":
			clipChoice = 8;
			break;
		case "record":
			clipChoice = 9;
			break;
		case "tv":
			clipChoice = 10;
			break;
		case "volume":
			clipChoice = 11;
			break;
		case "pizza":
			clipChoice = 12;
			break;
		case "allright":
			clipChoice = 13;
			break;
		case "okay":
			clipChoice = 14;
			break;
		case "stop":
			clipChoice = 15;
			break;
		case "whatsup":
			clipChoice = 16;
			break;
		case "distracted":
			clipChoice = 17;
			break;
		}
	}

	void FixedUpdate () {
		//transform.position += new Vector3 (xSpeed, ySpeed, 0f);
		//transform.position = Vector3.Lerp(transform.position, circle.transform.position, Time.deltaTime*1.5f);
		transform.position = Vector3.MoveTowards (transform.position, circle.transform.position, speed);
	}

	void OnCollisionEnter2D (Collision2D col) {
		Instantiate (particle, transform.position, Quaternion.identity);
//		if (gameObject.tag == "stop" || gameObject.tag == "okay" || gameObject.tag == "allright" || gameObject.tag == "whatsup" || gameObject.tag == "distracted") {
//			flowchart.SetActive (true);
//		}
		if (gameObject.tag != "sperm") {
			sound.Play (clips [clipChoice]);
		}
		//ParticleKiller.tagName = gameObject.tag;
		if (col.gameObject.tag == "shield") {
			if (gameObject.tag == "sperm") {
				sound.Play (spermDeflect);
			}
			InstantiationManager.totalThings--;
			InstantiationManager.deflected++;
			Destroy (gameObject);
		}
		else if (col.gameObject.tag == "circle") {
			if (gameObject.tag == "sperm") {
				sound.Play (spermFail);
			}
			InstantiationManager.totalThings--;
			Destroy (gameObject);
		}
	}
}