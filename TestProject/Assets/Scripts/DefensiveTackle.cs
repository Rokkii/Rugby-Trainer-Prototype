using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefensiveTackle : MonoBehaviour
{
    [SerializeField]
    private GameObject _endSceneMessage;

    [SerializeField]
    private GameObject _wrongTackleMessage;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Opponent")
        {
            Destroy(collision.gameObject);
            ScoreBoard._score -= 500;

            _wrongTackleMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }

        if (collision.transform.tag == "TackleTarget")
        {
            Destroy(collision.gameObject);
            ScoreBoard._score += 500;

            _endSceneMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }

        if (collision.transform.tag == "TutorialTarget")
        {
            Destroy(collision.gameObject);

            _endSceneMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }
    }
}
