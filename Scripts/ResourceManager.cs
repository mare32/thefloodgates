using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public int availableScrap = 500;
    public int availableBiomass = 200;
    public TextMeshProUGUI scrapText;
    public TextMeshProUGUI biomassText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpendScrap(int amount)
    {
        availableScrap -= amount;
        scrapText.text = ("Scrap " + availableScrap).ToString();
    } 
    public void SpendBiomass(int amount)
    {
        availableBiomass -= amount;
        biomassText.text = ("Biomass " + availableBiomass).ToString();
    }
}
