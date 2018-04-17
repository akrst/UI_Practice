using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour {

	[SerializeField] private GameObject cubePrefab; //立方体のプレファブの定義

	public void Generate() {
		//立方体プレファブをインスタンス化
		GameObject obj = Instantiate(cubePrefab) as GameObject;
		//インスタンスを[CubeGeneretor]オブジェクトの子要素にする
		obj.transform.SetParent(transform);　//引数transformは、this省略のショートハンド
		//インスタンスのスケールをプレハブに合わせる
		obj.transform.localScale = cubePrefab.transform.localScale;
		//インスタンスの位置を[CubeGenerator]オブジェクトに合わせる
		obj.transform.position = transform.position;
		//落下のたびに変化するように、ランダムな回転角度にする
		obj.transform.rotation = Random.rotation;
	}
}
