using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    
    public int altinSayisi = 0;
    public Text altinSayisiText;
    public bool isGameActive = false;

  
    public void AltinArttir(){
        altinSayisi += 1;
        altinSayisiText.text = "Score:" + altinSayisi;
    }

    public void GamePause(){
        if(isGameActive == false){
            Time.timeScale = 0f;
            isGameActive = true;
        }else{
            Time.timeScale = 1f;
            isGameActive = false;
        }

    }
}
