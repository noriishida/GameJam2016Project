﻿using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class InstanceObject : MonoBehaviour {

	public GameObject parentWood;
	public GameObject childWood;

	public GameObject Kuri;
	public float startOffset = 20.0F;
	public float threshold = 0.1F;

	public GameObject[] enemy;

	System.Random rnd;

	private WoodMove woodMove;
	private float woodSpeed;

	public GameObject ScoreTextObjcet;
	private Text ScoreText;
	public float score;

	//１分約２０回カウントされる
	static public int instanceCount = 0;

	void Awake() {
		this.woodMove = this.childWood.GetComponent<WoodMove>();
		this.woodSpeed = this.woodMove.speed;

		this.ScoreText = this.ScoreTextObjcet.GetComponent<Text>();

	}

	void Start () 
	{
		rnd = new System.Random();
	}
	
	void Update () {

	}

	public void InstanceWoods(float y)
	{
		GameObject newEnemy = enemy [rnd.Next (0, 9)];
		var cloneWood = Instantiate(newEnemy, new Vector3(0,0,y), newEnemy.transform.rotation) as GameObject;
		cloneWood.transform.parent = parentWood.transform;
		instanceCount += 1;

	}

	public void OnUpdateScore() {
		this.score += this.woodSpeed * Time.deltaTime * 0.1F;
		this.ScoreText.text = this.score.ToString("0");

		//どんぐり
		if ( Random.Range(0, 1.0F) < threshold ) {
			GameObject kuri = Instantiate( Kuri );
			kuri.transform.localEulerAngles = new Vector3( Random.Range( 0,360 ), 90.0F, 90.0F );
			kuri.transform.localPosition = new Vector3(0, 0, this.startOffset);

		}

	}

	public void Nullmethod()
	{
		
	}
}
