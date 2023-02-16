using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubetouch : MonoBehaviour {

	GameManagerScript GMS;
	public  float health = 100;
	public GameObject gameover;
	moving HPbarr;

	void Awake ()
	{
		GMS = GameObject.Find ("GameManager").GetComponent <GameManagerScript> ();
		HPbarr = GameObject.Find ("Cube").GetComponent<moving> ();
	}

	void Start () {
		
		gameover.SetActive (false);
	}

	void Update () {

	}



	void OnTriggerEnter(Collider other)
	{
		
		if(health <= 0){
			HPbarr.gameover=true;
			gameover.SetActive (true);

		}

	}

}
