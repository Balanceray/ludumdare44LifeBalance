using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gift : MonoBehaviour {

	public Text water;
	//private int i=0;
	public dao s1;
	public daoro s2;
	public waternumeber w1;
	private int ccc;

	// Use this for initialization
	void Start () {
		ccc = GlobalControl.Instance.changjing;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D d){
		print ("s");
		if(d.collider.tag=="Player")
			//IsPlayer = true;
		{   //i++;
			//SavekkData();
			//water.text=i.ToString("0");
			w1.waterjia();
			s1.SaveJackData();
			s2.SaveRoseData();
			w1.SavekkData();
			ccc++;
			GlobalControl.Instance.changjing = ccc;
			//Destroy(gameObject);
			SceneManager.LoadScene ("house");

	}
}

	/*public void SavekkData(){

		GlobalControl.Instance.kk = i;
	}*/
}
