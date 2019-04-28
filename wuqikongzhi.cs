using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class wuqikongzhi : MonoBehaviour {

	public GameObject a;
	public GameObject b;
	public GameObject a1;
	public GameObject b1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void hide1(){
		a.SetActive (false);
		a1.GetComponent<Text> ().text="sold(Press‘c' to attack)";
	}

	public void hide2(){
		b.SetActive (false);
		b1.GetComponent<Text> ().text="sold(Jump higher)";
	}
}
