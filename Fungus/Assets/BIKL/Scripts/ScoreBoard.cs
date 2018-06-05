using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

    private static GameObject Camera;
    private PointsController Control;
    private string Name;
    public GameObject Line;
    public GameObject Naming;
    public GameObject Value;
    
	// Use this for initialization
	void Start () {
        Name = this.gameObject.name;
        Camera = GameObject.Find("Main Camera");
        Control = (PointsController)Camera.GetComponent(typeof(PointsController));
        Naming.GetComponentInChildren<Text>().text = Name;
        Value.GetComponentInChildren<Text>().text = "0%";

        if (Control.Themes[Name][0] != 0)
        {
            float coef = Control.Themes[Name][1] / Control.Themes[Name][0];
            float newX = 2.22f * coef;
            Line.transform.position.Set(newX, 0, 0);
            Line.transform.localScale.Set(10.75f * coef, 1, 1);
            Value.GetComponentInChildren<Text>().text = (coef * 100).ToString() + "%";
        }
    }
	
	// Update is called once per frame
	void Update () {
        positioning();
	}

    private void positioning()
    {
        if (Control.Themes[Name][0] != 0)
            {
                float coef = Control.Themes[Name][1] / Control.Themes[Name][0];
                float newX = 2.22f * coef;
                Line.transform.position.Set(newX, 0, 0);
                Line.transform.localScale.Set(10.75f * coef, 1, 1);
                Value.GetComponentInChildren<Text>().text = (coef*100).ToString()+"%";
            }
    }





}
