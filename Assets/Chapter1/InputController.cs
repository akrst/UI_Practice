using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		if (!Application.isMobilePlatform) {
			//モバイルプラットフォームでないときの処理
			if (Input.GetMouseButtonUp (0)) {
				//マウスの左ボタンが押して話された状態なら、
				//CubeGeneratorkコンポーネントのGenerateメソッドを呼ぶ
				GetComponent<CubeGenerator>().Generate();
			}
		} else {
			//モバイルプラットフォームの処理
			if(Input.touchCount >= 1){
				//マルチタッチの最初のタッチを取得
				Touch touch = Input .GetTouch(0);
				if (touch.phase == TouchPhase.Began) {
					//タッチが開始された状態なら、CubeGeneratorコンポーネントの
					//Gnerateメソッドを呼ぶ
					GetComponent<CubeGenerator>().Generate();
				}
			}
		}
	}
}
