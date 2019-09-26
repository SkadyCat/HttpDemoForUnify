using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class FolderReader : MonoBehaviour,IViewer {

    // Use this for initialization


    public static FolderReader Instance;

    private void Awake()
    {
        Instance = this;
    }

    public Image img;
    void Start () {

        List<string> value = getFolderContent(@"F:\imgSource\bmpLib");

        foreach (string key in value)
        {
            Debug.Log(key);

            LoadImage.Instance.load(key);
        }
    }


    public List<string> getFolderContent(string path)
    {

         DirectoryInfo Dir = new DirectoryInfo(path);


         
         List<string> listValue = new List<string>();


        foreach (FileInfo info in Dir.GetFiles())
        {
            listValue.Add(info.ToString());
        }
        return listValue;
    }
    // Update is called once per frame
    void Update () {
		
	}

    public void update(ViewInfo info)
    {
        switch (info.code) {
            case 2:

                Sprite sp = (Sprite)info.commonArg;
                img.sprite = sp;

                FolderImageViewer.Instance.addNewImage(info.strArg, sp);

                break;

            default:

                break;
        }
    }
}
