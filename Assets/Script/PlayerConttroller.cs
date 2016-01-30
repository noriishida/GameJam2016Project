using UnityEngine;
using System.Collections;

public class PlayerConttroller : MonoBehaviour {

	public GameObject mouse;
	private float timer;

	private const float GRAVITY = 0.98f;
	private Vector3 mouseMove;

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

			if (inputJump)
			{
				mouseMove = new Vector3 (0, 0, mouse.transform.position.z);

				mouseMove.z -= GRAVITY;
				mouse.transform.position = mouseMove;
			}
		}	
	}
}
