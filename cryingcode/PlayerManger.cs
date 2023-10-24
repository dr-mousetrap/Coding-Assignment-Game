using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManger : MonoBehaviour
{
    //public static PlayerManger instance;
    public static bool isGameOver = false;
    public GameObject gameOverScreen;
    public GameObject pauseMenuScreen;

    private void Awake()
    {
        isGameOver = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        /*if(instance == null)
        {
            instance = this;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenuScreen.SetActive(false);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenuScreen.SetActive(true);
    }

}
