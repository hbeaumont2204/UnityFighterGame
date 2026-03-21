using System;
using System.Xml.XPath;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{

    public GameObject deathMenu;
    /* 
    Currency divided into silver and gold 
    Gold converted into silver when buying and selling. 
    Total value not displayed
    1 Gold Ducat = 80 Silver Ducatons
    Total value is saved and converted into silver and gold
    */
    public int silver; // Max value 79 (Converted into gold when exceeds 80)
    public int gold; // Max value of 99
    public int total; // total = silver + (gold * 80)
    
    // Money Display
    public TextMeshProUGUI goldDisplay;
    public TextMeshProUGUI silverDisplay;
    private const int max = 9979; // max = 99*80 + 79

    public float health = 50; // Default is 100, change for testing
    public static int healthIncreases = 0;
    public float maxHealth = 100 + (healthIncreases * 10);
    public int stamina = 100;
    public static int staminaIncreases = 0;
    public int maxStamina = 100 + (staminaIncreases * 10);
    public static int level = 1;
    public int xp = 0;
    public int maxXP = 900 + (level * 100);

    // Health/Stamina UI
    [SerializeField] private Slider healthBar;
    [SerializeField] private Slider staminaBar;

    void Start()
    {
        deathMenu.SetActive(false);
        updateCurrency();
        Debug.Log(health/maxHealth);
        healthBar.value = health/maxHealth;
        staminaBar.value = stamina/maxStamina;
    }

    void Update()
    {
        
    }

    //
    void updateCurrency()
    {
        gold = total / 80;
        silver = total % 80;
        // Display on screen
        goldDisplay.text = gold.ToString();
        silverDisplay.text = silver.ToString();
    }

    void addCurrency(int value)
    {
        total += value;
        if (total > max)
        {
            total = max;
        }
        updateCurrency();
    }

    bool subtractCurrency(int value)
    {
        if (total - value < 0)
        {
            Debug.Log("Not enough money");
            // Deny purchase
            return false;
        }
        else
        {
            total -= value;
            // Accept purchase
            updateCurrency();
            return true;
        }
    }

    public void addHealth(int amount)
    {
        health += amount;
        if (health > maxHealth)
        {
            health = maxHealth;
            
        }
        Debug.Log(health);
        healthBar.value = health/maxHealth;
    }

    public void reduceHealth(int amount)
    {
        health -= amount;
        healthBar.value = health/maxHealth;
        if (health <= 0)
        {
            death();
        }
    }

    public void death()
    {
        String xpLabel = "XP gained " + xp;
        deathMenu.SetActive(true);
        deathMenu.GetComponent<DeathScreen>();
    }

}
