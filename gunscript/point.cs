using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour 
{
	private float rotateSpeed = 1.5f;


	void Update () {
		transform.Rotate (Vector3.left * rotateSpeed);
	}

}
