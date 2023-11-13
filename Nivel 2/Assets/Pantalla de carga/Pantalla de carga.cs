using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pantalladecarga : MonoBehaviour
{
    public static string nextlevel;

    public static void loadlevel(string name);

    nextlevel = name;

        SceneManager.loadlevel("Loading");


}
