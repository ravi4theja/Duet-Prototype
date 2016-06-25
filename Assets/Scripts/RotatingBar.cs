using UnityEngine;
using System.Collections;

public class RotatingBar : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,0,speed * Time.deltaTime);
	}
}
