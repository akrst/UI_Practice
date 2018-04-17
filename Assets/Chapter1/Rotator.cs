using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	public float rotationSpeed;

	// Use this for initialization
	void Start () {
		//rotationSpeed = 10.0f;
	
		
	}

	// Update is called once per frame
	void Update () {
		//回転させる角度を算出する
		float yAngle = rotationSpeed * Time.deltaTime;
		// ゲームオブジェクトをY軸を基準に回転させる
		transform.Rotate(0.0f, yAngle, 0.0f);		
	}
}
