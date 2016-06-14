using UnityEngine;
using System.Collections;

public class CarSelect : MonoBehaviour {

	// Use this for initialization
	public void Choose1 () {

		PlayerPrefs.SetString("car","1");
	}

	public void Choose2 () {

		PlayerPrefs.SetString("car","2");
	}

	public void Choose3 () {

		PlayerPrefs.SetString("car","3");
	}

	public void Choose4 () {

		PlayerPrefs.SetString("car","4");
	}

	public void Choose5 () {

		PlayerPrefs.SetString("car","5");
	}		
}
