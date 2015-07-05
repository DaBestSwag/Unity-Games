using UnityEngine;
using System.Collections;

public class PickUpBall : MonoBehaviour {

	Transform myTransform;
	public Transform handTransform;
	public bool isHolding;
	public Transform ball;
	public Rigidbody ballBody;



	// Use this for initialization
	void Start () {

		myTransform = transform;
		isHolding = false;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 handPos = handTransform.position;
		if(!isHolding && Input.GetKeyDown (KeyCode.Alpha1)) {
			isHolding = true;
		
		}

		if (isHolding) {
			ball.transform.position = handPos;
			ballBody.useGravity = false;
			ballBody.mass = 0;
			ballBody.isKinematic = true;

			if(Input.GetKeyDown(KeyCode.Alpha2)) {
				isHolding = false;
			}


		}
		if(!isHolding){
			ballBody.mass = 1;
			ballBody.isKinematic = false;
			ballBody.useGravity = true;

		}

	}
}
