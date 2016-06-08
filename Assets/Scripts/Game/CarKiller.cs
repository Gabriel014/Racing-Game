using UnityEngine;

public class CarKiller : MonoBehaviour {

    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y  < 10)
        {
			CarCollider.Dead();
			//Application.LoadLevel(Application.loadedLevel);
        }
    }
}