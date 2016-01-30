
using UnityEngine;
using System.Collections;

using System;

public class WoodMove : MonoBehaviour 
{
	public float speed;
	private float timer;
	public Transform wood03;
	private float instancePosY;
	public Transform destroyPos;

	private InstanceObject instanceObject;

	void Start () 
	{
		instancePosY = wood03.localPosition.y;
		instanceObject = FindObjectOfType<InstanceObject>();
	}
	
	void Update () 
	{
		if (PlayFlagManager.isPlaying)
		{
			timer = Time.deltaTime;
			gameObject.transform.localPosition -= new Vector3 (0, speed * timer, 0);
			if (gameObject.transform.position.z <= destroyPos.position.z)
			{
				Destroy (gameObject);
				instanceObject.InstanceWoods(instancePosY);
			}
		}
	}

}
