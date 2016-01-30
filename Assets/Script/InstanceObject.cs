using UnityEngine;
using System.Collections;

public class InstanceObject : MonoBehaviour {

	public GameObject parentWood;
	public GameObject childWood;

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
	}
}
