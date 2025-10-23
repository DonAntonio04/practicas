using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Opciones : MonoBehaviour
{
  public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Saliendo del juego...");
    }
}
