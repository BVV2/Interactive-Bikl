using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsController : MonoBehaviour {

    public Dictionary<string, int[]> Themes = new Dictionary<string, int[]>();


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int CheckTheme(string name)
    {
        if (Themes.ContainsKey(name))
        {
            return Themes[name][1];
        }
        else
        {
            Themes.Add(name, new int[] { 0, 0});
            Debug.Log("Created new Theme: " + name);
        }
        return 0;
    }
}
