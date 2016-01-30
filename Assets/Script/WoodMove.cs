using UnityEngine;
using System.Collections;

public class WoodMove : MonoBehaviour {

	private float speed = 3;
	private float timer;

	void Start () {
	
	}
	
	void Update () {
		timer += Time.deltaTime;
		gameObject.transform.position.y -= speed * timer;
	}
}
