using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winbutton : MonoBehaviour {


	void OnTriggerStay(Collider other){

		if (Input.GetKey (KeyCode.Q)) 
		{
			
			SceneManager.LoadScene("gameWin");
		}
	}
		
}
