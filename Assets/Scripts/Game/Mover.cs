using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-3, 0);
    public float range;
	public GameObject thisGameObject, player;
	public int carPosition;
    public bool triggered = true;

    // This scripts movesobjects, such as fuels, obstacles, cars and etc.
    void Start()
    {
        InvokeRepeating("RotationFixer", 1f, 1f);
        player = GameObject.Find("Player");
		thisGameObject = gameObject;
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position = new Vector3(transform.position.x - range * Random.value, transform.position.y, transform.position.z);
        
    }
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y + (Screen.height * 1.1) < 0){
			Destroy (this.gameObject);
    	}

        if (thisGameObject.transform.position.y < player.transform.position.y && triggered && thisGameObject.tag == "Car") {
            Generator.position -= 1;
            triggered = false;
            print("-1");
        }
        if (thisGameObject.transform.position.y > player.transform.position.y && !triggered && thisGameObject.tag == "Car"){
            Generator.position += 1;
            triggered = true;
            print("+1");
        }
    }

    void OnCollisionEnter2D (Collider2D other)
    {
        if (other.name == "Road2") transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        else if (other.name == "Road3") transform.position = new Vector3(5, transform.position.y, transform.position.z);
        else transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void RotationFixer()
    {
        thisGameObject.GetComponent<Rigidbody2D>().rotation = 0;
    }

}