using UnityEngine;
using System.Collections;

public class PlayerConttroller : MonoBehaviour {

	void Update () {
		if (PlayFlagManager.isPlaying)
		{
			var inputX = Input.GetAxisRaw("Horizontal");
			var inputJump = Input.GetButtonDown("Jump");
			gameObject.transform.Rotate (0, inputX * Time.deltaTime*10, 0);
		}	
	}
}
