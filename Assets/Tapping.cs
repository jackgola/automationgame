using UnityEngine;
using System.Collections;

public class Tapping : MonoBehaviour
{
    public GameObject orb;

    public bool isTapped = false;

    // score coming soon!

    // Use this for scarification-modification
    void Start()
    {
        StartCoroutine("Spawn");
    }

    // Controls color change when you press space
    void Update()
    {
        if (isTapped == true)
        {
            orb.transform.position = new Vector3(5, 6, 1);
            StartCoroutine("Delay");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            renderer.color = Color.cyan;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            renderer.color = Color.white;
        }
    }
    // Checks if kripto was "tagged" on enter
    void OnTriggerEnter2D(Collider2D other)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isTapped = true;
        }
    }
    // Checks if kripto was "tagged" on stay
    void OnTriggerStay2D(Collider2D other)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isTapped = true;
        }
    }
    // Checks if kripto was "tagged" on exit
    void OnTriggerExit2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
            isTapped = true;
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(2f);
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(0.5f);
        isTapped = false;
    }

}
