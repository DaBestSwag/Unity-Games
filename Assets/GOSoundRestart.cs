using UnityEngine;
using System.Collections;

public class GOSoundRestart : MonoBehaviour {

	public AudioClip EndSound;
	public AudioSource MyAudioSource;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.R)){
			Application.LoadLevel(0);
		}
	
	}
	void PlaySound(){
		MyAudioSource.PlayOneShot(EndSound);
	}
}

