using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{   
    
    void Start(){}

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }

}
