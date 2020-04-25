using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScore : MonoBehaviour
{

    [SerializeField]
    private GameObject _endSceneMessage;

    [SerializeField]
    private GameObject _oppositionTryMessage;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            ScoreBoard._score += 500;
            Destroy(gameObject);

            _endSceneMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/

        }

        if (collision.transform.tag == "Opponent")
        {
            ScoreBoard._score -= 500;
            Destroy(gameObject);

            _oppositionTryMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }

        if (collision.transform.tag == "TackleTarget")
        {
            ScoreBoard._score -= 500;
            Destroy(gameObject);

            _oppositionTryMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }

        if (collision.transform.tag == "TutorialPlayer")
        {
            Destroy(gameObject);

            _endSceneMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/

        }

        if (collision.transform.tag == "TutorialTarget")
        {
            Destroy(gameObject);

            _oppositionTryMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }
    }
}
