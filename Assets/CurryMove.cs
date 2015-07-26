using UnityEngine;
using System.Collections;

public class CurryMove : MonoBehaviour {
	public Vector3 pointB;
	public GameObject Curry;

	// Use this for initialization
	IEnumerator Start () {
		Vector3 pointA = transform.position;
		while (true){
			yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
			yield return StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f));
		}

	
	}
	
	// Update is called once per frame
	IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time) {
		float i= 0.0f;
		float rate= 1.0f/time;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield return null;
		}
	
	}
}
