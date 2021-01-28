using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class NormalLevel : MonoBehaviour
{
    //public GameObject iField;
    
    [SerializeField] private List<Woord> woorden;
    public int randomword;
    public GameObject word1;
   
    public TMP_InputField iField;
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

    public Text punten;

    
    private int poging = 1;
    private int aantalGoed = 0;
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
                            SceneManager.LoadScene("Hard");
                        } 
            
             }
             else 
             {
                 if (poging == 1)
                 {
                     Onderlat.SetActive(true);
                     
                 }
                 
               

                 if (poging == 2)
                 {
                     Linkerlat.SetActive(true);
                    
                 }
                 
                 
                 
                 if (poging == 3)
                 {
                     Steunlat.SetActive(true);
                    
                 }
                 
                 if (poging == 4)
                 {
                     Bovenlat.SetActive(true);
                    
                 }
                 
                 if (poging == 5)
                 {
                     Touw.SetActive(true);
                    
                 }
                 
                 if (poging == 6)
                 {
                     Hoofd.SetActive(true);
                    
                 }
                 
                 if (poging == 7)
                 {
                     Lijf.SetActive(true);
                    
                 }
                 
                 if (poging == 8)
                 {
                     Linkerarm.SetActive(true);
                    
                 }
                 
                 if (poging == 9)
                 {
                     Rechterarm.SetActive(true);
                    
                 }

                 if (poging == 10)
                 {
                     Linkerbeen.SetActive(true);
                    
                 }
                 
                 if (poging == 11)
                 {
                     Rechterbeen.SetActive(true);
                    
                 }
                 
                 if (poging == 12)
                 {
                    Debug.Log("Gameover, load next scene");
                    SceneManager.LoadScene("GameOver");
                    
                 }

                 poging++;

             }
             
        
        
        
       
        
       
    }

   


    //Debug.Log("Wrong");



}
