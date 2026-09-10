using UnityEngine;



class PROG_Les1 : MonoBehaviour 
{
    string naam = "Marcus";
    int score = 1000;
    int hp = 100;
    bool alive = true;


    string Begroet(string naam)
    {
        return "Hallo " + naam;
    }
    

    void Start()
    {
        string resultaat = Begroet("Marcus");
        Debug.Log(resultaat);
        Debug.Log("Naam : " + naam);
        Debug.Log("Score : " + score);
        Debug.Log("Alive : " + alive);
        Debug.Log("HP : " + hp);
    }
    private void Update()
    {
        if (hp == 0)
        {
            alive = false;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            hp -= 10;
            Debug.Log("HP : " + hp);
            Debug.Log("Alive : " + alive);
        }
    }

}



