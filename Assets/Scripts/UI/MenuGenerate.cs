using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuGenerate : MonoBehaviour {

	public GameObject object1;

	public GameObject object2;

	public GameObject object3;

	public GameObject object4;


	int next;
	public int current;
	List<int> listaObj = new List<int>();
	List<GameObject> objList;
	// Randomize values to the variables that will randomize the thrash and its sprite
	void Start () {


		next = Random.Range(1, 5);
		objList = new List<GameObject>();
		listaObj.Add (next);  //adds randomized value to list
		current = next;			//holds the first value on the list, to be used as comparison when the player clicks a button
		InvokeRepeating("Randomizer", 1f, 2f);
	}

	// This method randomizes the next thrash to be showed in the screen
	public void Randomizer () {

		switch (next){
		case 1: 
			objList.Add ((GameObject)Instantiate (object1));
			break;
		case 2:	
			objList.Add ((GameObject)Instantiate (object2));
			break;
		case 3:	
			objList.Add ((GameObject)Instantiate (object3));
			break;
		case 4:	
			objList.Add ((GameObject)Instantiate (object4));
			break;
		}

		next = Random.Range(1, 5);
		listaObj.Add (next);
	
	}

}