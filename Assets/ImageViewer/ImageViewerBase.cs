using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ImageViewerBase : MonoBehaviour {
    public RectTransform viewPort;
    public RectTransform content;
    public Dictionary<string, GameObject> imageViewerDic = new Dictionary<string, GameObject>();


   

    private void Start()
    {


    }

    public void addNewImage(string path)
    {

        GameObject imageViewer = GameObject.Instantiate(ResourcesManager.prefabDic["ImageViewer"], viewPort.transform.parent);

        imageViewer.GetComponent<RectTransform>().localPosition = new Vector3(0, 150 - 300 * imageViewerDic.Count);
        imageViewerDic.Add(path, imageViewer);

        imageViewer.transform.SetParent(content);
    }


    public void addNewImage(string path, Sprite sp)
    {

        GameObject imageViewer = GameObject.Instantiate(ResourcesManager.prefabDic["ImageViewer"], viewPort.transform.parent);

        imageViewer.GetComponent<RectTransform>().localPosition = new Vector3(0, 150 - 300 * imageViewerDic.Count);
        imageViewerDic.Add(path, imageViewer);
        imageViewer.GetComponent<Image>().sprite = sp;
        imageViewer.GetComponent<ImageViewer>().path = path;
        imageViewer.transform.SetParent(content);
    }

    public void addNewImage(List<string> imageNameList)
    {
        foreach (GameObject g in imageViewerDic.Values)
        {
            Destroy(g);
        }

        imageViewerDic.Clear();


        foreach (string imageName in imageNameList)
        {
            addNewImage(imageName);
        }


    }
}
