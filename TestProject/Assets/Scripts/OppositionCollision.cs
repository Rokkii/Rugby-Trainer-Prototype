using UnityEngine;

public class OppositionCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Tackler")
        {
            Destroy(gameObject);
            ScoreBoard._score -= 100;
        }
    }
}
