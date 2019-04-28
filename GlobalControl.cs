using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour {

	public static GlobalControl Instance;

	//要保存使用的数据;
	public float  Jacklife;
	public float Roselife;
	public int kk;
	public bool Isarm;
	public bool Isskill;
	public bool Isgupiao;
	public int changjing;
	public int gupiao1;
	public int gupiao2;

	//初始化
	private void Awake()
	{

		//Instance = this;
	
		//Instance.Jacklife=1800;
		//Instance.Roselife=1234;
		if(Instance==null)
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
		else if(Instance!=null)
		{
			Destroy(gameObject);
		}

	}


}
