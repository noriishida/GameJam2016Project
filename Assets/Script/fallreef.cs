using UnityEngine;
using System.Collections;

public class fallreef : MonoBehaviour {
    //public GameObject mTarget;
    private float speed;
    private float radius;
    private float yPossition;
    float x;
    float y;
    float z;

    // Use this for initialization
    void Start () {
        speed = 1.0f;
        radius = 10f;
        yPossition = 18f;
	}
	
	// Update is called once per frame
	void Update () {
       // if(null != mTarget){
            x = radius * Mathf.Sin(Time.time * speed);
            y = yPossition - Time.time;
            z = radius * Mathf.Cos(Time.time * speed);
            transform.position = new Vector3(x, y, z);
        //}
	
	}
}
