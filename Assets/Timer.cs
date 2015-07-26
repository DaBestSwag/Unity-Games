using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer: MonoBehaviour {


	float timePlayed;
	public Text myText;

	// Use this for initialization
	void Awake () {
		timePlayed = 0;
	
	}

	void start (){
	}
	
	// Update is called once per frame
	void Update () {
		myText.text = "Timer: " + timePlayed;
		if (timePlayed < 15){
			timePlayed += Time.deltaTime;

		}else{
			Application.LoadLevel("Game Over");
		}
	
	}
}
