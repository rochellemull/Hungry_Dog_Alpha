using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagment;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Scoring score;

    public void Start(){

    }

    public void Update(){
        If (Inpute.GetKeyDown(keyCode.Space)){     //when you press to the space bar the score Is gonna change 
        Score.AddScore(-1);
        }
    }

}