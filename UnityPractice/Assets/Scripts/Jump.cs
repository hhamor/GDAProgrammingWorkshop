using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    // Enums - Determine types for the specific class
    public enum JumpType {
        Normal,
        DoubleJump,
        LeftStrafe,
        RightStrafe,
    }

    JumpType Type;
    public int jumpHeight;
    public int jumpX;

    // Use this for initialization
    void Start () {
       
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Normal Jump");
            Type = JumpType.Normal;
            DoJump(Type);
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
           if (Input.GetKeyDown(KeyCode.LeftArrow)) {
                Debug.Log("Left Strafe");
                Type = JumpType.LeftStrafe;
                DoJump(Type);
           } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
                Debug.Log("Right Strafe");
                Type = JumpType.RightStrafe;
                DoJump(Type);
            }
        }
    }

    public void DoJump(JumpType Type) {
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        body.AddForce(new Vector2(jumpX, jumpHeight));

        if (Type == JumpType.Normal) {
            jumpHeight = 125;
            jumpX = 0;
        } else if (Type == JumpType.LeftStrafe) {
            jumpHeight = 125;
            jumpX = -125;
        } else if (Type == JumpType.RightStrafe) {
            jumpHeight = 125;
            jumpX = 125;
        }
    }
}
