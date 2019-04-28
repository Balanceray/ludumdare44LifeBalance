using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroller : MonoBehaviour {

	// Use this for initialization
	private Vector2 fa;
	// Use this for initialization
	void Start () { 
		fa = transform.InverseTransformDirection (Vector2.right);
	}

	// Update is called once per frame
	void Update () {

		GetComponent<Rigidbody2D> ().AddForce (fa * 400);
	}

	public void OnCollisionEnter2D(){

		Destroy (gameObject);
	}
}
