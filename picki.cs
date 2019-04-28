using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picki : MonoBehaviour {

	public GameObject baozhida;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D d){

		if(d.collider.tag=="Player")
			baozhida.SetActive(true);

	}

	public void OnCollisionExit2D(Collision2D d){

		if(d.collider.tag=="Player")
			baozhida.SetActive(false);
	}

}
