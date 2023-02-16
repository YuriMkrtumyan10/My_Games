using UnityEngine;
using System.Collections;
using System;

public class ColorChanger : MonoBehaviour {
	public Color colorIni = Color.blue;
	public Color colorFin = Color.yellow;
	public float duration = 3f;
	Color lerpedColor = Color.blue;

	private float t=0;
	private bool flag; 

	Renderer _renderer;
	// Use this for initialization
	void Start () {
		_renderer=GetComponent<Renderer>(); 
	}

	void Update() {
		lerpedColor = Color.Lerp(colorIni, colorFin,  t);
		_renderer.material.color = lerpedColor;

		if (flag == true) {
			t -= Time.deltaTime/duration;
			if (t < 0.01f)
				flag = false;
		} else {
			t += Time.deltaTime/duration;
			if (t > 0.99f)
				flag = true;
		}
	}
}