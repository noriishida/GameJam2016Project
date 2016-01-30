using UnityEngine;
using System.Collections;

public class StartCameraRotate : MonoBehaviour {

	public float rotateSpeed;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate(0, this.rotateSpeed*Time.deltaTime, 0);
	
	}
}
