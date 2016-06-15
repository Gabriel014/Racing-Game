using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {
	
	public int nextRoad, nextCar, nextObstacle;
	public int oponents;
    public static int position;
    public int stageMaxPosition;

    public Sprite first, second, third;
    public GameObject positionSprite;
	public GameObject road1, road2, road3;
	public GameObject car1, car2;
	public GameObject fuelObject;
	public GameObject obstacle1, obstacle2;
	public GameObject finishLine;
	
	public float obstacleRate, fuelRate, carRate, roadRate, finishLineTimer;
	
	// Use this for initialization
	void Start () {
        position = stageMaxPosition;

		nextCar = Random.Range(1, 5);
		nextRoad = Random.Range(1, 6);
		nextObstacle = Random.Range(1, 3);
		
		InvokeRepeating("GenerateFuel", fuelRate, fuelRate);
		InvokeRepeating("GenerateObstacle", obstacleRate, obstacleRate);
		InvokeRepeating("GenerateCar", carRate, carRate);
		InvokeRepeating("GenerateRoad", roadRate, roadRate);
		Invoke("FinishLineCreator", finishLineTimer);
		
	}

    void Update ()
    {
        switch (position)
        {
            case 1:
                positionSprite.GetComponent<SpriteRenderer>().sprite = first;
                break;

            case 2:
                positionSprite.GetComponent<SpriteRenderer>().sprite = second;
                break;

            default:
                positionSprite.GetComponent<SpriteRenderer>().sprite = third;
                break;
        }
    }
	
	
	void GenerateFuel() {
		Instantiate(fuelObject);
	}
	
	void GenerateCar() {
		// Generate a random kind of car on the road each carRate seconds, as long as the limit hasn't been yet reached
		// this can be changed so more cars can be added
		if (oponents > 0){
			if (nextCar <= 3) Instantiate(car1);
			if (nextCar > 3) Instantiate(car2);

			nextCar = Random.Range(1, 6);
			oponents -= 1;
		}

		
	}
	
	void GenerateObstacle() {
		// Generate a random kind of obstacle each obstacleRate seconds, this can be changed so more obstacles can be added
		if (nextObstacle == 1) Instantiate(obstacle1);
		if (nextObstacle == 2) Instantiate(obstacle2);
		
		nextObstacle = Random.Range(1, 3);
	}
	
	void GenerateRoad() {
		// Generates a new kind of road each roadRate seconds, this one has to be synchronized with the road speed so
		// it will create a parallax effect when the game is running (kinda like in Gil's game's parallax). 
		if (nextRoad == 1) {
			Instantiate (road2);
			nextRoad = 3;
		}

		else if (nextRoad == 2){
			Instantiate (road3);
			nextRoad = 3;
		}

		else {
			Instantiate (road1);
			nextRoad = Random.Range (1, 6);
		}
		
	}

    void FinishLineCreator()
    {
        // Creates the finish line after finishLineTimer seconds has elapsed, this one can be changed according to the
        // current stage.
        Instantiate(finishLine);
    }
}