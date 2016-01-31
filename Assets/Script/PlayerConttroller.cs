using UnityEngine;
using System.Collections;

public class PlayerConttroller : MonoBehaviour {

	public GameObject mouse;
	public GameObject jumpEffect;

	private float timer;

	public float jumpPower = 100;
	private bool isJumping;
	private float jumpTime;

	private float originPosY;
	private Rigidbody rb;
	private PlayFlagManager playFlagManager;
	private SoundManager soundManager;

	void Start()
	{
		isJumping = false;
		originPosY = mouse.transform.position.y;
		rb = mouse.GetComponent<Rigidbody> ();
		playFlagManager = FindObjectOfType<PlayFlagManager> ();
		soundManager = FindObjectOfType<SoundManager> ();
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
				if(!isJumping && Time.time - this.jumpTime > 0.5F )
				{
					isJumping = true;
					this.jumpTime = Time.time;
					rb.AddForce (Vector3.up * this.jumpPower);
					GameObject eff = Instantiate(jumpEffect);
					eff.transform.localPosition = new Vector3( 0, 9.23F, -3.79F );
					eff.transform.localEulerAngles = new Vector3( 180.0F, 0, 0 );
					//soundManager.PlaySE (3);
				}
			}

			if (mouse.transform.position.y >= originPosY)
			{
				isJumping = true;

			} else {
				isJumping = false;

			}
		}	
	}
}


