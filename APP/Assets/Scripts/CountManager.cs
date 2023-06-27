using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountManager : MonoBehaviour
{
    public int count = 0;
    public TMP_Text chunkCount;
    public Button mediumZombieButton;
    public Button largeZombieButton;
    public int mediumZombieActive = 50;
    public int largeZombieActive = 200;
    public Image mediumZombieImage;
    public Image largeZombieImage;
    public void IncreaseCount()
    {
        count++;
        chunkCount.text = count.ToString();

    }

    private void Update()
    {
        if(count >= mediumZombieActive)
        {
            mediumZombieButton.interactable = true;
            mediumZombieImage.color = new Color(255,255,255,255);
        }

        if (count >= largeZombieActive)
        {
            largeZombieButton.interactable = true;
            largeZombieImage.color = new Color(255, 255, 255, 255);
        }
    }
}
