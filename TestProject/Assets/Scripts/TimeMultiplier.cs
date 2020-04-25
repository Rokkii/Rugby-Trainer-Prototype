using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMultiplier : MonoBehaviour
{
    public GameObject _textDisplay;
    public float _secondsLeft = 10;
    public float _timeGone = 0;

    [SerializeField]
    private GameObject _endSceneMessage;

    [SerializeField]
    private GameObject _outOfTimeMessage;

    [SerializeField]
    private bool _minusScore;

    // Start is called before the first frame update
    void Start()
    {
        _textDisplay.GetComponent<Text>().text = _secondsLeft.ToString("0.0");
    }

    // Update is called once per frame
    void Update()
    {
        if (_secondsLeft >= 0)
        {
            _secondsLeft -= 1 * Time.deltaTime;
            _textDisplay.GetComponent<Text>().text = _secondsLeft.ToString("0.0");
            _minusScore = false;
        }
        else 
        {
            TimeOut();
        }
    }

    public void CorrectChoice()
    {
        ScoreBoard._score += _secondsLeft * 100;
        _endSceneMessage.SetActive(true); /*Disable pause menu UI*/
        Time.timeScale = 0; /*Set time in game to stop*/
    }

    public void WrongChoice()
    {
        ScoreBoard._score -= 500;
       // _endSceneMessage.SetActive(true); /*Disable pause menu UI*/
        //Time.timeScale = 0; /*Set time in game to stop*/
    }

    public void TimeOut()
    {
        
        if (_minusScore == false)
        {
            ScoreBoard._score -= 500;
            _outOfTimeMessage.SetActive(true); /*Disable pause menu UI*/
            _minusScore = true;
        }
    }

}