using UnityEngine;
using System.Collections;

public class CarContoller : MonoBehaviour {

	public int fuel = 100;
	public int position;
	public GameObject car = GameObject.Find("Player");

	void Start (){
		InvokeRepeating ("fuelDecreaser", 0.5f, 0.5f);
	}


	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other){

		//If the player collides with an Obstacle, it will end the game.
		if (other.tag == "Obstacle") 
			Application.LoadLevel (Application.loadedLevel);

		//If the player collides with a fuel object, it will increase the fuel by 20 (exactly the same
		//amount of fuel it spends in 10 seconds, time between fuels spawn).
		if (other.tag == "Fuel")
			fuel += 20;

		//If the player collides with the Finish Line it will end the game
		//and redirects the player to a victory screen.
		if (other.name == "FinishLine") 
			Application.LoadLevel (Application.loadedLevel);
	}

	void fuelDecreaser (){
			fuel -= 1;
		}
}