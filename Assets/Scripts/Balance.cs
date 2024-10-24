using UnityEngine;
using UnityEngine.UI;

public class Balance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Public Text moneyText
    public float money;

    void Update() {
       moneyText.text = money.ToString();
    }
}
