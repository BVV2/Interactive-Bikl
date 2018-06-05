using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {


    private static GameObject Camera;
    private PointsController Control;
    public string ThemeName;
    public int CustomValue1;
    public int CustomValue2;
    // Use this for initialization
    void Start () {
        Camera = GameObject.Find("Main Camera");
        Control = (PointsController)Camera.GetComponent(typeof(PointsController));
        Control.CheckTheme(ThemeName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Good()
    {       
        Control.Themes[ThemeName][1] += 1;
        Control.Themes[ThemeName][0] += 1;
    }
    public void Neutral()
    {
        Control.Themes[ThemeName][1] += 0;
        Control.Themes[ThemeName][0] += 1;
    }
    public void Bad()
    {
        Control.Themes[ThemeName][1] -= 1;
        Control.Themes[ThemeName][0] += 1;
    }
    public void Custom1()
    {
        Control.Themes[ThemeName][1] += CustomValue1;
        Control.Themes[ThemeName][0] += 1;
    }
    public void Custom2()
    {
        Control.Themes[ThemeName][1] += CustomValue2;
        Control.Themes[ThemeName][0] += 1;
    }
}
