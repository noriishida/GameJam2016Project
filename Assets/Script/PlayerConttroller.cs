using UnityEngine;
using System.Collections;

public class PlayerConttroller : MonoBehaviour {

	public GameObject mouse;
	private float timer;

	private Vector3 move;
	private const float GRAVITY = 9.8f;

	void Start()
	{
		
	}

	void Update () {
		if (PlayFlagManager.isPlaying)
		{
			timer = Time.deltaTime;
			var inputX = Input.GetAxisRaw("Horizontal");
			var inputJump = Input.GetButton("Jump");
			gameObject.transform.Rotate (0, inputX * timer *10, 0);

			move = new Vector3 (0, 0, mouse.transform.position.z);
			move.z += GRAVITY * Time.deltaTime;
			mouse.transform.position = move;
			if(inputJump)
			{

			}
		}	
	}
}
