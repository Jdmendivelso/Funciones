using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Carga : MonoBehaviour
{
    // Start is called before the first frame update
     void Start()
    {
        string LeveToLoad = Pantalladecarga.nextlevel;

        StartCoroutine(this.MakeTheLoad(LeveToLoad));
    }

    IEnumerator MakeTheLoad(string level)
    {

       //quitar linea de codigo 21 para jugarlo

        yield return new WaitForSeconds(1f);

        AsyncOperation operation= ScenceManager.LoadSceneAsync(level);

        while (operation.isDone == false)

        {
            yield return null;
        }

    }
}
