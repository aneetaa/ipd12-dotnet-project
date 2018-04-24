using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{
    private GUIStyle guiStyle = new GUIStyle();
    public static int gScore;
    void Start()
    {
        gScore = 0;
    }
    private void OnGUI()
    {

        


        guiStyle.fontSize = 25;
        
        GUI.Label(new Rect(20, 20, 250, 45), ("Score: " + gScore +"/8"), guiStyle);
    }
}
