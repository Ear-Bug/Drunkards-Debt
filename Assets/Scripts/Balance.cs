using UnityEngine;
using UnityEngine.UI;

public class Balance : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int money = 50;
    public Text showBalance;

    void Start() {
       showBalance.text = money.ToString();
    }
}
