using UnityEngine;
using System.Collections;

public class UnlockStages : MonoBehaviour {
	
	// Update is called once per frame
	public void UnlockItAll () {
        if (Input.GetMouseButtonDown(0))
        {
            PlayerPrefs.SetString("clear1", "true");
            PlayerPrefs.SetString("clear2", "true");
            PlayerPrefs.SetString("clear3", "true");
            PlayerPrefs.SetString("clear4", "true");
        }
	}
}
