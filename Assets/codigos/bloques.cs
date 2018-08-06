using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloques : MonoBehaviour {
	public Transform limizq;
	public Transform limder;
	float limizf;
	float limiderf;
	float random;
	// Use this for initialization
	void Start () {
		limizf=limizq.position.x;
		limiderf=limder.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OntTriggerEnter(Collider other){
		 	random=Random.Range(limizf,limiderf);
			if(other.tag=="tabla"){
			other.transform.position=new Vector3(1111f,-300f,other.transform.position.z);
			}
	}
}
