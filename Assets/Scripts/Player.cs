using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    public GameControl gameKontrol;
    public int moveSpeed;
    private Rigidbody rig;
    float x;
    float z;
   
    void Start()
    {
        rig = GetComponent<Rigidbody>();    
    }

    private void FixedUpdate(){
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
       
        rig.AddForce(new Vector3(x,0f,z) * moveSpeed);
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag.Equals("altin")){
            gameKontrol.AltinArttir();
            Destroy(collision.gameObject);
        }
    }

    public void GameOver(){
        SceneManager.LoadScene("Restart");
    }
}
