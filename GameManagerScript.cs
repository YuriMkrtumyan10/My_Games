using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour 
{	
	public int cur_coins = 0;
	public int max_coins = 0;
	public int cube_touch = 0;
	public Text coinsleft;

	public Image HPbar;
	public AudioSource music;
	public GameObject gamewin;
	public GameObject gameover;
	public GameObject gameoverimg;
	public GameObject gamewinimg;
	moving HPbarr;
	void Start () 
	{
		
		HPbarr = GameObject.Find ("Cube").GetComponent <moving> ();
		gamewinimg.SetActive (false);
		gameoverimg.SetActive (false);
		gamewin.SetActive (false);
		max_coins = cur_coins;
		UpdateUI ();
	}
	

	void Update () 
	{
		 if (HPbarr.health <= 0) {
			HPbarr.gameover = true;
			gameover.SetActive (true);
			gameoverimg.SetActive (true);
		}
		HPbar.fillAmount = HPbarr.health / 100;
	}

	public void UpdateUI () 
	{
		
		if (cur_coins > 0) {
			coinsleft.text = "Coins Left" + cur_coins.ToString ("D3");
		} 
		else if (cur_coins <= 0) {
			//UnityEditor.EditorApplication.isPlaying = false;
			HPbarr.gamewin = true;
			gamewin.SetActive (true);
			gamewinimg.SetActive (true);


		}


	}




}
