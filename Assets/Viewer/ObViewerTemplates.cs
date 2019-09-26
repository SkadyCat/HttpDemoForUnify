using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObViewerTemplates : MonoBehaviour,IObviwer {

    public List<IViewer> viewList = new List<IViewer>();


    public void broadCast(ViewInfo info)
    {
        foreach (IViewer viewer in viewList)
        {

            viewer.update(info);
        }
    }

    public void addViewer(IViewer viewer)
    {
        viewList.Add(viewer);
    }

    public void deleteViewer(IViewer viewer)
    {
        viewList.Remove(viewer);
    }

    public void broadCastWithAimViewer(IViewer viewer, ViewInfo info)
    {

        viewer.update(info);

    }
}
