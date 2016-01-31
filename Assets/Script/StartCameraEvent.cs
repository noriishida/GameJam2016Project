using UnityEngine;
using System.Collections;

public class StartCameraEvent : MonoBehaviour {

	public GameObject mouse;
	public GameObject mouseCamera;
	public GameObject EventCamera;
	public Transform pos1;
	public Transform pos2;
	public Transform pos3;

	void Start () 
	{
		mouseCamera.SetActive (false);	
	}
	
	void Update () 
	{
		EventCamera.transform.LookAt (mouse.transform.position);
	}

	public void second_Three()
	{
		EventCamera.transform.position = pos3.transform.position;
	}

	public void second_Two()
	{
		EventCamera.transform.position = pos2.transform.position;
	}

	public void second_One()
	{
		EventCamera.transform.position = pos1.transform.position;
	}

	public void second_Zero()
	{
		EventCamera.SetActive (false);
		mouseCamera.SetActive (true);
	}
}
