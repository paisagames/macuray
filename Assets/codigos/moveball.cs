using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
		bolaobj.Rotate(0,0,4f);
		}
		if(derb==true){
			transform.Translate(0.1f,0,0);
		bolaobj.Rotate(0,0,-4f);
		}
		if(transform.position.x<-3.6f){
			transform.position=new Vector3(3.6f,transform.position.y,transform.position.z);
		}

		if(transform.position.x>3.6f){
			transform.position=new Vector3(-3.6f,transform.position.y,transform.position.z);
		}
		
	}
	void OnTriggerEnter(Collider other){
		if(other.tag=="loose"){
			SceneManager.LoadScene("gameover");
		

		}
		if(other.tag=="macuray"){
			globalvariables.puntos++;
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
