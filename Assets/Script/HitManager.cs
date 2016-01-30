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

  

    void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "Enemy")
        {

            //ゲームオーバー処理
            Destroy(gameObject);
            //操作フラグの切り替え
            PlayFlagManager.isPlaying = false;
            //UI表示
            PlayFlagManager.isGameOver = true;

            //スタート画面準備
            if (Input.GetKey(KeyCode.Space))
            {
                int levelIndex = Application.loadedLevel;
            }

        }
        
    }
}
