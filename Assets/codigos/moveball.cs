using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveball : MonoBehaviour {
	bool izqb;
	bool derb;
	public Transform bolaobj;

	// Use this for initialization
	void Start () {
		izqb=false;
		derb=false;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(izqb==true){
				transform.Translate(-0.1f,0,0);
		bolaobj.Rotate(0,0,2f);
		}
		if(derb==true){
			transform.Translate(0.1f,0,0);
		bolaobj.Rotate(0,0,-2f);
		}
		if(transform.position.x<-3.6f){
			transform.position=new Vector3(3.6f,transform.position.y,transform.position.z);
		}

		if(transform.position.x>3.6f){
			transform.position=new Vector3(-3.6f,transform.position.y,transform.position.z);
		}
		
	}
	public void left(){
	izqb=true;
		
	}
	public void right(){
		derb=true;
		
	}
	public void leftNO(){
		izqb=false;
	}
	public void rightNO(){
		derb=false;
	}
}
