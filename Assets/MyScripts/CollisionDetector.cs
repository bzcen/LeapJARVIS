using UnityEngine;
using System.Collections;

public class CollisionDetector : MonoBehaviour {
	public float colourChangeDelay = 0.5f;
	float currentDelay = 0f;
	bool colourChangeCollision = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		checkColourChange();
	
	}
//	void OnCollisionEnter(Collision other){
	void OnTriggerEnter(Collider other) {
		Debug.Log ("Collided");
		if (other.gameObject.tag == "index") {
			Debug.Log ("index");
		}
		colourChangeCollision = true;
		currentDelay = Time.time + colourChangeDelay;

	}

	void checkColourChange()
	{        
		if(colourChangeCollision)
		{
			transform.GetComponent<Renderer>().material.color = Color.yellow;
			if(Time.time > currentDelay)
			{
				transform.GetComponent<Renderer>().material.color = Color.white;
				colourChangeCollision = false;
			}
		}
	}
}
