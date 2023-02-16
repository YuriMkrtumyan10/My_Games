using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour 
{
	public Text coinsleft;

	public int cur_coins = 0;
	public int max_coins = 0;
	public int cube_touch = 0;

	public GameObject gamewin;

	void Start () 
	{
		gamewin.SetActive (false);
		max_coins = cur_coins;
		UpdateUI ();
	}
	

	void Update () 
	{
		
	}

	public void UpdateUI () 
	{
		
		if (cur_coins > 0) {
			coinsleft.text = "Coins Left" + cur_coins.ToString ("D3");
		} else if (cur_coins <= 0) {
			
			gamewin.SetActive (true);

		}

	}

}
