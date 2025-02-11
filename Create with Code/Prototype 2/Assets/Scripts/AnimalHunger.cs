using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider hungerSlider;
    public int amountToBeFed;
    private int currentFedAmount = 0 ;
    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        hungerSlider.maxValue = amountToBeFed;
        hungerSlider.value = 0;
        hungerSlider.fillRect.gameObject.SetActive(false);
        spawnManager = GameObject.Find("GameManager").GetComponent<SpawnManager>();
    }
    public void FeedAnimal(int amount)
    {
        currentFedAmount += amount;
        hungerSlider.fillRect.gameObject.SetActive(true);
        hungerSlider.value = currentFedAmount;
        if(currentFedAmount >= amountToBeFed)
        {
        spawnManager.UpdateScore(amountToBeFed);
        Destroy(gameObject, 0.1f);
        }
    }
}
