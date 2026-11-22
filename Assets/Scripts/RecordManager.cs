using TMPro;
using UnityEngine;

public class RecordManager : MonoBehaviour
{
    public static RecordManager recordManagerInstance;
    [SerializeField] TextMeshProUGUI recordText, gameOverRecordText, victoryRecordText;

    private void Awake()
    {
        recordManagerInstance = this;
    }

    private void Start()
    {
        int currentRecord = PlayerPrefs.GetInt("Record", 0);
        recordText.text = currentRecord.ToString("D8");
        gameOverRecordText.text = $"Record: {currentRecord:D8}";
        victoryRecordText.text = $"Record: {currentRecord:D8}";
    }

    public void CheckRecord(int s)
    {
        if (s > PlayerPrefs.GetInt("Record"))
        {
            PlayerPrefs.SetInt("Record", s);
            recordText.text = s.ToString("D8");
            gameOverRecordText.text = s.ToString("D8");
            victoryRecordText.text = s.ToString("D8");
        }
    }
}