using UnityEngine;
using System.Collections;

public class Hand_Controller : MonoBehaviour {



	public ParticleSystem water;
	private Animation sink;
	private bool close = true;
	// Use this for initialization
	void Start () {

		//Sink_Water sink = GameObject.Find ("Sink").GetComponent ("Sink_Water") as Sink_Water;
		//Ray ray = Camera.main.ScreenPointToRay(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		//RaycastHit hit;

	}
	
	// Update is called once per frame
	void Update () {

		Ray ray = Camera.main.ScreenPointToRay(this.transform.position);
		RaycastHit hit;
		
		if (Physics.Raycast(ray,out hit)){
		print(hit.collider.tag);
		Debug.DrawRay(transform.position,hit.collider.transform.position,Color.red );
			//transform.position = ray.GetPoint(100.0F);
			if(hit.collider.tag == "Sink" && close == true)
			{
				if(sink == null)
					sink = hit.collider.gameObject.GetComponent ("Animation") as Animation;

				sink.Blend("Handle_Open");

				water.Play();
				close = false;
			}
			else if (close == false && hit.collider.tag != "Sink" )
			{

				sink.Blend("Handle_Close");
				
				water.Stop();
				close = true;
			}
			}
			
	}

}
