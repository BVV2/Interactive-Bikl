using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoardCreator : MonoBehaviour {


    private static GameObject Camera;
    private PointsController Control;
    private List<string> Themes;
    public GameObject Prefab;
    // Use this for initialization
    void Start () {
        Camera = GameObject.Find("Main Camera");
        Control = (PointsController)Camera.GetComponent(typeof(PointsController));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Instantiator()
    {
        int count = 0;
        foreach (string Theme in Control.Themes.Keys)
        {
            GameObject ScoreEl = new GameObject();
            Vector3 spawnPos = new Vector3(-0.65f,0.65f,0);
            spawnPos.y -= count * 0.2f;
            ScoreEl = Instantiate(Prefab, spawnPos, Quaternion.identity);
            ScoreEl.name = Theme;
            ScoreEl.transform.SetParent(GameObject.Find("ScoreBoard").transform, false);
            Debug.Log("Created prefab: " + Theme + " with answers count: "+ Control.Themes[Theme][0].ToString() + " And amount of points: " + Control.Themes[Theme][1].ToString());
            count++;
        }
    }

}
