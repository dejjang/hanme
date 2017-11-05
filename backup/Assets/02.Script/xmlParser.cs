using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;


public class xmlParser : MonoBehaviour {

    private XmlDocument m_XmlDoc = null;

    void Start ()
    {
        long errCode = 0;

        errCode = inner_LoadXml("levelClass");
        if (errCode != 0)
            Debug.Log("inner_LoadXml() Err");

    }
	/*
	// Update is called once per frame
	void Update ()
    {
	    	
	}
    */
    private long inner_LoadXml(string filename)
    {
        TextAsset txtAsset = (TextAsset)Resources.Load("xml/" + filename);
        XmlDocument xmlDoc = new XmlDocument();

        if (xmlDoc == null)
            return -1;

        Debug.Log("Xml Load Succes!");
        xmlDoc.LoadXml(txtAsset.text);
        m_XmlDoc = xmlDoc;

        return 0;
    }
    public float exe_GetClassVelocityAt(int step)
    {
        XmlNodeList classNodes = null;
        XmlNode root = null;

        string temp = null;
        float velocity = 0;

        root = m_XmlDoc.SelectSingleNode("root");
        classNodes = root.ChildNodes;

        if (classNodes == null)
            return 0;

        temp = classNodes[step].Attributes["velocity"].Value;
        velocity = float.Parse(temp);

        return velocity;
    }
    public float exe_GetClasscreateNumAt(int step)
    {
        XmlNodeList classNodes = null;
        XmlNode root = null;

        string temp = null;
        float velocity = 0;

        root = m_XmlDoc.SelectSingleNode("root");
        classNodes = root.ChildNodes;

        if (classNodes == null)
            return 0;

        temp = classNodes[step].Attributes["createNum"].Value;
        velocity = float.Parse(temp);

        return velocity;
    }
    public string[] exe_GetClassWordAt(int step)
    {
        XmlNodeList classNodes = null;
        XmlNode root = null;
        int stepXml = 0;
        string[] words = null;
        string temp = null;

        root = m_XmlDoc.SelectSingleNode("root");
        classNodes = root.ChildNodes;

        foreach (XmlNode item in classNodes)
        {
            stepXml = int.Parse(item.Attributes["step"].Value);
            if(stepXml == step)
            {
                classNodes = item.ChildNodes;
                break;
            }
        }
        if (classNodes == null)
            return null;

        temp = classNodes[0].InnerText;
        if (temp == null)
            return null;

        temp = temp.TrimStart(new char[] { '\r', '\n', ' ' });
        temp = temp.TrimEnd(new char[] { ' ', '\r', '\n' });

        words = temp.Split(new char[] {','});
        return words;
    }

    //LDH8282 public struct exe_GetClassGroupAt

}
