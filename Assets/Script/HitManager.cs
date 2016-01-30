using UnityEngine;
using System.Collections;

public class HitManager : MonoBehaviour {

	void Start () 
	{
	
	}
	
	void Update () 
	{
	
	}

	public void hoge(){
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Enemy")
		{
			//ゲームオーバー処理

			//操作フラグの切り替え

			//UI表示

			//スタート画面準備
		}
	}
}
