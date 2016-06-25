using UnityEngine;
using System.Collections;

public class Raycasting : MonoBehaviour {

	// Use this for initialization
	float distance = 25.0f;
	public float power;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;
			if(Physics.Raycast(rayOrigin, out hitInfo, distance)){
				Debug.Log("ray casted");
				Debug.DrawLine(rayOrigin.direction, hitInfo.point);

				if(hitInfo.rigidbody != null){
					//hitInfo.rigidbody.AddForceAtPosition(rayOrigin.direction * power, hitInfo.point); 
					hitInfo.rigidbody.GetComponent<Renderer>().material.color = new Color(0, 0, 1);
				}
			}

		}
	}
}
