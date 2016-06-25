using UnityEngine;
using System.Collections;

public class MovingBar : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((speed > 0 && transform.position.x > 1.5f) || (speed < 0 && transform.position.x < -1.5f)) {
			speed = speed * -1;
		}
		transform.position = new Vector3 (transform.position.x + speed * Time.deltaTime, transform.position.y);
	}
}
