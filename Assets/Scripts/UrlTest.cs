using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlTest : MonoBehaviour {

	// Use this for initialization
	void Start () {


        RequestTool tool = new RequestTool();

        Dictionary<string, string> dic = new Dictionary<string, string>();

        string value = tool.getResult(tool.CreatePostHttpResponse("/loginDemo", dic));

       
        DataCell data = JsonUtility.FromJson<DataCell>(value);
        Debug.Log(data.width);


    }


    private void Awake()
    {
        


    }
    // Update is called once per frame
    void Update () {
		
	}
}
