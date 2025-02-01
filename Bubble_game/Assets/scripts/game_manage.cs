using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class game_manage : MonoBehaviour
{
    public static game_manage instance;
    [SerializeField] public GameObject _gameOverCanvas;
    [SerializeField] public GameObject _gameover;
    [SerializeField] public GameObject _gamewon;
    [SerializeField] public bool _end;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 1.0f;
    }

    private void StopGame()
    {
        Time.timeScale = 0.0f;
    }

    public void GameOver()
    {
        if (!_end)
        {
            _gameOverCanvas.SetActive(true);
            _gamewon.SetActive(false);
            _gameover.GetComponent<Animator>().Play("game_over");
            Invoke(("StopGame"), 1f);
            //_gameOverCanvas.GetComponent<Animator>().Play("game_over");
            _end = true;
        }
    }

    public void GameWon()
    {
        if (!_end)
        {
            _gameOverCanvas.SetActive(true);
            _gameover.SetActive(false);
            //_gameover.GetComponent<Animator>().Play("game_over");
            Invoke(("StopGame"), 1f);
            //_gameOverCanvas.GetComponent<Animator>().Play("game_over");
            _end = true;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoMainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
