using UnityEngine;
using System.Collections;

public class DontDestroy : MonoBehaviour {

	void Start () {
		DontDestroyOnLoad (gameObject);
		Debug.Log ("");
	}
	
	void Update () {
	
	}
}
