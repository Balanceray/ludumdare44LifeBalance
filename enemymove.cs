using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemymove : MonoBehaviour {
	
public float movespeed=1.0f;
private Vector2 currentposition;
public float distnation=2.0f;
private int face = 1;
	public dao zheli;
	public GameObject wanjia;
	public int xueliang=4;
	private bool death=false;
	//public Sprite de;
	//public AudioClip hurts;




// Use this for initialization
	void Start () {
		currentposition = gameObject.transform.position;
	}
// Update is called once per frame
	void Update () {
		if (xueliang > 0) {
			if (face == 1) {
				gameObject.transform.Translate (Vector2.right * movespeed * Time.deltaTime);
			}
			if (face == 0) {
				gameObject.transform.Translate (Vector2.left * movespeed * Time.deltaTime);
			}
			if (gameObject.transform.position.x > currentposition.x + distnation) {
				face = 0;
			}
			if (gameObject.transform.position.x < currentposition.x) {
				face = 1;
			}
		}

		if (xueliang <= 0) {

			//GetComponent<SpriteRenderer> ().sprite = de;
			//GetComponent<Animator>().Play("deathd",0,0.2);

			GetComponent<Animator> ().SetBool ("death", true);
			death = true;
		}
	}

	public void OnCollisionEnter2D(Collision2D d){

		if(d.collider.tag=="Player"&&death==false)
			//IsPlayer = true;

		{   
			//print ("d");
			wanjia.GetComponent<Rigidbody2D>().AddForce (Vector2.left * 400);
			zheli .hurt ();

			GetComponent<AudioSource> ().Play ();
		}

		if(d.collider.tag=="bullet")
			//IsPlayer = true;

		{   
			xueliang--;
		}
}


}
