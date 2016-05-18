using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class Tapping : MonoBehaviour
{
    public GameObject orb;

    public bool isTapped;
    public int score;
    public Text orbScore;


    // score coming soon!

    // Use this for scarification-modification
    void Start()
    {
        StartCoroutine("Spawn");
        isTapped = false;
        
    }

    // Controls color change when you press space
    void Update()
    {
        if (isTapped == true)
        {
            orb.transform.position = new Vector3(0, 6, 0);
            StartCoroutine("Delay");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            renderer.color = Color.gray;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SpriteRenderer renderer = GetComponent<SpriteRenderer>();
            renderer.color = Color.white;
        }
    }
   
    // Checks if kripto was "tagged" on stay
    void OnTriggerStay2D(Collider2D other)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isTapped = true;
            score += 1;
            orbScore = GameObject.Find("Text").GetComponent<Text>();
            orbScore.text = score.ToString();

            Debug.Log("Score: " + score);
        }
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
