using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour {

    public xmlParser m_xmlLib;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Callback
    public void OnClickStartBtn()
    {
        Debug.Log("Oh~~ Yah~~~!!!");
        if (m_xmlLib == null)
        {
            Debug.Log("xmlLib is Null!");
            return;
        }

        float velocity = m_xmlLib.exe_GetClassVelocityAt(0);
        Debug.Log(string.Format("Velocity: {0:f}",velocity));

        float createNum = m_xmlLib.exe_GetClasscreateNumAt(0);
        Debug.Log(string.Format("CreateNum: {0:f}", createNum));

        string[] words = m_xmlLib.exe_GetClassWordAt(1);
        Debug.Log(string.Format("words count:{0:d}", words.Length));
    }
}
