using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muevebloque2 : MonoBehaviour {
public Transform limizq;
	public Transform limder;
	float limizf;
	float limiderf;
	float random;
	float randomy;
	// Use this for initialization
	void Start () {
		limizf=limizq.position.x;
		limiderf=limder.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,globalvariables.velocidad,0);
	if(transform.position.y<-26f)
		{transform.position=new Vector3(transform.position.x,-23f,transform.position.z);}
		
	}
	void OnTriggerEnter(Collider other){

		random=Random.Range(limizf,limiderf);
		randomy=Random.Range(-20f,-25f);
			
			
		if(other.tag=="techo"){
			transform.position=new Vector3(random,randomy,transform.position.z);
		}
	}
}