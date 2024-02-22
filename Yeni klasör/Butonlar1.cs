using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    public void CikisButonu()
    {
        Application.Quit(); // t�klay�nca uygulamay� komple kapat�r
    }

    public void DockThing()
    {
        // SceneManager.LoadScene(1); // yeni oyun build settingste 1 numarada o y�zden 1 yazarak ge�i� sa�lad�k
        SceneManager.LoadScene(1);
    }

    public void AcilisSahnesi()
    {
        SceneManager.LoadScene(0);
    }

    
}