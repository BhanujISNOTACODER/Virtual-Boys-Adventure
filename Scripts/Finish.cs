using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] private AudioSource finishSound;
    private bool soundPLayed = false;
      private void OnTriggerEnter2D(Collider2D other) {
        if(!soundPLayed && other.gameObject.name=="Player"){
            finishSound.Play(); 
            soundPLayed = true;
            Invoke("CompleteLevel",2f);
        }
    }
    private void CompleteLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
