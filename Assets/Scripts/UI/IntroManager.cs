using UnityEngine;
using System.Collections;

public class IntroManager : MonoBehaviour {

    public GameObject intro;
    public GameObject button;

	// Use this for initialization
	void Awake () {
        if (PlayerPrefs.GetInt("Intro") == 1)
        {
            Destroy(intro);
            Destroy(button);
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void IntroDisabled()
    {
        Destroy(intro);
        Destroy(button);
        PlayerPrefs.SetInt("Intro", 1);
    }
}
