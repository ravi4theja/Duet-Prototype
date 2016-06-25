using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	// Use this for initialization
	public float speed, upSpeed;
	GameObject player;
	void Start () {
		player = GameObject.Find ("Main Camera");
	}
	
	// Update is called once per frame
	void Update () {
		//Move to and fro
		if ((speed > 0 && transform.position.x > 3.0f) || (speed < 0 && transform.position.x < -3.0f)) {
			speed = speed * -1;
		}
		transform.Translate(Vector3.right * speed * Time.deltaTime);


	}
}
