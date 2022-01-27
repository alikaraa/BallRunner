using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Traps : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Player")){
            collision.gameObject.GetComponent<Player>().GameOver();
        }
    }
}
