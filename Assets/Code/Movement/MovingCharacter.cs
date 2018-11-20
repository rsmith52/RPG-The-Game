using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovingCharacter : MonoBehaviour {

    public float moveTime; // time in seconds it takes to move one unit
    public LayerMask blockingLayer; // layer with obstacles that impede movement

    private BoxCollider2D boxCollider; // this character's box collider
    private Rigidbody2D rb2d; // this character's rigid body
    private float inverseMoveTime; // inverse of move time used for computing move speed

	protected virtual void Start () {
        // Get components and speed set
        boxCollider = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
        inverseMoveTime = 1f / moveTime;
	}
	
    protected bool Move (int xDir, int yDir, out RaycastHit2D hit) {
        // Figure out where moving from and to
        Vector2 start = transform.position;
        Vector2 end = start + new Vector2(xDir, yDir);

        // Check for obtacles in the way of movement
        boxCollider.enabled = false;
        hit = Physics2D.Linecast(start, end, blockingLayer);
        boxCollider.enabled = true;

        if (hit.transform == null) {
            // Nothing Hit
            Vector2 newPosition = Vector2.MoveTowards(rb2d.position, end, inverseMoveTime * Time.deltaTime);
            rb2d.MovePosition(newPosition);
            return true;
        }

        // Failed to move
        Debug.Log("Failed to Move");
        return false;
    }

    protected virtual void AttemptMove(int xDir, int yDir) {
        RaycastHit2D hit;
        bool canMove = Move(xDir, yDir, out hit);

        if (hit.transform == null) {
            return;
        }

        if (canMove == false) {
            // Can do something here on failed to move
        }
    }
}
