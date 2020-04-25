using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    [SerializeField]
    private GameObject _outOfBoundsMessage;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.tag == "Player")
        {
            ScoreBoard._score -= 500;
            Destroy(gameObject);

            _outOfBoundsMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }

        if (collision.transform.tag == "Tackler")
        {
            ScoreBoard._score -= 500;
            Destroy(gameObject);

            _outOfBoundsMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }

        if (collision.transform.tag == "TutorialTackler")
        {
            Destroy(gameObject);

            _outOfBoundsMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }

        if (collision.transform.tag == "TutorialPlayer")
        {
            Destroy(gameObject);

            _outOfBoundsMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }
    }
}
