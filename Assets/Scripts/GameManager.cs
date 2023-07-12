using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;




public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI playerScore;
    [SerializeField] private TextMeshProUGUI AIScore;

    // Update is called once per frame
    void Update()
    {
        // Check if playerScore reaches five
        if ((int.Parse(playerScore.text)) >= 5)
        {
            // Advance to the next section or level
            Invoke("LoadNextScene", 1f);
        }
        else if((int.Parse(AIScore.text)) >= 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }   

    void LoadNextScene()
    {
        // Advance to the next section or level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}

