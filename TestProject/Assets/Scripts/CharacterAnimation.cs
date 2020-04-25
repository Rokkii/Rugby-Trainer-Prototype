using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{

    private Animator _charAnimation;

    // Start is called before the first frame update
    void Start()
    {
        _charAnimation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _charAnimation.SetBool("isRunning", true);
        }
        else
        {
            _charAnimation.SetBool("isRunning", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            _charAnimation.SetBool("runningBackwards", true);
        }
        else
        {
            _charAnimation.SetBool("runningBackwards", false);
        }
    }
}
