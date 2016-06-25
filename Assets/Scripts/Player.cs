using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	public float speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Rotate the Player using the keyboard
		transform.Rotate (0,0,Input.GetAxis("Horizontal")*speed*Time.deltaTime,Space.Self);
		if(transform.position.y > 60){
			Application.LoadLevel(Application.loadedLevel); 
		}

	}
	// collision detection


}
