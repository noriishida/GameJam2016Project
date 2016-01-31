using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class InstanceObject : MonoBehaviour {

	public GameObject parentWood;
	public GameObject childWood;

	public GameObject Kuri;
	public float startOffset = 128.0F;
	public float threshold = 0.01F;
	public float addThreshold = 0.1F;

	private float timer;
	public GameObject[] enemy;

//	static public int instanceCount;

	System.Random rnd;

	private PlayFlagManager playFlagManager;
	private WoodMove woodMove;
	private float woodSpeed;

	public GameObject ScoreTextObjcet;
	private Text ScoreText;
	public float score;

	void Awake() {
		this.woodMove = this.childWood.GetComponent<WoodMove>();
		this.woodSpeed = this.woodMove.speed;

		this.ScoreText = this.ScoreTextObjcet.GetComponent<Text>();

	}

	void Start () 
	{
		playFlagManager = FindObjectOfType<PlayFlagManager> ();
		rnd = new System.Random();
	}
	
	void Update () 
	{
		timer = Time.time;
	}

	public void InstanceWoods(float y)
	{
		if (timer <= 60) 
		{
			GameObject newEnemy = enemy [rnd.Next (0, 9)];
			var cloneWood = Instantiate (newEnemy, new Vector3 (0, 0, y), newEnemy.transform.rotation) as GameObject;
			cloneWood.transform.parent = parentWood.transform;
		}
		else 
		{
			var goalObj = Instantiate(enemy[10], new Vector3 (0, 0, y), enemy[10].transform.rotation) as GameObject;
			goalObj.transform.parent = parentWood.transform;
		}

	}

	public void OnUpdateScore() {
		this.score += this.woodSpeed * Time.deltaTime * 0.1F;
		this.ScoreText.text = this.score.ToString("0");

		if (!playFlagManager.isGameComplete || !playFlagManager.isGameOver)
		{
			//どんぐり
			if (Random.Range (0, 1.0F) < threshold) {
				GameObject kuri = Instantiate (Kuri);
				kuri.transform.SetParent (this.parentWood.transform, false);
				kuri.transform.localEulerAngles = new Vector3 (0.0F, Random.Range (0, 360), 0.0F);
				kuri.transform.localPosition = new Vector3 (0, this.startOffset, 0);
			}
		}
		else 
		{
			if (Kuri != null)
			{
				Destroy (Kuri);
			}
		}

		this.threshold += this.addThreshold * Time.deltaTime;

	}

	public void Nullmethod()
	{
		
	}
}
