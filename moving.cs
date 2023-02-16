using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {
	GameManagerScript GMS;
	public float Speed;
	public float health = 100f;
	public bool gamewin = false;

	public bool gameover = false;
	// Use this for initialization
	void Start () {

		GMS = GameObject.Find ("GameManager").GetComponent <GameManagerScript> ();
		Speed = 13f;
		GMS.music.Play ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gamewin == true || gameover == true) {
			return;
		}
		transform.Translate (Speed * Input.GetAxis ("Horizontal") * Time.deltaTime, 0f, Speed * Input.GetAxis ("Vertical") * Time.deltaTime);
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "enemy") {
			health -= 10;
			GMS.UpdateUI();
		}
		if (other.gameObject.tag == "medical") {
			health += 10;
			GMS.UpdateUI ();
		}
	}
}
