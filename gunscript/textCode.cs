using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textCode : MonoBehaviour {

	public Text text1;

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "TextCube"){
			text1.text = "2019-Aliens are invade Earth!!!    Agent Coulson        " +
				"You must press the switch at the lighthouse                                                        Instruction:W-Forward A-Left S-Backwards D-Right R-Recharge Gun E-Flashlight                                      " +
				"" +
				"MouseLeftClick - Fire              " +
				"Space - Jump                 " +
				"Q-Press Switch";
		}
	}

	void OnTriggerExit(Collider other){
		if (other.gameObject.tag == "TextCube") {
			text1.text = "";
		}
	}

}
