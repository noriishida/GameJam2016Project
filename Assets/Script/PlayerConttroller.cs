using UnityEngine;
using System.Collections;

public class PlayerConttroller : MonoBehaviour {

	public GameObject mouse;
	private float timer;

	private bool jumpFlug;
	private float originPosY;
	private Rigidbody rb;
	private PlayFlagManager playFlagManager;

	void Start()
	{
		jumpFlug = false;
		originPosY = mouse.transform.position.y;
		rb = mouse.GetComponent<Rigidbody> ();
		playFlagManager = FindObjectOfType<PlayFlagManager> ();
	}

	void Update () {
		if (playFlagManager.isPlaying)
		{
			var inputX = Input.GetAxisRaw("Horizontal");
			var inputJump = Input.GetButton("Jump");
			timer = Time.deltaTime;

			gameObject.transform.Rotate (0 ,inputX * timer *10 ,0 );

			if (inputJump) 
			{
				if(!jumpFlug)
				{
					rb.AddForce (Vector3.up * 100);
					jumpFlug = true;
				}
			}
			if (mouse.transform.position.y <= originPosY)
			{
				jumpFlug = false;
			}
		}	
	}
}


