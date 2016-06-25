using UnityEngine;
using System.Collections;

public class AntiRotatingBar : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, -1 * speed * Time.deltaTime);
	}
}
