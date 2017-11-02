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
        m_xmlLib.exe_LoadXml("levelClass");
    }
}
