using UnityEngine;
using System.Collections;

public class KuriFall : MonoBehaviour {

	public float fallForce;
	private float fallSpeed;
	public float maxSpeed;

	public float addMaxSpeed = 0.1F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float nowZ = this.transform.localPosition.y;
		this.transform.localPosition = new Vector3( 0, nowZ - this.fallSpeed, 0.0F );
		this.fallSpeed += this.fallForce;
		if (this.fallSpeed > this.maxSpeed) this.fallSpeed = this.maxSpeed;

		this.maxSpeed += addMaxSpeed * Time.deltaTime;
	
	}
}
