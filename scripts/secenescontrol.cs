using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secenescontrol : MonoBehaviour {


	public int cj;

	public GameObject ttad;
	public GameObject lastjiage1;
	public GameObject lastjiage2;
	public GameObject jiage1;
	public GameObject jiage2;
	// Use this for initialization
	void Start () {

		cj=GlobalControl.Instance.changjing;
		if (cj == 0) {
			cj = 1;
		}

		if (cj == 1) {
			house1 ();
		}

		if (cj == 2) {
			house2 ();
		}
		if (cj == 3) {

			house3 ();
		}
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	public void house1(){
		

	}

	public void house2(){

		ttad.SetActive (true);
	}

	public void house3(){
		ttad.SetActive (true);
		lastjiage1.GetComponent<Text> ().text="Death tech(last price12)";
		lastjiage2.GetComponent<Text> ().text="Death tech(last price9)";
		jiage1.GetComponent<Text> ().text="15";
		jiage2.GetComponent<Text> ().text="12";
	}

	public void house4(){
		
	}

	public void house5(){
		
	}
}
