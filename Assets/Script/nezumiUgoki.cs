using UnityEngine;
using System.Collections;

public class nezumiUgoki : MonoBehaviour {

	public float furifuriSpeed;
	public float furifuriPower;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float furiAngle = Mathf.Sin( Time.time * this.furifuriSpeed ) * this.furifuriPower;
		this.transform.localEulerAngles = new Vector3( 0, furiAngle, 0 );
	
	}
}
