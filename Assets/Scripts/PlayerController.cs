// Author - Vardhan Patil
// Created 08-05-2020
// This program controls the player
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody RB;//Refers to rigidbody component

	public float forwardForce = 2000f;//Creates a public variable 'forwardForce' of type float and stores "2000" in it.
	public float sidewaysForce = 500f;//Creates a public variable 'sidewaysForce' of type float and stores "2000" in it.

	public string left = "a";//Creates a public variable 'left' of type string and stores "a" in it.
	public string right = "d";//Creates a public variable 'right' of type string and stores "d"in it.

	public PlayerController movement;

	void Update ()
	{
		//Update() is called once per frame
		RB.AddForce(0 ,0, forwardForce * Time.deltaTime );//Pushes the player forwarrd by the value of forwardForce
		if ( Input.GetKey(right) )
		{
			//This code will only be executed if key assigned to right is pressed
			RB.AddForce( sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
			//The line above pushes the player to right by the value of sideways force without checking the mass 
		}
		if ( Input.GetKey(left) )
		{
			//This code will only be executed if the key assigned to left is pressed
			RB.AddForce( -sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			//The line above pushes the player to left by the value of sideways force without checking the mass
			if (RB.position.y < -1)
			{
				FindObjectOfType <GameManager> ().gameOver();
			}
		}
	}
}
