using UnityEngine;
using System.Collections;

public class PlayerBound : MonoBehaviour
{

    public float maxUp;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > maxUp) transform.position = new Vector3(transform.position.x, maxUp, transform.position.z);
    }
}
