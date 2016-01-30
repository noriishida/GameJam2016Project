using UnityEngine;
using System.Collections;

public class InstanceObject : MonoBehaviour {

	public GameObject parentWood;
	public GameObject childWood;

	//１分約２０回カウントされる
	static public int instanceCount = 0;

	void Start () 
	{
		
	}
	
	void Update () 
	{

	}

	public void InstanceWoods(float y)
	{
		var cloneWood = Instantiate(childWood, new Vector3(0,y,0), Quaternion.identity) as GameObject;
		cloneWood.transform.parent = parentWood.transform;
		instanceCount += 1;
	}
}
