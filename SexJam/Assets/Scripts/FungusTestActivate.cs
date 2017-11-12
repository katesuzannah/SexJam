using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FungusTestActivate : MonoBehaviour
{
	public GameObject flowchart;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return))
		{
			flowchart.SetActive(true);
		}
	}
}
