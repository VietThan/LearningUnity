using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject ballSpawner;
    public GameObject ball;
    public ScoreKeeper scoreKeeper;


    //careful of Rigidbody
    void OnTriggerEnter(Collider other){
        if (other.gameObject == ball){
            ball.transform.position = ballSpawner.transform.position;
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            scoreKeeper.ScoreGoal();
        }

    }
}
