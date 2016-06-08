using UnityEngine;
using System.Collections;

public class Splash : MonoBehaviour {

	public float time = 2f;
	public string levelToLoad = "Menu";


	// Use this for initialization
	void Start () {
		StartCoroutine ("DisplayScene");
	}

	IEnumerator DisplayScene(){
		yield return new WaitForSeconds(time);
		Application.LoadLevel (levelToLoad);
	}
}