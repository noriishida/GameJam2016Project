using UnityEngine;
using System.Collections;

public class EffectDestroy : MonoBehaviour {

	public float remainTime;
	private float initTime;

	// Use this for initialization
	void Start () {
		this.initTime = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Time.time > this.initTime + this.remainTime ) {
			Destroy(this.gameObject);

		}
	
	}
}
