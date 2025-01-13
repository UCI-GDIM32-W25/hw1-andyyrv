using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        // Update the UI text to show seeds left/planted
        _remainingText.text = "" + seedsLeft;
        _plantedText.text = "" + seedsPlanted;
    }
}