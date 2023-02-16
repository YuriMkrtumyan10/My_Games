using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {

	public int health;

	void Start () {
		health = 200;
	}


	public void healthm (int mheal) {
		health = health - mheal;

		if (health <= 0) 
		{
			
			Destroy (gameObject);
		}


	}
}
