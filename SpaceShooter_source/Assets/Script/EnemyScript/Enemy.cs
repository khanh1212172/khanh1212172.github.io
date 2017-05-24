using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
    public float enemySpeed;
    private Rigidbody2D myBody;

	void Start () {
        myBody = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
        myBody.velocity = new Vector2(0f, -enemySpeed);
	}
    void OnTriggerEnter2D(Collider2D target) {
        if (target.tag == "Player") {
            Destroy(target.gameObject);
            GamePlayController.instance.PlaneDiedShowPanel();
        }
        if (target.tag == "Border") {
            Destroy(gameObject);

        }
    }
}
