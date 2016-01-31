﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayFlagManager : MonoBehaviour {

	public bool isPlaying;
	public bool isGameConplete;
	public bool isGameOver;

	private string objName01 = "Text01";
	private string objName02 = "Text02";
	private GameObject textObj01;
	private GameObject textObj02;
	private Text textComponent01;
	private Text textComponent02;
	private MoveScene moveScene;

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
		textComponent01 = textObj01.GetComponent<Text> ();
		textComponent02 = textObj02.GetComponent<Text> ();
		moveScene = FindObjectOfType<MoveScene> ();

		StartCoroutine (CountDown());
    }

	IEnumerator CountDown()
	{
		textComponent01.text = "";
		yield return new WaitForSeconds (1);
		textComponent01.text = "3";
		yield return new WaitForSeconds (1);
		textComponent01.text = "2";
		yield return new WaitForSeconds (1);
		textComponent01.text = "1";
		yield return new WaitForSeconds (1);
		textComponent01.text = "START!";
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
		if(isGameConplete || isGameOver)
		{
			moveScene.ChangeScene ();
		}
	}

	void GameConplete()
	{
		if (isGameConplete)
		{
			textObj01.SetActive (true);
			textObj02.SetActive (true);
			textComponent01.text = "Complete!";
			textComponent02.text = "Please Any Button";
			this.scoreUpdate = this.InstanceManager.GetComponent<InstanceObject>().Nullmethod;
		}
	}

    void GameOver()
    {
        if (isGameOver)
        {
            textObj01.SetActive(true);
            StartCoroutine(GO());
			this.scoreUpdate = this.InstanceManager.GetComponent<InstanceObject>().Nullmethod;
        }
    }

    IEnumerator GO()
    {
        textComponent01.text = "";
        yield return new WaitForSeconds(3);
        textComponent01.text = "GAMEOVER";
        yield return new WaitForSeconds(3);
		textComponent01.text = "Please Space Key";
    }
}
