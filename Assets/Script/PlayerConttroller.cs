using UnityEngine;
using System.Collections;

public class PlayerConttroller : MonoBehaviour {

	public GameObject mouse;
	private float timer;

	private float jumpPower = -4.0f;
	private float ;

	private Animator anim;

	void Start()
	{
		anim = mouse.GetComponent<Animator> ();
	}

	void Update () {
		if (PlayFlagManager.isPlaying)
		{
			timer = Time.deltaTime;
			var inputX = Input.GetAxisRaw("Horizontal");
			var inputJump = Input.GetButton("Jump");
			gameObject.transform.Rotate (0, inputX * timer *10, 0);

			if(inputJump)
			{
				float posZ = mouse.transform.position.z;
				mouse.transform.position.z += jumpPower * timer;
				if(mouse.transform.position.z > posZ + jumpPower)
				{
					mouse.transform.position.z += jumpPower * timer;
				}
			}
		}	
	}
}
