using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showwhoadd : MonoBehaviour {

	public GameObject jacktext;
	public GameObject rosetext;
	public GameObject notext;
	private int  dds;


	// Use this for initialization
	void Start () {
		dds = GlobalControl.Instance.kk;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void jacktextshow(){
		if (dds > 0) {
			jacktext.SetActive (true);
			Invoke ("deee", 1f);
		
		}

		if (dds <= 0) {
			notext.SetActive (true);
			Invoke ("deee", 1f);
		}
	}

	public void rosetextshow(){
		if (dds > 0) {
			rosetext.SetActive (true);
			Invoke ("deee", 1f);
	
		}
		if (dds <= 0) {
			notext.SetActive (true);
			Invoke ("deee", 1f);
		}
	}

	public  void deee(){
		jacktext.SetActive (false);
		rosetext.SetActive (false);
		notext.SetActive (false);
		dds--;
	}
}
