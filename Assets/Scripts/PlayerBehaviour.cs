using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {
    Rigidbody2D myRigidbody;
    [SerializeField] float moveSpeed = 4;
    [SerializeField] float jumpForce = 8;
    bool isGrounded;



    private void Start() {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector2(0, 0);
    }

    public void JumpPlayer() {
        if (!isGrounded) {
            return;
        }
        myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, Physics2D.gravity.y < 0 ? jumpForce : jumpForce * -1);
    }
    
    public void MovimentPlayer(bool right) {
        myRigidbody.velocity = new Vector2(right ? moveSpeed : moveSpeed * -1, myRigidbody.velocity.y);
    }

    //Inputs para testes de movimentação

    private void Inputs() {
        if(Input.GetKey(KeyCode.D)) {
            MovimentPlayer(true);
        }
        if(Input.GetKey(KeyCode.A)) {
            MovimentPlayer(false);
        }
        

        
    }

    private void InputJump() {
        if(Input.GetKeyDown(KeyCode.W)) {
            JumpPlayer();
        }
    }

    private void Update() {
        InputJump();
    }

    private void FixedUpdate() {
        Inputs();
    }

    private void OnCollisionStay2D(Collision2D collision) {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision) { 
        isGrounded = false;
    }
}
