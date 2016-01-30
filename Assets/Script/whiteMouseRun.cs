using UnityEngine;
using System.Collections;

public class whiteMouseRun : MonoBehaviour {

	public Vector3 initPosition;
	public float runSpeed;
	public float runPower;

	void Awake() {
		this.initPosition = this.transform.localPosition;

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float addPos = Mathf.Sin( Time.time * this.runSpeed ) * this.runPower;
		this.transform.localPosition = new Vector3( this.initPosition.x, this.initPosition.y+addPos, this.initPosition.z );
	
	}
}
