using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-3, 0);
    public float range;
	public GameObject thisGameObject;
	public int carPosition;

    // This scripts movesobjects, such as fuels, obstacles, cars and etc.
    void Start()
    {
		thisGameObject = gameObject;
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position = new Vector3(transform.position.x - range * Random.value, transform.position.y, transform.position.z);
        
    }
    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y + (Screen.height * 1.1) < 0){
			if (thisGameObject.name == "Car1" || thisGameObject.name == "Car2") carPosition -= 1;
			Destroy (this.gameObject);
    	}
	}

    void OnCollisionEnter2D (Collider2D other)
    {
        if (other.name == "Road2") transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        else if (other.name == "Road3") transform.position = new Vector3(5, transform.position.y, transform.position.z);
        else transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

}