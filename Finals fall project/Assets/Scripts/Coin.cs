using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Canvas").GetComponent<UIManager>().UpdateCoinCount();
            Debug.Log("player collected a coin");
            Destroy(this.gameObject, 0.2f);
        }
    }
}
