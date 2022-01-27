using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endFlag : MonoBehaviour
{
    

    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}
