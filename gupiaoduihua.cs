using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gupiaoduihua : MonoBehaviour {

	public GameObject showsd;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D d){

		if (d.collider.tag == "Player") {

			showsd.SetActive (true);


		}	
	}

	public void talkConti(){


		showsd.SetActive (false);
		gameObject.SetActive (false);
	}



}
