using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FolderImageViewer : ImageViewerBase {

    public static FolderImageViewer Instance;

    private void Awake()
    {
        Instance = this;
    }
}
