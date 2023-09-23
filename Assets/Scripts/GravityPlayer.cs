using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityPlayer : MonoBehaviour
{
    void GravityInvert() {
        Physics2D.gravity = new Vector2(Physics2D.gravity.x, Physics2D.gravity.y * -1);
    }


    void InputGravity() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            GravityInvert();
        }
        
    }


    void Update()
    {
        InputGravity();
    }
}
