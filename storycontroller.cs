using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class storycontroller : MonoBehaviour {

	public GameObject s1;
	public GameObject s2;
	public GameObject s3;
	public GameObject s4;
	public GameObject d1;
	public GameObject d2;
	public GameObject d3;
	public int ccj;

	// Use this for initialization
	void Start () {

		ccj = GlobalControl.Instance.changjing;
		if (ccj == 0) {
			ccj = 1;
		}
		if (ccj == 1) {
			s1.SetActive (true);
		}
		if (ccj == 2) {
			s2.SetActive (true);
		}
		if (ccj == 3) {
			s3.SetActive (true);
		}

		if (ccj == 4) {
			s4.SetActive (true);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void storyhide(){

		s1.SetActive (false);

	}

	public void dilogshow1(){
		d1.SetActive (true);
	}

	public void dilogshow2(){
		d1.SetActive (false);
		d2.SetActive (true);
	}
	public void dilogshow3(){
		d2.SetActive (false);
		d3.SetActive (true);
	}

	public void dilogend(){
		d3.SetActive (false);
	}
}
