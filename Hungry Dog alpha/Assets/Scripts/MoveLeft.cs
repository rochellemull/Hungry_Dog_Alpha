using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviout{

    private float speed = 20;
    private Playercontroller playerControllerScript;

Void Start(){
    playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
}

Void update(){
    If (playerControllerScript.gameOver == false){
        transform.Translate(Vector3.left * Time.deltaTime * speed);
}
}

}
