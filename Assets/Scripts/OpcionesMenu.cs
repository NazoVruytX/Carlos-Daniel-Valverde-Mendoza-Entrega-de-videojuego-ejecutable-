using UnityEngine;
using UnityEngine.SceneManagement;

public class OpcionesMenu : MonoBehaviour
{
    // Esta variable guardará tu panel de opciones (el que se llama "PanelInputConfiguration")
    public GameObject panelDeOpciones; 

    public void vamosAjugar()
    {
        // Carga la escena en el índice 1 (tu nivel principal)
        SceneManager.LoadScene(1);
    }

    public void abrirOpciones()
    {
        // Enciende el panel para que aparezca en pantalla
        panelDeOpciones.SetActive(true); 
    }

    public void cerrarOpciones()
    {
        // Apaga el panel para ocultarlo
        panelDeOpciones.SetActive(false); 
    }

    public void salirDelJuego()
    {
        // Muestra este mensaje en la consola de Unity para saber que el botón funciona
        Debug.Log("Saliendo del juego...");
        
        // Cierra la aplicación (esto solo se nota cuando el juego está exportado)
        Application.Quit();
    }
}