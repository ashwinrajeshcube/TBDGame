using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCam : MonoBehaviour
{
	[SerializeField] private float degreeStep = 30f;
    [SerializeField] private Transform right;
	[SerializeField]
	KeyCode keyPositive;
	[SerializeField]
	KeyCode keyNegative;
    void Update()
    {
		float step = degreeStep * Time.deltaTime;
		if(Input.GetKey(keyPositive))
        right.Rotate(Vector3.up, step); 
		if(Input.GetKey(keyNegative))
		right.Rotate(Vector3.down, step);
		
    }
}
