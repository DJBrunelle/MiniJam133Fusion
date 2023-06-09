using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/** 
 * ResourceUI
 * 
 * A Unity class that updates the resource values on the UI canvas.
 * 
 * Example Usage:
 * 1. Attach this script to a GameObject such as the canvas in your Unity scene.
 * 2. Drag the corresponding TextMeshPro objects from the hierarchy to the inspector.
**/

public class ResourceUI : MonoBehaviour
{
    [SerializeField]
    private TMP_Text moneyText;
    [SerializeField]
    private TMP_Text uraniumText;
    [SerializeField]
    private TMP_Text woodText;
    [SerializeField]
    private TMP_Text waterText;

    // Update is called once per frame
    void Update()
    {
        moneyText.text = $"Money: { GameState.Money.Value}";
        uraniumText.text = $"Uranium: { GameState.Uranium.Value}";
        woodText.text = $"Wood: { GameState.Wood.Value}";
        waterText.text = $"Water: { GameState.Water.Value}";
    }
}
