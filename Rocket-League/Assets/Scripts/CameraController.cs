using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cam;
    public GameObject car;
    public GameObject cameraRig;

    public GameObject ballCameraRig;
    public GameObject target;
    public GameObject ball;

    //No Start method

    // Update is called once per frame
    // Every update we're looking for input of the user in the form of a mouse switch
    // If so, switch target
    void Update(){
        SwitchTarget();
    }

    // Late update goes after update() and transform our camera
    void LateUpdate(){
        BallCam();
        CarCam();
    }

    void CarCam(){
        if(target == car){
            cam.transform.position = cameraRig.transform.position;
            cam.transform.LookAt(car.transform.position);
        }
    }

    void BallCam(){
        if(target == ball){
            cam.transform.position = ballCameraRig.transform.position;
            cam.transform.LookAt(ball.transform.position);
        }
    }

    void SwitchTarget(){
        if(Input.GetKeyDown(KeyCode.Mouse0)){
            if(target == car){
                target = ball;
            } else {
                target = car;
            }
        }
    }
}
