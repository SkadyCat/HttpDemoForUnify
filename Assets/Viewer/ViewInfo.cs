using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewInfo  {

    public string strArg;
    public object commonArg;

    public int code = 0;
    public ViewInfo()
    {
    }

    public ViewInfo(string strArg)
    {
        this.strArg = strArg;
    }
}
