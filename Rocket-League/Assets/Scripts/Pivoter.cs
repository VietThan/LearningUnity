using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivoter : MonoBehaviour
{
    public GameObject ball;

    // move the car first before the look at function runs
    void LateUpdate(){
        transform.LookAt(ball.transform.position);
    }
}
