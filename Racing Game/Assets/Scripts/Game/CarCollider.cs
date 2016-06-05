using UnityEngine;
using System.Collections;

public class CarCollider : MonoBehaviour {

	public static float fuel = 1;
	public static int position;
	public GameObject car = GameObject.Find("Player");
	public static bool gameOver;

	void Start (){
		InvokeRepeating ("fuelDecreaser", 0.5f, 0.5f);
		gameOver = false;
	}

    void Update()
    {
        if (fuel <= 0) 
			Dead();
            //Application.LoadLevel(Application.loadedLevel);
    }


	// Use this for initialization
	void OnTriggerEnter2D (Collider2D other){

		//If the player collides with an Obstacle, it will end the game.
		if (other.tag == "Obstacle") 
			Dead();
			//Application.LoadLevel (Application.loadedLevel);

		//If the player collides with a fuel object, it will increase the fuel by 20 (exactly the same
		//amount of fuel it spends in 10 seconds, time between fuels spawn).
		if (other.tag == "Fuel")
			fuel += 0.2f;

		//If the player collides with the Finish Line it will end the game
		//and redirects the player to a victory screen.
		if (other.name == "FinishLine") 
			Application.LoadLevel (Application.loadedLevel);
	}

	void fuelDecreaser (){
			fuel -= 0.01f;
		}

	public static void Dead(){
		Destroy(GameObject.Find("Player"));
		gameOver = true;

	}
}