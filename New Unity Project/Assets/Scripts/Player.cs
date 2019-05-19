using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

 public float speed = 1.3f;
     void Update () {

		 //pos
         Vector3 pos = transform.position;
 
         if (Input.GetKey ("w")) {
             pos.z += speed * Time.deltaTime;
         }
         if (Input.GetKey ("s")) {
             pos.z -= speed * Time.deltaTime;
         }
         if (Input.GetKey ("d")) {
             pos.x += speed * Time.deltaTime;
         }
         if (Input.GetKey ("a")) {
             pos.x -= speed * Time.deltaTime;
         }
             
 
         transform.position = pos;

		//standing
		// if(Math.Abs(transform.eulerAngles.x)>10){
		// 	transform.rotation = new Quaternion(0,0,0,transform.rotation.w);
		// }
		// if(Math.Abs(transform.eulerAngles.y)>10){
		// 	transform.rotation = new Quaternion(0,0,0,transform.rotation.w);
		// }
		// if(Math.Abs(transform.eulerAngles.z)>10){ 
		// 	transform.rotation = new Quaternion(0,0,0,transform.rotation.w);
		// }
		


     }
}
