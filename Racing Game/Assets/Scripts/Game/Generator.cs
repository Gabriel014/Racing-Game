using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

    public int nextRoad, nextCar, nextObstacle;

    public GameObject road1, road2, road3;
    public GameObject car1, car2;
    public GameObject fuelObject;
    public GameObject obstacle1, obstacle2;
    public GameObject finishLine;

    public int stage;
    public float obstacleRate, fuelRate, carRate, roadRate, finishLineTimer;

    public float marginRight, marginLeft;

	// Use this for initialization
	void Start () {
        stage = PlayerPrefs.GetInt("Stage");

        nextCar = Random.Range(1, 5);
        nextRoad = Random.Range(1, 6);
        nextObstacle = Random.Range(1, 3);

        switch (stage)
        {
            case 1:
                obstacleRate = 0f;
                fuelRate = 0f;
                carRate = 0f;
                roadRate = 0f;
                finishLineTimer = 0f;
                break;
            case 2:
                obstacleRate = 0f;
                fuelRate = 0f;
                carRate = 0f;
                roadRate = 0f;
                finishLineTimer = 0f;
                break;
            case 3:
                obstacleRate = 0f;
                fuelRate = 0f;
                carRate = 0f;
                roadRate = 0f;
                finishLineTimer = 0f;
                break;
        }


        InvokeRepeating("GenerateFuel", fuelRate, fuelRate);
        InvokeRepeating("GenerateObstacle", obstacleRate, obstacleRate);
        InvokeRepeating("GenerateCar", carRate, carRate);
        InvokeRepeating("GenerateRoad", roadRate, roadRate);
        Invoke("FinishLineCreator", finishLineTimer);

	}


    void GenerateFuel() {
        Instantiate(fuelObject);
}

    void GenerateCar() {
        // Generate a random kind of car on the road each carRate seconds, this can be changed so more cars can be added
        if (nextCar <= 3) Instantiate(car1);
        if (nextCar > 3) Instantiate(car2);

        nextCar = Random.Range(1, 5);

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
        if (nextRoad == 1) Instantiate(road2);
        else if (nextRoad == 2) Instantiate(road3);
        else Instantiate(road1);

        nextRoad = Random.Range(1, 6);

    }

    void FinishLineCreator(){
        // Creates the finish line after finishLineTimer seconds has elapsed, this one can be changed according to the
        // current stage.
        Instantiate(finishLine);
    }
}