using UnityEngine;
using System.Collections;

public class PlayerConttroller : MonoBehaviour {

	public GameObject mouse;
	private float timer;

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
			var inputJumpUp = Input.GetButtonDown("Jump");
			var inputJumpDown = Input.GetButtonUp("Jump");
			gameObject.transform.Rotate (0, inputX * timer *10, 0);
			if (inputJumpUp) {
				anim.SetBool ("Jump", true);
			}
			if (inputJumpDown) {
				anim.SetBool ("Jump", false);
			}
		}	
	}
}
