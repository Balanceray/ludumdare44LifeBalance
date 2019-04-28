using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flytos : MonoBehaviour {
	//public static dao Instance1;
	//public static daoro Instance2;
	public dao s1;
	public daoro s2;
	public waternumeber w1;
	private bool IsPlayer;
	public int cc;

	// Use this for initialization
	void Start () {

		IsPlayer = false;
		cc=GlobalControl.Instance.changjing;
		if (cc == 0) {
			cc = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (IsPlayer) {
			//SceneManager.LoadScene ("main");

			//dao.Instance1.SaveJackData ();
			//daoro.Instance2.SaveRoseData ();
			s1.SaveJackData();
			s2.SaveRoseData ();
			w1.SavekkData ();
			rrr ();
			//cc++;
			//Invoke ("rrr", 3f);
		}

		
	}

	public void OnCollisionEnter2D(Collision2D d){

		if(d.collider.tag=="Player")
			IsPlayer = true;

	}

	public void rrr(){
		
		SceneManager.LoadScene ("main"+cc.ToString("0"));
		//cc++;
		GlobalControl.Instance.changjing = cc;
	}
}
