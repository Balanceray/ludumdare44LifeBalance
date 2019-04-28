using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doormis : MonoBehaviour {

	public GameObject baa;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D d){
		print ("m");
		if(d.collider.tag=="Player")
			
		{   
			baa.SetActive (true);

		}
	}

	public void OnCollisionExit2D(Collision2D d){

		if(d.collider.tag=="Player")
			baa.SetActive (false);	
	}
}
