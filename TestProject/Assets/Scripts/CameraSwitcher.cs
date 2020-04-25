using UnityEngine;


public class CameraSwitcher : MonoBehaviour
{
    [SerializeField]
    private GameObject _cameraChoice;

    [SerializeField]
    private GameObject _originalCamera;

    [SerializeField]
    private GameObject _passButtons;

    [SerializeField]
    private GameObject _playerChoice;

    [SerializeField]
    private GameObject _activeRugbyBall;

    [SerializeField]
    private GameObject _originalRugbyBall;

    private void OnMouseDown()
    {
        GetComponent<MoveTowardsTry>().enabled = false;
        GetComponent<WASDmovement>().enabled = true;

        // disable pass buttons
        _passButtons.SetActive(false);

        // enable new player items
        _cameraChoice.SetActive(true);
        _activeRugbyBall.SetActive(true);

        // disable original player items
        _originalCamera.SetActive(false);
        _originalRugbyBall.SetActive(false);

        if (_playerChoice.tag == "TutorialPlayer")
        {
            GetComponent<CharacterAnimation>().enabled = true;
        }

        if (_playerChoice.tag != "TutorialPlayer")
        {
            GameObject.Find("Player").GetComponent<WASDmovement>().enabled = false;
            GameObject.Find("Player").GetComponent<Animator>().enabled = false;
            GameObject.Find("Player").transform.tag = "HomeTeam";

            _playerChoice.tag = "Player";
        }
    }
}
