using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	// Update is called once per frame
	void Update() {}
		
	
		
	void FixedUpdate() { 	
		transform.position += transform.forward;
	}
		
	private void OnCollisionEnter(Collision collideobject) {
		if(collideobject.gameObject.tag == "enemy"){
			print (collideobject.gameObject.name);
			print(gameObject.transform.position);
		}
	}
}
