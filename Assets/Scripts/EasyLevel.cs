using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Random = UnityEngine.Random;


public class EasyLevel : MonoBehaviour
{
        
    //public GameObject iField;
    [SerializeField] private List<Woord> woorden;
    public int randomword;
    
    //inputfield
    public TMP_InputField iField;
    
    //hangman assets
    public GameObject Onderlat;
    public GameObject Linkerlat;
    public GameObject Steunlat;
    public GameObject Bovenlat;
    public GameObject Touw;
    public GameObject Hoofd;
    public GameObject Lijf;
    public GameObject Linkerarm;
    public GameObject Rechterarm;
    public GameObject Linkerbeen;
    public GameObject Rechterbeen;

    //words
    public GameObject word1;

    public Text punten;
    
    
    private int poging = 1;

    public int aantalGoed = 0;
    //public TMP_Text myText;
    void Start()
    {
        Debug.Log("Starting...");
        NewWord();

    }

    private void Update()
    {
            punten.text = aantalGoed.ToString();
    }

    void NewWord()
    {
            randomword= Random.Range(0, woorden.Count);
            word1.SetActive(true);
            word1.GetComponent<Text>().text = woorden[randomword].question;

            iField.text = "";

            poging = 1;



    }

    public void MyFunction(string text)
    {


                if (iField.text == woorden[randomword].answer)
                {
                        Debug.Log("true");
                        woorden.RemoveAt(randomword);
                        NewWord();
                        aantalGoed++;
                        
                        if (aantalGoed >= 5)
                        {
                                SceneManager.LoadScene("Normal");
                        }


                }
                else if (poging == 1) 
             {
                     Onderlat.SetActive(true);
                     
             }
             else if (poging == 2)
             {
                     Linkerlat.SetActive(true);
                    
             }
             
             else if (poging == 3)
             {
                     Steunlat.SetActive(true);
                    
             }
                 
             else if (poging == 4)
             {
                     Bovenlat.SetActive(true);
                    
             }
                 
             else if (poging == 5)
             {
                     Touw.SetActive(true);
                    
             }
                 
             else if (poging == 6)
             {
                     Hoofd.SetActive(true);
                    
             }
                 
             else if (poging == 7)
             {
                     Lijf.SetActive(true);
                    
             }
                 
             else if (poging == 8)
             {
                     Linkerarm.SetActive(true);
                    
             }
                 
             else if (poging == 9)
             {
                     Rechterarm.SetActive(true);
                    
             }

             else if (poging == 10)
             {
                     Linkerbeen.SetActive(true);
                    
             }
                 
             else if (poging == 11)
             {
                     Rechterbeen.SetActive(true);
                    
             }
                 
             else if (poging == 12)
             {
                    Debug.Log("Gameover, load next scene");
                    SceneManager.LoadScene("GameOver");
                    
             }

             poging++;
            
             
        
        
        
        
    }


    
    
   


    //Debug.Log("Wrong");



}
