using UnityEngine;
using System.Collections;

public class Controller_Get_gel : MonoBehaviour {
	
	private Animation anim;
	private GameObject player;
	public ParticleSystem gel;
	private bool close = true;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		anim = gameObject.GetComponent ("Animation") as Animation;
		print (""+this.tag);
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gel.isStopped) {
		}
	}
	

	void OnTriggerStay(Collider other)
	{
		print (other.tag);
		if (other.gameObject == player && !gel.isPlaying) {
			anim.Blend ("Push_Gel");
			gel.Play ();

		} 
		
	}
	
	void OnTriggerExit(Collider other)
	{
		 
	}
	
}