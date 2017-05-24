﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScrolling : MonoBehaviour {

	// Use this for initialization
    public float scrollSpeed;
    private Material mat;
    private Vector2 offset = Vector2.zero;
    void Awake(){
        mat = GetComponent<Renderer>().material;
    }

	void Start () {
        offset = mat.GetTextureOffset("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
        offset.y += scrollSpeed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", offset);
		
	}
}
