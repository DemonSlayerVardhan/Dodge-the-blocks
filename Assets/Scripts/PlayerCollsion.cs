// Author - Vardhan Patil
// Created 08-05-2020
// This program stops the player when it collides
using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{

	void OnCollisionEnter (Collision collisionInfo)
	{

		if (collisionInfo.collider.tag == "Obstacle") 
		{
			//Will be executed if the player collides with objects of tag "Obstacle"
			FindObjectOfType<GameManager>().gameOver();
		}
	}	
}
