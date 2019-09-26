using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObviwer  {

    void broadCast(ViewInfo info);

    void addViewer(IViewer viewer);

    void deleteViewer(IViewer viewer);

    void broadCastWithAimViewer(IViewer viewer, ViewInfo info);

}
