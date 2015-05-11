using UnityEngine;
using System.Collections;

public class Sink_Water : MonoBehaviour {

	public ParticleSystem water;
	public GameObject sinkWater;
	public Animation anim;
	public bool close = true;
	private Collider coll;
	private GameObject player; 
	public float onTime;            // Amount of time in seconds the laser is on for.
	public float offTime;
	private float timer; 

	
	// Use this for initialization
	void Start () {


	}
	
	void OnMouseDown()
	{
		
	}
	
	// Update is called once per frame
	void Update () {

		if (!anim.isPlaying) {
			
			if(Input.GetKeyDown("o") && close == true)
			{
				anim.Blend ("Handle_Open");
				close = false;
				water.Play();
			}
			else if(Input.GetKeyDown("c") && close == false)
			{
				anim.Blend("Handle_Close");
				water.Stop();
				close = true;
			}
			
		}

			

	}

	void PlayAnim(string s)
	{

		anim.Blend (s);
	}



	void Awake ()
	{
		// Setting up references.
		player = GameObject.FindGameObjectWithTag("Player");

	}
	void OnTriggerStay(Collider other)
	{
		print (other.tag);
		if (other.gameObject == player && close == true) {
			anim.Blend ("Handle_Open");
			close = false;
			water.Play ();
		} 
				
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == player && close == false) {
			anim.Blend ("Handle_Close");
			close = true;
			water.Stop ();
		}
	}
}
