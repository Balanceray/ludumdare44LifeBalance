using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;


public class waternumeber : MonoBehaviour {

	public int pp;
	public GameObject w;

	// Use this for initialization
	void Start () {
		pp = GlobalControl.Instance.kk;	
	}
	
	// Update is called once per frame
	void Update () {

		w.GetComponent<Text>().text = pp.ToString("0");
	}

	public void SavekkData(){

		GlobalControl.Instance.kk = pp;
	}

	public void waterjia(){
		pp++;
	}

	public void watershao(){
		pp--;
	}
}
