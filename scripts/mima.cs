using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;


public class mima : MonoBehaviour {

	public GameObject textarealdy;
	private int rightorno;
	public GameObject lockdoor;
	public GameObject tishi;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		rightorno=int.Parse(textarealdy.GetComponent<Text>().text);
		
	}

	public void checkisw(){

		if (rightorno == 86400) {

			setdoor ();
			tishi.SetActive (false);
			
		}

		if (rightorno != 86400) {
			tishi.SetActive (true);
		}


	}

	public void setdoor(){

		lockdoor.SetActive (false);
	}
}
