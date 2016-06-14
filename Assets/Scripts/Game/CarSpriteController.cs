using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CarSpriteController : MonoBehaviour {

	public GameObject Car;
	public GameObject EnemyCar1;
	public GameObject EnemyCar2;

	public Sprite model1, model2, model3, model4, model5;
	public int carModel;

	// Use this for initialization
	void Start () {

		string playerChoice = PlayerPrefs.GetString("car");

		if (playerChoice == "1"){
			Car.GetComponent<SpriteRenderer>().sprite = model1;
			EnemyCar1.GetComponent<SpriteRenderer>().sprite = model2;
			EnemyCar2.GetComponent<SpriteRenderer>().sprite = model3;
		}
		if (playerChoice == "2"){
			Car.GetComponent<SpriteRenderer>().sprite = model2;
			EnemyCar1.GetComponent<SpriteRenderer>().sprite = model3;
			EnemyCar2.GetComponent<SpriteRenderer>().sprite = model4;
		}
		if (playerChoice == "3"){
			Car.GetComponent<SpriteRenderer>().sprite = model3;
			EnemyCar1.GetComponent<SpriteRenderer>().sprite = model4;
			EnemyCar2.GetComponent<SpriteRenderer>().sprite = model5;
		}
		if (playerChoice == "4"){
			Car.GetComponent<SpriteRenderer>().sprite = model4;
			EnemyCar1.GetComponent<SpriteRenderer>().sprite = model5;
			EnemyCar2.GetComponent<SpriteRenderer>().sprite = model1;
		}
		if (playerChoice == "5"){
			Car.GetComponent<SpriteRenderer>().sprite = model5;
			EnemyCar1.GetComponent<SpriteRenderer>().sprite = model1;
			EnemyCar2.GetComponent<SpriteRenderer>().sprite = model2;
		}
	}
}
