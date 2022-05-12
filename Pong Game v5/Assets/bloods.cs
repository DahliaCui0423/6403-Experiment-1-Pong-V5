using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bloods : MonoBehaviour
{
    public float speed = 3f;
    private bool movingRight = true;
    void FixedUpdate(){
        if(movingRight){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >=5){
                movingRight = false;
            }
        } else {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if(transform.position.x <= -5){
                movingRight = true;
            }
        }
    }
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.name == "Ball")
        {
            string bloodName = transform.name;
            GameManager.Score(bloodName);
            // hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
