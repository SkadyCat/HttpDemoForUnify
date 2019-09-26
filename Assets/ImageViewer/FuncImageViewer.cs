using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncImageViewer : ImageViewerBase,IViewer {


    public static FuncImageViewer Instance;

    public void update(ViewInfo info)
    {
        


    }

    private void Awake()
    {
        Instance = this;
    }





}
