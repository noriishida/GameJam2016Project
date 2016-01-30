using UnityEngine;
using System.Collections;

public class MoveScene : MonoBehaviour {

	public string sceneName;

	void Start () {
		
	}
	
	void Update () {
		
	}

	public void ChangeScene()
	{
		var inputA = Input.GetButton ("Fire1");
		var inputB = Input.GetButton ("Fire2");
		var inputC = Input.GetButton ("Fire3");
		var inputD = Input.GetButton ("Jump");
		if (inputA || inputB || inputC || inputD)
		{
			Application.LoadLevel (sceneName);
		}
	}
}
