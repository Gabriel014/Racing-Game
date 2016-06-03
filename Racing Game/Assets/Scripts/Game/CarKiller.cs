using UnityEngine;

public class CarKiller : MonoBehaviour {

    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y  < 8)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}