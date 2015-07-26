using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIScore : MonoBehaviour {
	Text myText;

	// Use this for initialization
	void Start () {
		myText = GetComponent<Text>();

	
	}

	void Awake () {
	 	if (Application.loadedLevel == 0) {
			Basketball.score = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		myText.text = "Score: " + Basketball.score;
	
	}
}
