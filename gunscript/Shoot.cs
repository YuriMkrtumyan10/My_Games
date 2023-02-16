using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour {

	public int damage;
	public int range;
	public int patron;

	public Camera cam;
	public GameObject Light;

	public int player_health = 100;

	void Start () {

		damage = 100;
		range = 20;
		patron = 10;
	
	}


	void Update () 
	{
		Light.SetActive (false);

		if (Input.GetButtonDown ("Fire1"))
		{
			patron = patron - 1;
			shoot ();

		}
		if (patron <= 0) 
		{
			damage = 0;
		}
		if (Input.GetKey (KeyCode.R)) 
		{
			GameObject.Find ("reload2").GetComponent<AudioSource> ().Play ();
			patron = 10;
			damage = 100;
		}
		if (Input.GetKey (KeyCode.E)) 
		{
			Light.SetActive (true);
		}
	}

	void shoot ()
	{


		if (patron > 0) {
			GameObject.Find ("fireSound").GetComponent<AudioSource> ().Play ();
		}
		if (patron <= 0) {
			GameObject.Find ("reload").GetComponent<AudioSource> ().Play ();
		}

		RaycastHit hit;

		if (Physics.Raycast (cam.transform.position, cam.transform.forward, out hit, range)) {

			if (hit.collider.gameObject.GetComponent<target> ()) 
			{
				
				hit.collider.gameObject.GetComponent<target> ().healthm(damage);
			}
		}
	}






	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			
			Debug.Log(player_health -= 20);

			if (player_health == 0) {
				
		Debug.Log (000000000000000);
			}
		
		}

	}
}




	