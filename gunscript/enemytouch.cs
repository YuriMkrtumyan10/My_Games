using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemytouch : MonoBehaviour {

	GameManagerScript GMS;
	public int player_health = 100;






	void Awake ()
	{
		GMS = GameObject.Find ("GameManager").GetComponent <GameManagerScript> ();
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{

			GameObject.Find("FPSController").GetComponent<Shoot>().player_health -= 20;
			Debug.Log (GameObject.Find ("FPSController").GetComponent<Shoot> ().player_health);

			if (GameObject.Find("FPSController").GetComponent<Shoot>().player_health <= 0) {
				GameObject.Find ("FPSController").GetComponent<CharacterController>().enabled = false;
				GameObject.Find ("FPSController").GetComponent<Shoot> ().enabled = false;

				SceneManager.LoadScene("gameOver");


			}
			GMS.UpdateUI ();
		}

	}
}
