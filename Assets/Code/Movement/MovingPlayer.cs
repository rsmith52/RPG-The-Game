using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayer : MovingCharacter {

    private Animator animator;
    private PlayerStats stats;

    protected override void Start() {
        animator = GetComponent<Animator>();
        stats = GetComponent<PlayerStats>();
        moveTime = 1f / stats.speed.getValue();
        base.Start();
    }

    private void Update() {
        int horizontal = 0;
        int vertical = 0;

        horizontal = (int)(Input.GetAxisRaw("Horizontal"));
        vertical = (int)(Input.GetAxisRaw("Vertical"));

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

        if (horizontal != 0 || vertical != 0) {
            AttemptMove(horizontal, vertical);
        }

    }

}
