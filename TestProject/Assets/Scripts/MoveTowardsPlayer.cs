using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveTowardsPlayer : MonoBehaviour
{
    public GameObject _moveTowards;
    public float _movementSpeed = 4;

    [SerializeField]
    private GameObject _wrongChoiceSceneMessage;

    [SerializeField]
    private GameObject _oppositionTryMessage;

    void Update()
    {

        //HomeTeam = GameObject.FindGameObjectWithTag("HomeTeam");
        if (_moveTowards != null)
        {
            transform.LookAt(_moveTowards.transform);
            transform.position += transform.forward * _movementSpeed * Time.deltaTime;
        } 

    }

    private void OnCollisionEnter(Collision collision)
    {

        Destroy(_moveTowards);

        if (collision.transform.tag == "Player")
        {
            //Destroy(gameObject);
            ScoreBoard._score -= 500;

            _wrongChoiceSceneMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }

        if (collision.transform.tag == "TutorialPlayer")
        {
            _wrongChoiceSceneMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }


    }

}
