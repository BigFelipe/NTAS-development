﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    private InputState inputState;
    private Walk walkBehavior;
    private Animator animator;
    private CollisionState collisionState;

    void Avake()
    {
        inputState = GetComponent<InputState>();
        walkBehavior = GetComponent<Walk>();
        animator = GetComponent<Animator>();
        collisionState = GetComponent<CollisionState>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(collisionState.standing)
        {
            ChangeAnimationState(0);
        }
        if (inputState.absVelX > 0)
        {
            ChangeAnimationState(1);
        }

    }

    void ChangeAnimationState(int value)
    {
        animator.SetInteger("AnimState", value);
    }
}
