using UnityEngine;

public class MenuMover : MonoBehaviour
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
		if (screenPosition.x + Screen.height/2 < 0||screenPosition.x - Screen.height/2 > 800){
			Destroy (this.gameObject);
		}
	}
}