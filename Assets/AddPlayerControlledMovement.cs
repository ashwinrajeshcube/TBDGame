using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AddPlayerControlledMovement : MonoBehaviour
{
	[SerializeField]
Vector3 v3;
	[SerializeField]
KeyCode keyPositive;
	[SerializeField]
KeyCode keyNegative;

	[SerializeField]
Vector3 v32;
	[SerializeField]
KeyCode keyPositive2;
	[SerializeField]
KeyCode keyNegative2;
void FixedUpdate(){
	if(Input.GetKey(keyPositive)){
	GetComponent<Rigidbody>().velocity+=v3;}
	if(Input.GetKey(keyNegative)){
	GetComponent<Rigidbody>().velocity-=v3;}
	if(Input.GetKey(keyPositive2)){
	GetComponent<Rigidbody>().velocity+=v32;}
	if(Input.GetKey(keyNegative2)){
	GetComponent<Rigidbody>().velocity-=v32;}
}
}

