using UnityEngine;

public class Utils : MonoBehaviour
{
    [SerializeField] public string destiny;

    public static void OpenMapDirectionstoDestiny(string destiny)
    {
        Application.OpenURL("https://www.google.com/maps/dir/?api=1&destination=" + destiny);
    }

    [ContextMenu("GoDestiny")]
    public void GoDestiny()
    {
        OpenMapDirectionstoDestiny(destiny);
    }
}