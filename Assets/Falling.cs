using UnityEngine;
using System.Collections;

public class Falling : MonoBehaviour
{

    public float speed = 5f;

    // Use this for initialization
    void Start()
    {

    }

    // Responsible for making the krito fall
    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
