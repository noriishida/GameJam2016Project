using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayFlagManager : MonoBehaviour {

	public bool isPlaying;
	public bool isGameComplete;
	public bool isGameOver;

	private string objName01 = "Text01";
	private string objName02 = "Text02";
	private GameObject textObj01;
	private GameObject textObj02;
	private Text textComponent01;
	private Text textComponent02;
	private SoundManager soundManager;
	private MoveScene moveScene;
	private StartCameraEvent startCameraEvent;

	public GameObject InstanceManager;
	public delegate void ScoreUpdate();
	public ScoreUpdate scoreUpdate;


	void Start () 
	{
		this.scoreUpdate = () => { };
		isPlaying = false;
		isGameComplete = false;
		isGameOver = false;

		textObj01 = GameObject.Find (objName01);
		textObj02 = GameObject.Find (objName02);
		textComponent01 = textObj01.GetComponent<Text> ();
		textComponent02 = textObj02.GetComponent<Text> ();
		moveScene = FindObjectOfType<MoveScene> ();
		startCameraEvent = FindObjectOfType<StartCameraEvent> ();

		StartCoroutine (CountDown());
    }

	IEnumerator CountDown()
	{
		textComponent01.text = "";
		startCameraEvent.second_Three ();
		yield return new WaitForSeconds (1);
		textComponent01.text = "3";
		yield return new WaitForSeconds (1);
		startCameraEvent.second_Two ();
		textComponent01.text = "2";
		yield return new WaitForSeconds (1);
		startCameraEvent.second_One ();
		textComponent01.text = "1";
		yield return new WaitForSeconds (1);
		startCameraEvent.second_Zero ();
		textComponent01.text = "START!";
		this.scoreUpdate = this.InstanceManager.GetComponent<InstanceObject>().OnUpdateScore;		// delegate

		isPlaying = true;
		yield return new WaitForSeconds (1.5f);
		textObj01.SetActive (false);
	}
	
	void Update ()
	{
		GameComplete ();
        GameOver();
		this.scoreUpdate();
		if(isGameComplete || isGameOver)
		{
			moveScene.ChangeScene ();
		}
	}

	void GameComplete()
	{
		if (isGameComplete)
		{
			textObj01.SetActive (true);
			textObj02.SetActive (true);
			textComponent01.text = "Complete!";
			textComponent02.text = "Please Any Button";
			soundManager.PlaySE (4);
			this.scoreUpdate = this.InstanceManager.GetComponent<InstanceObject>().Nullmethod;
		}
	}

    void GameOver()
    {
        if (isGameOver)
        {
            textObj01.SetActive(true);
            textObj02.SetActive(true);
            textComponent01.text = "Miss!";
            textComponent02.text = "Please Any Button";
            this.scoreUpdate = this.InstanceManager.GetComponent<InstanceObject>().Nullmethod;
        }
    }
}
