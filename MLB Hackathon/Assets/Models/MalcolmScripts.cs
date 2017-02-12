using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalcolmScripts : MonoBehaviour {

    public void changeAnimation(int a)
    {
        switch (a)
        {
            case 0:
                myAnimator.SetTrigger("Idle");
                break;
            case 1:
                myAnimator.SetTrigger("Strike");
                break;
            case 2:
                myAnimator.SetTrigger("Run");
                break;
            case 3:
                myAnimator.SetTrigger("Victory");
                break;
            case 4:
                myAnimator.SetTrigger("JumpVictory");
                break;
            case 5:
                myAnimator.SetTrigger("Exercise");
                break;

        }

    }


    public void changeAnimation(string a)
    {
        switch (a)
        {
            case "Idle":
                myAnimator.SetTrigger("Idle");
                break;
            case "Strike":
                myAnimator.SetTrigger("Strike");
                break;
            case "Run":
                myAnimator.SetTrigger("Run");
                break;
            case "Victory":
                myAnimator.SetTrigger("Victory");
                break;
            case "JumpVictory":
                myAnimator.SetTrigger("JumpVictory");
                break;
            case "Exercise":
                myAnimator.SetTrigger("Exercise");
                break;

        }

    }
    Animator myAnimator;

    //int jumpHash = Animator.StringToHash("hit");
    int runStateHash = Animator.StringToHash("Base Layer.hit");

    // Use this for initialization
    void Start()
    {
        //anim = GetComponent<Animator>();
        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo stateInfo = myAnimator.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeAnimation(1);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            changeAnimation(2);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            changeAnimation(3);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            changeAnimation(4);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            changeAnimation(5);
        }

    }

    /*
    Animator anim;
    int jumpHash = Animator.StringToHash("Jump");
    int runStateHash = Animator.StringToHash("Base Layer.Run");

    
    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        float move = Input.GetAxis("Vertical");
        anim.SetFloat("Speed", move);

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.Space) && stateInfo.nameHash == runStateHash)
        {
            anim.SetTrigger(jumpHash);
        }
    }*/
}

//Space = 0.3;
//myAnimator.SetFloat("Space", 0.3f);
//myAnimator.SetTrigger("Hit");
            //myAnimator.SetTrigger(jumpHash);
            //myAnimator.CrossFade("hit");