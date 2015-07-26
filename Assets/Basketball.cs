using UnityEngine;
using System.Collections;


public class Basketball : MonoBehaviour {

	public AudioClip boink;
	public AudioSource myAudio;
	public static int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	

	void OnTriggerEnter(Collider collider){
		float bBallVolume = GetComponent<Rigidbody>().velocity.magnitude /40;
		//Debug.Log ("bBallVolume: " + bBallVolume);
		myAudio.PlayOneShot(boink,bBallVolume);
		if(collider.gameObject.tag == "Head"){
			score++;
			Debug.Log ("score:" + score);
		} //else if (collider.gameObject.tag == "Curry"){
//			Debug.Log ("Ha U Missed");
//		}

		//score++;
		


	}
	void OnCollisionEnter(Collision Collider){
		float bBallVolume = GetComponent<Rigidbody>().velocity.magnitude /40;
		myAudio.PlayOneShot(boink,bBallVolume);
	}

}
