using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesManager : MonoBehaviour {


    public static Dictionary<string, GameObject> prefabDic = new Dictionary<string, GameObject>();


    private void Awake()
    {
        prefabDic.Add("ImageViewer", Resources.Load<GameObject>("ImageViewer"));
    }



}
