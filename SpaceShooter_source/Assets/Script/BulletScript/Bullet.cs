using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float speed;
   // private int score = 0;
    private Rigidbody2D myBody;
    
	// Use this for initialization
	void Awake () {
        myBody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        myBody.velocity = new Vector2(0f, speed);
        
	}

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Enemy")
        {
            //score ++;
            Destroy(target.gameObject);
            Destroy(gameObject);
            /*
            if (GamePlayController.instance != null)
            {
                GamePlayController.instance._SetScore(score);
                
            }*/
        }
        if (target.tag == "Border")
        {
            Destroy(gameObject);

        }
    }
    void Update() {
       
    }
}
