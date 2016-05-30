using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-3, 0);
    public float range;

    // This scripts movesobjects, such as roads, fuels, obstacles, cars and etc.
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
        transform.position = new Vector3(transform.position.x - range * Random.value, transform.position.y, transform.position.z);
    }
    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y + (Screen.height * 1.1) < 0)
            Destroy(this.gameObject);
    }
}