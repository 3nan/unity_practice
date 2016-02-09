using Kayac.Lobi.SDK;
using UnityEngine;
using System.Collections;

public class Rankingsample : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonPush() {
		//Debug.Log("Button Push !!");
		if (LobiCoreBridge.IsSignedIn()) {
			Debug.Log("アカウント作成済み");
			/* アカウントが作成済みかチェック */
			int val = (int) (10000.0f*Random.value);
			LobiRankingAPIBridge.SendRanking("Button", "SendRankingCallback", "test01", val);
		}else{
			Debug.Log("アカウント作成がまだ");
			LobiCoreAPIBridge.SignupWithBaseName("Button","SendAccountCallBack", "PlayerName");
		}
	}

	void SendRankingCallback(){}
	void SendAccountCallBack(string message){Debug.Log (message);}
}
