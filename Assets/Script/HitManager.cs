using UnityEngine;
using System.Collections;

public class HitManager : MonoBehaviour {

	private PlayFlagManager playFlagManager;
	private SoundManager soundManager;

	void Start () 
	{
		playFlagManager = FindObjectOfType<PlayFlagManager> ();
		soundManager = FindObjectOfType<SoundManager> ();
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
			soundManager.PlaySE (2);
            //ゲームオーバー処理
            Destroy(gameObject);
            //操作フラグの切り替え
            playFlagManager.isPlaying = false;
            //UI表示
            playFlagManager.isGameOver = true;
			soundManager.PlaySE (1);
            //スタート画面準備
			if (Input.GetButton("Jump"))
            {
                int levelIndex = Application.loadedLevel;
            }

        }
        
    }
}
