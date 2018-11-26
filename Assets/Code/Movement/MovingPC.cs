using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPGNamespace;
using Pathfinding;
using Cinemachine;

public class MovingPC : MovingCharacter {

    private Animator animator; // animator component
    private PlayerStats stats; // stats script to get speed

    private float prevX; // last fixed update's x pos
    private float prevY; // last fixed update's y pos

    // Used for switching control
    public bool playerControlled;
    public bool shouldFollow;
    private AIPath aipath;
    private AIDestinationSetter destSetter;
    private CinemachineVirtualCamera virtualCamera;

    protected override void Start() {
        // Get components and set move speed from speed stat
        animator = transform.GetChild(0).GetComponent<Animator>();
        stats = GetComponent<PlayerStats>();
        setInverseMoveTime(stats.speed.getValue());
        // Set character type to player
        setCharacterType(CharacterType.Player);
        // Get components for AI following and camera
        aipath = GetComponent<AIPath>();
        destSetter = GetComponent<AIDestinationSetter>();
        virtualCamera = GameObject.FindGameObjectWithTag("VirtualCamera").GetComponent<CinemachineVirtualCamera>();
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
            // Don't allow diagonal movement
            if (horizontal != 0) {
                vertical = 0;
            }
        }

        // Attempt to move in direction of input
        if (horizontal != 0 || vertical != 0) {
            AttemptMove(horizontal, vertical);
        }

    }

    private void FixedUpdate () {
        // Update animations
        float changeX = transform.position.x - prevX;
        float changeY = transform.position.y - prevY;
        if (Mathf.Abs(changeX) < float.Epsilon && Mathf.Abs(changeY) < float.Epsilon) {
            animator.SetBool("moving", false);
        }
        else {
            animator.SetBool("moving", true);
            if (Mathf.Abs(changeX) > Mathf.Abs(changeY)) {
                if (changeX < 0) {
                    animator.SetInteger("direction", 3);
                }
                else {
                    animator.SetInteger("direction", 1);
                }
            }
            else {
                if (changeY > 0) {
                    animator.SetInteger("direction", 0);
                }
                else {
                    animator.SetInteger("direction", 2);
                }
            }
        }
        // Store for next fixed update
        prevX = transform.position.x;
        prevY = transform.position.y;
    }

    public void setAsFollowed () {
        aipath.canSearch = false;
        aipath.canMove = false;
        destSetter.target = null;
       
        playerControlled = true;
        virtualCamera.Follow = transform;
    }

    public void setAsFollower (GameObject target) {
        playerControlled = false;

        aipath.canSearch = true;
        aipath.canMove = true;
        destSetter.target = target.transform;
    }

}
