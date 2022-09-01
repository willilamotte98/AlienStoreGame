using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;


public class PlayerController : MonoBehaviour{
    CharacterController characterController;

    private Animator playerAnim;

    void Awake(){
        characterController = GetComponent<CharacterController>();
        playerAnim = GetComponent<Animator>();
    }

    void Start(){
    }

    void Update(){
        Cursor.visible = true; 
        Movement();
    }
    void Movement(){
        if (Input.GetKey(KeyCode.W)){
            playerAnim.SetBool("Walking", true);
            playerAnim.SetBool("Backing", false);
            //Debug.Log("Walking");
        }
        else if (Input.GetKey(KeyCode.S)){
            playerAnim.SetBool("Walking", false);
            playerAnim.SetBool("Backing", true);
            //Debug.Log("Walking");
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){
            playerAnim.SetBool("Walking", true);
            playerAnim.SetBool("Backing", false);
            //Debug.Log("Walking");
        }
        else{
            playerAnim.SetBool("Walking", false); 
            playerAnim.SetBool("Backing", false);
        }
    }
}
