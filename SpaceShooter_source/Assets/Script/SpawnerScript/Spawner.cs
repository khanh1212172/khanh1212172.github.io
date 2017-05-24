﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    [SerializeField]
    private GameObject enemy;
    private BoxCollider2D box;
	// Use this for initialization

	void Start () {
        box = GetComponent<BoxCollider2D>();
        StartCoroutine(SpawnerEnemy());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator SpawnerEnemy() {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;

        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);
        Instantiate(enemy, temp, Quaternion.identity);

        StartCoroutine(SpawnerEnemy());
    }
}
