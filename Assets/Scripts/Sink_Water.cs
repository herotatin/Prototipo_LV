using UnityEngine;
using System.Collections;

public class Sink_Water : MonoBehaviour {

	public ParticleSystem water;
	public GameObject sinkWater;
	public Animation anim;
	private bool close = true;
	
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
}
