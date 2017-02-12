using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    //Animator anim;
    Animator myAnimator;
    // Use this for initialization
    void Start()
    {
        //anim = GetComponent<Animator>();
        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //float time =  
        //float move = Input.time
        myAnimator.SetFloat("VSpeed", Input.GetAxis("Vertical"));
    }
}
