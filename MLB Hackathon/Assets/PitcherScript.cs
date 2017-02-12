using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitcherScript : MonoBehaviour {


    Animator myAnimator;

    public void changeAnimation(string a)
    {
        switch (a)
        {
            case "Pitch":
                myAnimator.SetTrigger("Pitch");
                break;
            case "Sad":
                myAnimator.SetTrigger("Sad");
                break;
        }
    }

    public void changeAnimation(int a)
    {
        switch (a)
        {
            case 1:
                myAnimator.SetTrigger("Pitch");
                break;
            case 2:
                myAnimator.SetTrigger("Sad");
                break;

        }

    }
    // Use this for initialization
    void Start () {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo stateInfo = myAnimator.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.W))
        {
            changeAnimation(1);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            changeAnimation(2);
        }

    }

}