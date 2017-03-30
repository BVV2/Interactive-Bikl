using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
    
    public Scene SC;
 
    public void Game1()
    {
        SceneManager.LoadScene("Game1");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void HomeS()
    {
        SceneManager.LoadScene("HomeScreen");
    }

    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Selector()
    {
        SceneManager.LoadScene("Selector");
    }
    /*
    public void NextLevel()
    {
        SC = SceneManager.GetActiveScene();        
        string name = SC.name;
        Debug.Log("current scene " + name);
        string nextName = "Game " + (int.Parse(name[name.Length + 1].ToString()) + 1).ToString();
        Debug.Log("loading scene " + nextName);
        SceneManager.LoadScene(nextName);
    }
    */

    public void Restart()
    {
        SC = SceneManager.GetActiveScene();
        string name = SC.name;
        Debug.Log("loading scene " + name);
        SceneManager.LoadScene(name);
    }

    

}
