using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private bool see_lvls;
    public GameObject lvls;
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayGame_Sewer()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void PlayGame_Atl()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
    public void Levels()
    {
        if (see_lvls)
        {
            lvls.SetActive(false);
            see_lvls = false;
        }
        else
        {
            lvls.SetActive(true);
            see_lvls = true;
        }
    }
}
