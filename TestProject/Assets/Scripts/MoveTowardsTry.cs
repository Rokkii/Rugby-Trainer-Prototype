using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsTry : MonoBehaviour
{
    public float movementSpeed = 4;
    public GameObject _tryObjective;

    [SerializeField]
    private GameObject _oppositionTryMessage;

    void Update()
    {
        if (_tryObjective != null)
        {
            transform.LookAt(_tryObjective.transform);
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "TackleTarget")
        {
            //Destroy(gameObject);
            ScoreBoard._score -= 500;

            _oppositionTryMessage.SetActive(true); /*Disable pause menu UI*/
            Time.timeScale = 0f; /*Set time in game to stop*/
        }
    }
}