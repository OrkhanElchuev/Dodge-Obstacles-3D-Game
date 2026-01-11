using UnityEngine;

public class ScoreManagement : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            print(hits);
        }
    }
}
