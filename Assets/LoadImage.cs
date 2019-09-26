using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadImage : ObViewerTemplates {


    public static LoadImage Instance;

    public void Awake()
    {
        Instance = this;
    }
    // Use this for initialization
    void Start () {
       // StartCoroutine(loadSprite("C:\\Users\\HP\\Desktop\\相册\\合照\\IMG_7438.jpg"));

        addViewer(FolderReader.Instance);
	}
    public Image img;
	// Update is called once per frame
	void Update () {
		
	}


    public void load(string path)
    {

        StartCoroutine(loadSprite(path));


    }
    public Sprite sp;
    IEnumerator loadSprite(string path)
    {
        string filePath = path;
        WWW www = new WWW("file://" + filePath);
        yield return www;

        Texture2D texture = www.texture;
        Debug.Log("图片格式= "+texture);
        //因为我们定义的是Image，所以这里需要把Texture2D转化为Sprite
        sp = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));

        
        ViewInfo info = new ViewInfo();
        info.strArg = path;
        info.code = 2;
        info.commonArg = sp;
        broadCast(info);
    }
}
