using UnityEngine;
using System.Collections;

public class Cam : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up * speed * Time.deltaTime);
	}
}
