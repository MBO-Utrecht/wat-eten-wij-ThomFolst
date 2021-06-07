using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class RecipePicker : MonoBehaviour
{
    public Button Starter;
    public Button Saved;
    public Button SaveRecipe;
    
    [SerializeField] private List<string> Recipes;
    public GameObject MondayRecipe;
    public GameObject TuesdayRecipe;
    public GameObject WednesdayRecipe;
    public GameObject ThursdayRecipe;
    public GameObject FridayRecipe;
    public GameObject SaturdayRecipe;
    public GameObject SundayRecipe;
    
    private int Mondayrandomrecipe;
    private int Tuesdayrandomrecipe;
    private int Wednesdayrandomrecipe;
    private int Thursdayrandomrecipe;
    private int Fridayrandomrecipe;
    private int Saturdayrandomrecipe;
    private int Sundayrandomrecipe;

     
    private int savedMondayRecipe;
    private int savedTuesdayRecipe;
    private int savedWednesdayRecipe;
    private int savedThursdayRecipe;
    private int savedFridayRecipe;
    private int savedSaturdayRecipe;
    private int savedSundayRecipe;
    
    

    void Start()
    {
        Starter.onClick.AddListener(NewRecipes);
        Saved.onClick.AddListener(LoadRecipes);
        SaveRecipe.onClick.AddListener(Save);
    }

    void NewRecipes()
    {
        
        Mondayrandomrecipe = Random.Range(0, Recipes.Count);
        Tuesdayrandomrecipe = Random.Range(0, Recipes.Count);
        Wednesdayrandomrecipe = Random.Range(0, Recipes.Count);
        Thursdayrandomrecipe = Random.Range(0, Recipes.Count);
        Fridayrandomrecipe = Random.Range(0, Recipes.Count);
        Saturdayrandomrecipe = Random.Range(0, Recipes.Count);
        Sundayrandomrecipe = Random.Range(0, Recipes.Count);
        
        
        
        MondayRecipe.GetComponent<Text>().text = Recipes[Mondayrandomrecipe];
        TuesdayRecipe.GetComponent<Text>().text = Recipes[Tuesdayrandomrecipe];
        WednesdayRecipe.GetComponent<Text>().text = Recipes[Wednesdayrandomrecipe];
        ThursdayRecipe.GetComponent<Text>().text = Recipes[Thursdayrandomrecipe];
        FridayRecipe.GetComponent<Text>().text = Recipes[Fridayrandomrecipe];
        SaturdayRecipe.GetComponent<Text>().text = Recipes[Saturdayrandomrecipe];
        SundayRecipe.GetComponent<Text>().text = Recipes[Sundayrandomrecipe];
        
    }

    void Save()
    {
        
        savedMondayRecipe = Mondayrandomrecipe;
        savedTuesdayRecipe = Tuesdayrandomrecipe;
        savedWednesdayRecipe = Wednesdayrandomrecipe;
        savedThursdayRecipe = Thursdayrandomrecipe;
        savedFridayRecipe = Fridayrandomrecipe;
        savedSaturdayRecipe = Saturdayrandomrecipe;
        savedSundayRecipe = Sundayrandomrecipe;
        
        
        PlayerPrefs.SetFloat("Monday", savedMondayRecipe);
        PlayerPrefs.SetFloat("Tuesday", savedTuesdayRecipe);
        PlayerPrefs.SetFloat("Wednesday", savedWednesdayRecipe);
        PlayerPrefs.SetInt("Thursday", savedThursdayRecipe);
        PlayerPrefs.SetInt("Friday", savedFridayRecipe);
        PlayerPrefs.SetInt("Saturday", savedSaturdayRecipe);
        PlayerPrefs.SetInt("Sunday", savedSundayRecipe);
    }

    void LoadRecipes()
    {
        
        
        PlayerPrefs.GetFloat("Monday", savedMondayRecipe);
        PlayerPrefs.GetFloat("Tuesday", savedTuesdayRecipe);
        PlayerPrefs.GetFloat("Wednesday", savedWednesdayRecipe);
        PlayerPrefs.GetInt("Thursday", savedThursdayRecipe);
        PlayerPrefs.GetInt("Friday", savedFridayRecipe);
        PlayerPrefs.GetInt("Saturday", savedSaturdayRecipe);
        PlayerPrefs.GetInt("Sunday", savedSundayRecipe);

        
        MondayRecipe.GetComponent<Text>().text = Recipes[savedMondayRecipe];
        TuesdayRecipe.GetComponent<Text>().text = Recipes[savedTuesdayRecipe];
        WednesdayRecipe.GetComponent<Text>().text = Recipes[savedWednesdayRecipe];
        ThursdayRecipe.GetComponent<Text>().text = Recipes[savedThursdayRecipe];
        FridayRecipe.GetComponent<Text>().text = Recipes[savedFridayRecipe];
        SaturdayRecipe.GetComponent<Text>().text = Recipes[savedSaturdayRecipe];
        SundayRecipe.GetComponent<Text>().text = Recipes[savedSundayRecipe];
    }


}