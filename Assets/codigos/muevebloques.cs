using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class muevebloques : MonoBehaviour {
public Text puntosText;
public Transform limizq;
	public Transform limder;
	float limizf;
	float limiderf;
	float random;
	float randomy;
	// Use this for initialization
	void Start () {
		globalvariables.velocidad=0.02f;
		limizf=limizq.position.x;
		limiderf=limder.position.x;
		globalvariables.puntos=0;
	}
	
	// Update is called once per frame
	void Update () {

		if(globalvariables.velocidad>0.03f){globalvariables.velocidad=0.012f;}

		transform.Translate(0,globalvariables.velocidad,0);
	
		if(transform.position.y<-26f)
		{transform.position=new Vector3(transform.position.x,-23f,transform.position.z);}
	}
	void OnTriggerEnter(Collider other){

		random=Random.Range(limizf,limiderf);
			randomy=Random.Range(-20f,-25f);
			
		if(other.tag=="techo"){
			transform.position=new Vector3(random,randomy,transform.position.z);
		
			globalvariables.velocidad+=0.001f;
			puntosText.text=""+globalvariables.puntos+"vel:"+globalvariables.velocidad;
		}
	}
}
