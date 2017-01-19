using UnityEngine;
using System.Collections;
using LuaInterface;

public class MyScene : MonoBehaviour {

    string mySource = @"
MyTest.test();
";

    void Start () {
        LuaScriptMgr luaMgr = new LuaScriptMgr();
        luaMgr.Start();
        LuaState l = luaMgr.lua;
        l.DoString(mySource);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
