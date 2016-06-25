using UnityEngine;
using System.Collections;

public class FadingBar : MonoBehaviour {

	// Use this for initialization
	float timer;
	bool b;
	void Start () {
		b = true;
		timer = 0;
		GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		// As soon as the bar comes into the camera view we make it vanish
	
		if (b && (((Time.time - timer) > 20))) {

			GetComponent<Renderer>().enabled = b;
			timer = Time.time;
			b = !b;
		
		}
		else {
			GetComponent<Renderer>().enabled = b; 
			timer = Time.time;
			b = !b;
		}
	}
}
