using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject winPanel;
    public GameObject losePanel;
    public TextMeshProUGUI eggEatenText;
    public TextMeshProUGUI eggMissedText;

    private int eggsEaten = 0;
    private int eggsMissed = 0;

    void Start()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);
        UpdateUI();
    }

    public void UpdateUI()
    {
        eggEatenText.text = "Eggs Eaten: " + eggsEaten.ToString();
        eggMissedText.text = "Eggs Missed: " + eggsMissed.ToString();
    }

    public void EatEgg()
    {
        eggsEaten++;
        UpdateUI();

        if (eggsEaten == 10)
        {
            ShowWinScreen();
        }
    }

    public void MissEgg()
    {
        eggsMissed++;
        UpdateUI();

        if (eggsMissed == 10)
        {
            ShowLoseScreen();
        }
    }

    public void ShowWinScreen()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ShowLoseScreen()
    {
        losePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
