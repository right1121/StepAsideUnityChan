using UnityEngine;
using System.Collections;

public class ObjectDestroy : MonoBehaviour {
	//Unityちゃんのオブジェクト
	private GameObject unitychan;

	// Use this for initialization
	void Start () {
		//Unityちゃんのオブジェクトを取得
		unitychan = GameObject.Find("unitychan");

	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.z < unitychan.transform.position.z - 10 ) {
			Destroy (this.gameObject);
		}
	}
}
