using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Plane : MonoBehaviour {

    public float planeSpeed;
    private Rigidbody2D myBody;

    [SerializeField]
    private GameObject bullet;

    private bool canShoot = true;
	// Use this for initialization
	void Awake () {
        myBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        PlaneMovement();
	}

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)) {

            if (canShoot == true) {
                StartCoroutine(Shoot());
            }
        }
    }
    void PlaneMovement()
    {
        float xAxis = Input.GetAxisRaw("Horizontal") * planeSpeed;
        float yAxis = Input.GetAxisRaw("Vertical") * planeSpeed;
        myBody.velocity = new Vector2(xAxis, yAxis);
    }

    IEnumerator Shoot() {
        canShoot = false;

        Vector3 temp = transform.position;
        temp.y += 0.7f;

        Instantiate(bullet, temp, Quaternion.identity);
        yield return new WaitForSeconds(0.3f);
        canShoot = true;
    }
}
