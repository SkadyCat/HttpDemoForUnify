using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageViewer : ObViewerTemplates, IPointerEnterHandler, IPointerExitHandler
{

    public bool allwoScroll;

    public string path;
    public Button btn;
    private void Awake()
    {
        btn = this.GetComponent<Button>();

        btn.onClick.AddListener(onClick);

        addViewer(FuncImageViewer.Instance);
    }

    public void onClick()
    {
        RequestTool tool = new RequestTool();

        

        //string value = tool.getResult(tool.CreatePostHttpResponse("/getPath?data=" + path, new Dictionary<string, string>()));


        //Debug.Log(value);
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        allwoScroll = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        allwoScroll = false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (allwoScroll == true)
        {
            this.transform.parent.GetComponent<RectTransform>().localPosition += new Vector3(0, Input.mouseScrollDelta.y, 0)*20;
        }
	}
}
