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

    // Start is called before the first frame update
    void Start()
    {
        replayButtonn.gameObject.SetActive(false);
        coinAmountText.text = "Coins: " + _coinAmount.ToString();
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
}
