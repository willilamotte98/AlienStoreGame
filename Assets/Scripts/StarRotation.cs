using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarRotation : MonoBehaviour{
    public GameObject target;
    [SerializeField] float speed;

    void Update(){
        transform.RotateAround(target.transform.position, Vector3.up, speed * Time.deltaTime);
    }
}
