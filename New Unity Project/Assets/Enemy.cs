using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	private bool isAway = false;
	private Vector3 awayVector;
	private float thrust =0.5f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(isAway){
			this.GetComponent<Rigidbody>().AddForce(awayVector*thrust);
			isAway=false;
		}
		
	}

	void OnCollisionEnter (Collision col) {
			
		if(col.gameObject.tag == "Bullet"){
			Debug.Log("wow");
			GameObject player = col.gameObject.GetComponent<Bullet>().player;
			awayVector = new Vector3(this.transform.position.x-player.transform.position.x,this.transform.position.y-player.transform.position.y,this.transform.position.z-player.transform.position.z).normalized;
				isAway = true;
		}
		
	}
}
