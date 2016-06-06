using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RouteController : MonoBehaviour {


	public string SceneToLoad;

	public float time = 0.5F;

	public void Update (){
		if (Input.GetKey (KeyCode.Escape)) {
			Escape ();
		}
	}

	public void ChangeScene(){

		Time.timeScale = 1;

		StartCoroutine ("DisplayScene");		
	}

	public void Quit(){
		Application.Quit();

	}

	public void Escape(){
		SceneManager.LoadScene ("Menu");
	}

	IEnumerator DisplayScene(){
		yield return new WaitForSeconds(time);
		LoadingScene.sceneToLoad = SceneToLoad;
		SceneManager.LoadScene("Loading");
	}
}