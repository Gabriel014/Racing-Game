using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{

    public GameObject GameOverUI;
    public GameObject Hud;

	public Text finalPosition;

    public Text gamePosition;

    private bool paused = false;

    void Start()
    {
        GameOverUI.SetActive(false);
    }

    void Update()
    {
		gamePosition.text = Generator.position.ToString();
    }

  

    public void Restart()
    {
        SceneManager.LoadScene("Stage1");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {

        SceneManager.LoadScene("Menu");
    }



    void OnGUI()
    {
		if (CarCollider.gameOver == true)
        {
            GameOverUI.SetActive(true);
            Hud.SetActive(false);
            showScore();
        }
    }

    public void showScore()
    {
		finalPosition.text = Generator.position.ToString();
       
    }

}
