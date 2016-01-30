using UnityEngine;
using System.Collections;

public class PlayerConttroller : MonoBehaviour {

	public GameObject mouse;
	private float timer;

	private const float GRAVITY = 0.98f;
	private float posZ;
	private Vector3 mouseMove;

	void Start()
	{
		posZ = mouse.transform.position.z;
	}

	void Update () {
		if (PlayFlagManager.isPlaying)
		{
			timer = Time.deltaTime;
			var inputX = Input.GetAxisRaw("Horizontal");
			var inputJump = Input.GetButton("Jump");
			gameObject.transform.Rotate (inputX * timer *10 ,0 , 0);


		}	
	}
}
