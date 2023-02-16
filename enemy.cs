using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	
	public float z;
	moving MC;

	// Use this for initialization
	void Start () {
		z = 0.3f;
		MC = GameObject.Find ("Cube").GetComponent <moving> ();
	}

	// Update is called once per frame
	void Update () {
		if(MC.gamewin == true || MC.gameover == true)
		{
			return;
		}
		gameObject.transform.Translate (z, 0, 0);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "wall2") 
		{
			z = -0.3f;
		}
		else if(other.gameObject.tag == "wall"){
			z = 0.3f;
		}

	}

}
