using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        var worldHeight = Camera.main.orthographicSize * 2f;
        var worldWitdh = worldHeight * Screen.width / Screen.height;
        transform.localScale = new Vector3(worldWitdh, worldHeight, 0f);
	}
	
	// Update is called once per frame

}
