using UnityEngine;
using System.Collections;

public class MenuCarGenerator : MonoBehaviour {

    public int nextMenuCar, lastMenuCar;
    public GameObject menuCar1, menuCar2, menuCar3;

	// Use this for initialization
	void Start () {
        nextMenuCar = Random.Range(1, 4);
        InvokeRepeating("CarCreator", 1f, 1f);
	}
	
	// Update is called once per frame
	void CarCreator () {
        switch (nextMenuCar)
        {
            case 1:
                Instantiate(menuCar1);
                break;
            case 2:
                Instantiate(menuCar2);
                break;
            case 3:
                Instantiate(menuCar3);
                break;
        }
        lastMenuCar = nextMenuCar;
        nextMenuCar = Random.Range(1, 4);

        while (lastMenuCar == nextMenuCar)
        {
            nextMenuCar = Random.Range(1, 4);
        }

    }
}
