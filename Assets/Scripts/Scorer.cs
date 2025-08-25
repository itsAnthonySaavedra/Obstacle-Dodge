using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've Bumped into an object this many times: " + hits);
        } else
        {
            Debug.Log("This object has already been hit.");
        }
    }
}
