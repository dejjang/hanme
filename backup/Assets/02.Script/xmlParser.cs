using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;


public class xmlParser : MonoBehaviour {
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
	    	
	}

    public void exe_LoadXml(string filename)
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("xml/" + filename);
        XmlDocument xmlDoc = new XmlDocument();

        if (xmlDoc == null)
            return;

        Debug.Log(txtAsset.text);
        xmlDoc.LoadXml(txtAsset.text);
    }
}
