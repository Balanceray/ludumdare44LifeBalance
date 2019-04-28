using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveornot : MonoBehaviour {

	public  GameObject h;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnCollisionEnter2D(Collision2D d){
		print ("s");
		if(d.collider.tag=="Player")
			//IsPlayer = true;
		{  // i++;
			//water.text=i.ToString("0");
			h.SetActive(true);
		}
}

	public void OnCollisionExit2D(Collision2D d){
		
		if(d.collider.tag=="Player")
			//IsPlayer = true;
		{  // i++;
			//water.text=i.ToString("0");
			h.SetActive(false);
		}
	}
}
