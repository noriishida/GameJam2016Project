using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class InstanceObject : MonoBehaviour {

	public GameObject parentWood;
	public GameObject childWood;

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
		
	}
	
	void Update () {

	}

	public void InstanceWoods(float y)
	{
		var cloneWood = Instantiate(childWood, new Vector3(0,0,y), childWood.transform.rotation) as GameObject;
		cloneWood.transform.parent = parentWood.transform;
		instanceCount += 1;

	}

	public void OnUpdateScore() {
		this.score += this.woodSpeed * Time.deltaTime * 0.1F;
		this.ScoreText.text = this.score.ToString("0");

	}

	public void Nullmethod()
	{
		
	}
}
