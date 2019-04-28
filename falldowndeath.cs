using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falldowndeath : MonoBehaviour {

	public GameObject showover;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D d){
		
		if(d.collider.tag=="Player")
			
		{   
			
			showover.SetActive (true);
		}
	}
}
