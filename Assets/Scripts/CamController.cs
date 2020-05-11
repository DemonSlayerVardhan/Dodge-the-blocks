// Author - Vardhan Patil
// Created 08-05-2020
// This program controls the camera
using UnityEngine;

public class CamController : MonoBehaviour 
{
	public Transform player;//Refers to trensform of the player
	public Vector3 offset;//offset of the camera is stored in this variablejof type Vector3
	void Update () 
	{
		// Update() is called once per frame
		transform.position = player.position + offset;//This snaps the camera behind the player every frame using values of offset
	}
}
