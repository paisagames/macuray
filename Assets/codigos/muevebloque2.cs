using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muevebloque2 : MonoBehaviour {
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
		transform.Translate(0,0.01f,0);
	
		
	}
	void OnTriggerEnter(Collider other){

		random=Random.Range(limizf,limiderf);
			
			
		if(other.tag=="techo"){
			transform.position=new Vector3(random,-7.2f,transform.position.z);
		}
	}
}