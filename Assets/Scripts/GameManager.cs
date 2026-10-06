using UnityEngine;
using TMPro; // Necesario para TextMeshPro
using UnityEngine.SceneManagement; // Para reiniciar si mueres

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton para fácil acceso
    public TextMeshProUGUI scoreText; // Referencia a tu UI
    private int abejasRecolectadas = 0;

    void Awake()
    {
        // Configuramos el Singleton
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    // Llama a esto cuando el jugador toque una abeja
    public void RecolectarAbeja()
    {
        abejasRecolectadas++;
        scoreText.text = abejasRecolectadas.ToString();
    }

    // Llama a esto desde tu script de muerte del jugador
    public void ReiniciarContadorYEscena()
    {
        abejasRecolectadas = 0; // Se reinicia el contador
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }
}