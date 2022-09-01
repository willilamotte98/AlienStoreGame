using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour{
    private Animator anim;
    
    void Start(){
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            anim.SetTrigger("PlayerPresence");
            Debug.Log("Entered Door Zone");
        }
    }
    void OnTriggerExit(Collider other){
        if(other.CompareTag("Player")){
            anim.SetTrigger("PlayerPresence");
            Debug.Log("Exited Door Zone");
        }
    }
}
