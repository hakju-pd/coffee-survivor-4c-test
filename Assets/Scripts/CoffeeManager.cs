using UnityEngine;
using UnityEngine.UI;

public class CoffeeManager : MonoBehaviour
{
    public static CoffeeManager Instance;
    
    [SerializeField] private Slider coffeeSlider;
    [SerializeField] private float drainRate = 5f;
    private float coffeeLevel = 100f;
    
    void Awake()
    {
        Instance = this;
    }
    
    void Update()
    {
        coffeeLevel -= drainRate * Time.deltaTime;
        coffeeSlider.value = coffeeLevel / 100f;
        
        if (coffeeLevel <= 0)
        {
            Debug.Log("TODO: Hier macht PERSON 2 weiter - Game Over auslösen");
        }
    }
    
    public void RefillCoffee()
    {
        coffeeLevel = 100f;
        Debug.Log("Kaffee aufgefüllt!");
    }
}