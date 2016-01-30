using UnityEngine;
using System.Collections;

public class PlayerConttroller : MonoBehaviour {

	public GameObject mouse;
	private float timer;

	private bool jumppingFlug;
	private CharacterController characterController;
	private Rigidbody rb;

	void Start()
	{
		rb = mouse.GetComponent<Rigidbody> ();
		characterController = mouse.GetComponent<CharacterController> ();
	}

	void Update () {
		if (PlayFlagManager.isPlaying)
		{
			timer = Time.deltaTime;
			var inputX = Input.GetAxisRaw("Horizontal");
			var inputJump = Input.GetButton("Jump");


			if (inputJump) {
				rb.AddForce (Vector3.up * 30);
			}
		}	
	}
}


