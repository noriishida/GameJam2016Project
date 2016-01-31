using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	public AudioClip[] audio;
	private AudioSource audioSource;


	void Start () {
		audioSource = gameObject.GetComponent<AudioSource> ();
	}
	
	void Update () {
	
	}

	public void PlaySE(int number)
	{
		audioSource.PlayOneShot (audio[number], 0.6f);
	}
}
