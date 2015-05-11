using UnityEngine;
using System.Collections;

public class Dispenser_Controller : MonoBehaviour {

	public ParticleSystem gel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("g")) {
			gel.Play();
		}

	}
}
