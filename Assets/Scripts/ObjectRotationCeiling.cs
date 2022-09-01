using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotationCeiling : MonoBehaviour{
    float degreesPerSecond = 20;
    float speed = 3f;
    private void Update()
    {
        transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime * speed);
    }
}
