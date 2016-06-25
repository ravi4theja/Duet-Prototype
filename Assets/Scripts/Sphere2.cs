using UnityEngine;
using System.Collections;

public class Sphere2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.CompareTag ("Bar") || collider.gameObject.CompareTag ("Ball") || collider.gameObject.CompareTag ("Rotating Bar") || collider.gameObject.CompareTag ("Anti Rotating Bar") || collider.gameObject.CompareTag ("Moving Bar") || collider.gameObject.CompareTag ("Fading Bar")) {
			Destroy (this.gameObject);
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
