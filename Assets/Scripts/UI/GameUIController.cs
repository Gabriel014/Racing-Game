using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameUIController : MonoBehaviour
{

    public GameObject GameOverUI;
    public GameObject Hud;
    public string ordinal;

	public Text finalPosition;
	public Text finalPositionFront;


    public Text gamePosition;

    private bool paused = false;

    void Start()
    {
        GameOverUI.SetActive(false);
    }

    void Update()
    {
        switch (Generator.position)
        {
            case 1:
                ordinal = "st";
                break;
            case 2:
                ordinal = "nd";
                break;
            case 3:
                ordinal = "rd";
                break;
            default:
                ordinal = "th";
                break;

        }

		gamePosition.text = Generator.position.ToString()+ordinal;
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
		finalPosition.text = Generator.position.ToString()+ordinal;
		finalPositionFront.text = finalPosition.text;
       
    }

}
