﻿using UnityEngine;
using System.Collections;

public class Gizmo : MonoBehaviour {

	public float gizmoSize = 0.75f;
	public  Color gizmoColor = Color.yellow;

	void OnDrawGizmo()
	{
		Gizmos.color = gizmoColor;
		Gizmos.DrawWireSphere (transform.position, gizmoSize);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
