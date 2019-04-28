using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {


	public float force_move = 50;
	private Animator ani;
	private bool Isground;
	public float jumpvelocity = 20;
	private Rigidbody2D rb;
	public GameObject showbaozhi;
	private bool maileqiang=false;
	public AudioClip jump;
	public AudioClip attack;
	public GameObject bcard;
	private GameObject card;
	//public Sprite j;

	// Use this for initialization
	void Start () {

		ani = GetComponent<Animator> ();
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		//print (Isground);
		if (Isground&&h > 0.05f) {

			GetComponent<Rigidbody2D>().AddForce (Vector2.right *force_move);
			GetComponent<SpriteRenderer>().flipX=false;
		}
		if(Isground&&h<-0.05f)
		{
			GetComponent<Rigidbody2D>().AddForce (Vector2.left * force_move);
			//transform.localScale = new Vector2 (-1, 0);
			GetComponent<SpriteRenderer>().flipX=true;
		}

		Vector2 ve = GetComponent<Rigidbody2D> ().velocity;

		ani.SetFloat ("horizontal", Mathf.Abs (ve.x));
		ani.SetFloat ("Ver", Mathf.Abs (ve.y));

		if (Isground&&Input.GetKeyDown("space"))
		{
			float vx = rb.velocity.x;
			rb.velocity = new Vector2 (vx, jumpvelocity);
			//GetComponent<Rigidbody2D>().AddForce (Vector2.up * jumpvelocity);
			print ("1");
			//rb.AddForce (Vector2.up*jumpvelocity);
			//ani.SetBool ("jumpup",true);
			GetComponent<AudioSource>().clip=jump;
			GetComponent<AudioSource> ().Play();
		}

		if (maileqiang && Input.GetKeyDown ("c")) {

			ani.SetBool ("kaiqiang", true);
			GetComponent<AudioSource>().clip=attack;
			GetComponent<AudioSource> ().Play();

			card = Instantiate (bcard,(this.transform.position+new Vector3(2,0,0)),this.transform.rotation);
		}
		if (Input.GetKeyUp ("c")) {

			ani.SetBool ("kaiqiang", false);
		}


	}

	public void OnCollisionEnter2D(Collision2D d){

		if(d.collider.tag=="floor")
		Isground = true;

	}

	public void OnCollisionExit2D(Collision2D d){

		if(d.collider.tag=="floor")
		Isground = false;
	}
	public void OnCollisionStay2D(Collision2D d){

		if(d.collider.tag=="floor")
		Isground = true;
	}

	public void OnTriggerEnter2D(){


		showbaozhi.SetActive (true);
	}
	public void OnTriggerExit2D(){


		showbaozhi.SetActive (false);
	}

	public void maishouqiang(){

		//GetComponent<SpriteRenderer> ().sprite = j;
		maileqiang=true;

	}

	public void maitiaotiao(){

		force_move = 50;
		jumpvelocity = 35;
	}
}
