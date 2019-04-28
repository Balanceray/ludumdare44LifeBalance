using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class UIlogic : MonoBehaviour {

	public GameObject s;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void showabout(){

		s.SetActive (true);
		
	}

	public void hideabout(){
		s.SetActive (false);
	}

	public void Startgame(){
		SceneManager.LoadScene ("house");
	}
}
