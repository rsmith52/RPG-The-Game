using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGNamespace;

public class MovingPC : MovingCharacter {

    private Animator animator; // animator component
    private PlayerStats stats; // stats script to get speed

    public bool playerControlled;

    protected override void Start() {
        // Get components and set move speed from speed stat
        animator = transform.GetChild(0).GetComponent<Animator>();
        stats = GetComponent<PlayerStats>();
        setCharacterType(CharacterType.Player);
        setInverseMoveTime(stats.speed.getValue());
        base.Start();
    }

    private void Update() {
        // Hold input for each direction
        int horizontal = 0;
        int vertical = 0;

        if (playerControlled) {
            // Get user input
            horizontal = (int)(Input.GetAxisRaw("Horizontal"));
            vertical = (int)(Input.GetAxisRaw("Vertical"));
        }

        // See if any input was given, update animations
        if (horizontal == 0 && vertical == 0) {
            animator.SetBool("moving", false);
        } else {
            animator.SetBool("moving", true);
            if (horizontal != 0) {
                if (horizontal < 0) {
                    animator.SetInteger("direction", 3);
                }
                else {
                    animator.SetInteger("direction", 1);
                }
                // Don't allow diagonal movement
                vertical = 0;
            }
            else {
                if (vertical > 0) {
                    animator.SetInteger("direction", 0);
                }
                else {
                    animator.SetInteger("direction", 2);
                }
            }
        }

        // Attempt to move in direction of input
        if (horizontal != 0 || vertical != 0) {
            AttemptMove(horizontal, vertical);
        }

    }

}
