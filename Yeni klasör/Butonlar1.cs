using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
    public void CikisButonu()
    {
        Application.Quit(); // týklayýnca uygulamayý komple kapatýr
    }

    public void DockThing()
    {
        // SceneManager.LoadScene(1); // yeni oyun build settingste 1 numarada o yüzden 1 yazarak geçiþ saðladýk
        SceneManager.LoadScene(1);
    }

    public void AcilisSahnesi()
    {
        SceneManager.LoadScene(0);
    }

    
}