using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayFlagManager : MonoBehaviour {

	static public bool isPlaying;
	static public bool isGameConplete;
    static public bool isGameOver;


	private string objName01 = "Text01";
	private string objName02 = "Text02";
	private GameObject textObj01;
	private GameObject textObj02;
	private Text textComponent;

	public GameObject InstanceManager;
	public delegate void ScoreUpdate();
	public ScoreUpdate scoreUpdate;

	void Start () 
	{
		this.scoreUpdate = () => { };
		isPlaying = false;
		isGameConplete = false;
		isGameOver = false;

		textObj01 = GameObject.Find (objName01);
		textObj02 = GameObject.Find (objName02);
		textObj02.SetActive (false);
		textComponent = textObj01.GetComponent<Text> ();
		StartCoroutine (CountDown());
    }

	IEnumerator CountDown()
	{
		textComponent.text = "";
		yield return new WaitForSeconds (1);
		textComponent.text = "3";
		yield return new WaitForSeconds (1);
		textComponent.text = "2";
		yield return new WaitForSeconds (1);
		textComponent.text = "1";
		yield return new WaitForSeconds (1);
		textComponent.text = "START!";
		this.scoreUpdate = this.InstanceManager.GetComponent<InstanceObject>().OnUpdateScore;		// delegate

		isPlaying = true;
		yield return new WaitForSeconds (1.5f);
		textObj01.SetActive (false);
	}
	
	void Update ()
	{
		if (InstanceObject.instanceCount >= 20)
		{
			isPlaying = false;
			isGameConplete = true;

		}
		GameConplete ();
        GameOver();
		this.scoreUpdate();
	}

	void GameConplete()
	{
		if (isGameConplete)
		{
			textObj01.SetActive (true);
			textObj02.SetActive (true);
			textComponent.text = "Complete!";
		}
	}

    void GameOver()
    {
        if (isGameOver)
        {
            textObj01.SetActive(true);
            StartCoroutine(GO());
        }
    }

    IEnumerator GO()
    {
        textComponent.text = "";
        yield return new WaitForSeconds(3);
        textComponent.text = "GAMEOVER";
        yield return new WaitForSeconds(3);
		textComponent.text = "Please Space Key";
    }
}
