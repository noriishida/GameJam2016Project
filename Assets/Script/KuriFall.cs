using UnityEngine;
using System.Collections;

public class KuriFall : MonoBehaviour {

	public float fallForce;
	private float fallSpeed;
	public float maxSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float nowZ = this.transform.localPosition.z;
		this.transform.localPosition = new Vector3( 0, 0, nowZ - this.fallSpeed );
		this.fallSpeed += this.fallForce;
		if (this.fallSpeed > this.maxSpeed) this.fallSpeed = this.maxSpeed;
	
	}
}
