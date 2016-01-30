using UnityEngine;
using System.Collections;

public class PlayFlagManager : MonoBehaviour {

	static public bool isPlaying = false;

	void Start () 
	{
		StartCoroutine (CountDown());
	}

	IEnumerator CountDown()
	{
		yield return new WaitForSeconds (1);
		Debug.Log (3);
		yield return new WaitForSeconds (1);
		Debug.Log (2);
		yield return new WaitForSeconds (1);
		Debug.Log (1);
		yield return new WaitForSeconds (1);
		Debug.Log (0);
		isPlaying = true;
	}
	
	void Update ()
	{
	
	}
}
