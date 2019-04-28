using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class dao : MonoBehaviour {
	    //public static dao Instance1;
	    public float timer;
	    public GameObject t;
	    public waternumeber  yao;
	    private int kk;
	    public GameObject pricenow;
	    public GameObject stockfa;
	    public GameObject ttt;

	//public GameObject pe;
	   

	public GameObject pricenow2;
	public GameObject stockfa2;
	public GameObject ttt2;

	public GameObject over;

	//private bool isInvincible=false;
	//private float timeSpentInvincible;
	//private Renderer renderer;

	    // Use this for initialization
	    void Start()
	    {

		timer=GlobalControl.Instance.Jacklife;
		stockfa.GetComponent<Text> ().text = GlobalControl.Instance.gupiao1.ToString("00");
		stockfa2.GetComponent<Text> ().text = GlobalControl.Instance.gupiao2.ToString("00");
		kk = yao.pp;
		if (timer == 0) {
			timer = 1799;
		}
			
	
		    }
	    // Update is called once per frame
	    void Update()
	    {
		kk = yao.pp;
		      if(timer > 0)
			        {
			            timer -= Time.deltaTime;
			            t.GetComponent<Text>().text = timer.ToString("00");
			        }
		       else GameOver();

	/*	if (isInvincible)
		{
			//2
			timeSpentInvincible += Time.deltaTime;

			//3
			if (timeSpentInvincible < 3f) {
				float remainder = timeSpentInvincible % 0.3f;
				renderer.enabled = remainder > 0.15f; 
			}
			//4
			else {
				renderer.enabled = true;
				isInvincible = false;
			}
		}*/
		  
		    }
	    void GameOver()
	    {
		        t.GetComponent<Text>().text = "Gameover";
		        over.SetActive (true);
		    }

	public void addlife(){

		if (kk > 0) {
			timer += 1000;
			//kk--;
			//yao.text = kk.ToString ("0");
			yao.watershao();
		}
	}

	public void selljiaoyi(){
		
		int sssds = int.Parse(ttt.GetComponent<Text> ().text);
		int wa = int.Parse(stockfa.GetComponent<Text> ().text);
		int pp=int.Parse(pricenow.GetComponent<Text> ().text);
		if (wa>=sssds&&timer > 0) {

			timer += pp * sssds;
			wa = wa - sssds;
			stockfa.GetComponent<Text> ().text = wa.ToString ("00");
			GlobalControl.Instance.gupiao1 = wa;
			//yao.watershao ();
			
		}
	}

	public void buyjiaoyi(){

		int sssds = int.Parse(ttt.GetComponent<Text> ().text);
		print(sssds.ToString("00"));
		int wa = int.Parse(stockfa.GetComponent<Text> ().text);
		int pp=int.Parse(pricenow.GetComponent<Text> ().text);
		if (timer > sssds*pp) {

			timer =timer- pp * sssds;
			wa = wa + sssds;
			stockfa.GetComponent<Text> ().text = wa.ToString ("00");
			GlobalControl.Instance.gupiao1 = wa;

		}
	}

	public void selljiaoyi2(){

		int sssds = int.Parse(ttt2.GetComponent<Text> ().text);
		int wa = int.Parse(stockfa2.GetComponent<Text> ().text);
		int pp=int.Parse(pricenow2.GetComponent<Text> ().text);
		if (wa>=sssds&&timer > 0) {

			timer += pp * sssds;
			wa = wa - sssds;
			stockfa2.GetComponent<Text> ().text = wa.ToString ("00");
			GlobalControl.Instance.gupiao2 = wa;

			//yao.watershao ();

		}
	}

	public void buyjiaoyi2(){

		int sssds = int.Parse(ttt2.GetComponent<Text> ().text);
		print(sssds.ToString("00"));
		int wa = int.Parse(stockfa2.GetComponent<Text> ().text);
		int pp=int.Parse(pricenow2.GetComponent<Text> ().text);
		if (timer > sssds*pp) {

			timer =timer- pp * sssds;
			wa = wa + sssds;
			stockfa2.GetComponent<Text> ().text = wa.ToString ("00");
			GlobalControl.Instance.gupiao2 = wa;
			//yao.watershao ();

		}
	}

	public void SaveJackData(){
		GlobalControl.Instance.Jacklife = timer;
		//GlobalControl.Instance.kk = kk;
	}

	public void hurt(){

		//renderer = pe.GetComponent<Renderer> ();
		//isInvincible = true;
		timer -= 500;

		print ("ok");

	}

	public void maishou(){
		timer -= 800;
	}

	public void maitiao(){
		timer -= 1000;
	}
}
