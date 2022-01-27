using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text pointText;

    public void Setup(int score){
        gameObject.SetActive(true);
        pointText.text = score.ToString() + " Points";
    }

    public void RestartButton(){
        SceneManager.LoadScene("Scene1");
    }

    public void ExitButton(){
        SceneManager.LoadScene("Restart");
    }
}
