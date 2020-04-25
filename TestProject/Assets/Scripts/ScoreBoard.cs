using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public static float _score = 0;
    public Text _scoreText;

    void Update()
    {
        _scoreText.text = _score.ToString("0");  // outputs score as text string
    }

    public void ResetScore()
    {
        _score = 0;
    }

}