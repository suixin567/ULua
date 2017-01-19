using UnityEngine;
using System.Collections;

public class MyTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public static void test() {
        print("由lua调用c#");
    }
}
