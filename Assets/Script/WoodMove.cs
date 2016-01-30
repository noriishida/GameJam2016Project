using UnityEngine;
using System.Collections;

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
		instancePosY = wood03.position.y;
		instanceObject = FindObjectOfType<InstanceObject>();
	}
	
	void Update () 
	{
		if (PlayFlagManager.isPlaying)
		{
			timer = Time.deltaTime;
			gameObject.transform.localPosition -= new Vector3 (0, speed * timer, 0);
			if (gameObject.transform.position.y <= destroyPos.position.y)
			{
				Destroy (gameObject);
				instanceObject.InstanceWoods(instancePosY);
			}
		}
	}
}
