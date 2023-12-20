using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI coinAmountText;

    public Button replayButtonn;

    private int _coinAmount;

    public Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        replayButtonn.gameObject.SetActive(false);
        startButton.gameObject.SetActive(true);
        coinAmountText.gameObject.SetActive(false);
    }

    public void UpdateCoinCount()
    {
        _coinAmount++;
        coinAmountText.text = "Coins: " + _coinAmount.ToString();
    }

    public void GameOver()
    {
        replayButtonn.gameObject.SetActive(true);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame() 
    {
    startButton.gameObject.SetActive(false);
    coinAmountText.gameObject.SetActive(true);
    coinAmountText.text = "Coins: " + _coinAmount.ToString();
        GameObject.Find("Spawn Manager").GetComponent<SpawnManager>().StartSpawner();

    }
}
