using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayFlagManager : MonoBehaviour {

	static public bool isPlaying = false;
	static public bool isGameConplete = false;

	private string objName = "Text01";
	public Text textComponent;

	void Start () 
	{
		textComponent = GameObject.Find (objName).GetComponent<Text> ();
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
		isPlaying = true;
		yield return new WaitForSeconds (1.5f);
		var textobj = GameObject.Find (objName) as GameObject;
		textobj.SetActive (false);
	}
	
	void Update ()
	{
		if (InstanceObject.instanceCount <= 20)
		{
			isPlaying = false;
			isGameConplete = true;

		}
		GameConplete ();
	}

	void GameConplete()
	{
		if (isGameConplete)
		{
			var textobj = GameObject.Find (objName) as GameObject;
			textobj.SetActive (true);
			textComponent.text = "Complete!";
		}
	}
}
