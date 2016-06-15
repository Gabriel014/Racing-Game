using UnityEngine;
using System.Collections;

public class CarCollider : MonoBehaviour {

	public static float fuel = 1;
	public GameObject car = GameObject.Find("Player");
	public static bool gameOver;
    public AudioSource audio;
    public AudioClip crash;
    public AudioClip fuelget;
	string music;
    public float fuelAmount;

	void Start (){
        audio = GetComponent<AudioSource>();
        fuel = 1.0f;
		InvokeRepeating ("fuelDecreaser", 0.2f, 0.2f);
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
        if (other.tag == "Car" || other.tag == "Obstacle")
        {
			audio.PlayOneShot(crash, 1f);
            Dead();
        }

        //Application.LoadLevel (Application.loadedLevel);

        //If the player collides with a fuel object, it will increase the fuel by 25 (exactly the same
        //amount of fuel it spends in 10 seconds, time between fuels spawn).
        if (other.tag == "Fuel")
			music = PlayerPrefs.GetString("music");
			if (music != "off") audio.PlayOneShot(fuelget, 1f);

			fuel += fuelAmount;
			if (fuel > 1.0f){
				fuel = 1.0f;
			}
			Destroy (GameObject.FindGameObjectWithTag("Fuel"));
			//SpriteRenderer.Destroy (other);

		//If the player collides with the Finish Line it will end the game
		//and redirects the player to a victory screen.

		if (other.tag == "FinishLine1"){
			PlayerPrefs.SetString("clear1","true");
			Win();
		}
		if (other.tag == "FinishLine2"){
			PlayerPrefs.SetString("clear2","true");
			Win();
		}
		if (other.tag == "FinishLine3"){
			PlayerPrefs.SetString("clear3","true");
			Win();
		}
		if (other.tag == "FinishLine4"){
			PlayerPrefs.SetString("clear4","true");
			Win();
		}
		if (other.tag == "FinishLine5"){
			//PlayerPrefs.SetString("clear1","true");
			Win();
		}
		

		
	}

	void fuelDecreaser () {

		fuel -= 0.01f;
	}

	public static void Dead() {
	
		Destroy(GameObject.Find("Player"));
        gameOver = true;

	}

	public static void Win() {
     	Destroy(GameObject.Find("Player"));
        Dead ();

		
	}
}