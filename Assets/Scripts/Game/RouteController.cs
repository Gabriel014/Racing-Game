using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RouteController : MonoBehaviour {
	[SerializeField]
	private GameObject route2Button, route3Button, route4Button, route5Button;
	public Sprite route2On, route2Off;
	public Sprite route3On, route3Off;
	public Sprite route4On, route4Off;
	public Sprite route5On, route5Off;

	// Use this for initialization
	void Start () {
		
		string clear1 = PlayerPrefs.GetString("clear1");
		string clear2 = PlayerPrefs.GetString("clear2");
		string clear3 = PlayerPrefs.GetString("clear3");
		string clear4 = PlayerPrefs.GetString("clear4");

		if (clear1 == "true"){
			route2Button.GetComponent<Image>().sprite = route2On;
			route2Button.GetComponent<Button>().interactable = true;
		}
		else {
			route2Button.GetComponent<Image>().sprite = route2Off;
			route2Button.GetComponent<Button>().interactable = false;
		}

		if (clear2 == "true"){
			route3Button.GetComponent<Image>().sprite = route3On;
			route3Button.GetComponent<Button>().interactable = true;
		}
		else {
			route3Button.GetComponent<Image>().sprite = route3Off;
			route3Button.GetComponent<Button>().interactable = false;
		}
		if (clear3 == "true"){
			route4Button.GetComponent<Image>().sprite = route4On;
	 		route4Button.GetComponent<Button>().interactable = true;
		}
		else {
			route4Button.GetComponent<Image>().sprite = route4Off;
			route4Button.GetComponent<Button>().interactable = false;
		}
		if (clear4 == "true"){
			route5Button.GetComponent<Image>().sprite = route5On;
	 		route5Button.GetComponent<Button>().interactable = true;
		}
		else {
			route5Button.GetComponent<Image>().sprite = route5Off;
			route5Button.GetComponent<Button>().interactable = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
