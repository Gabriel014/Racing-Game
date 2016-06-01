using UnityEngine;

public class RoadMover : MonoBehaviour
{
	public Vector2 velocity = new Vector2(-3, 0);
	
	// This scripts movesobjects, such as roads.
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
	}
	void Update()
	{
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y + Screen.height/2 < 0){
			Destroy (this.gameObject);
		}
	}
}