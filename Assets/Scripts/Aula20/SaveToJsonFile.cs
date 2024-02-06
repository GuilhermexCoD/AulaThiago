using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class SaveToJsonFile : IDisposable
{
    private const string FILE_NAME_JSON = "SaveData.json";
    private const string FILE_NAME_TXT = "SaveData.txt";

    private StreamWriter _streamWriter;
    private FileStream _fileStream;

    public async Task SaveAsync(SaveData saveData)
    {
        string jsonSaveData = JsonUtility.ToJson(saveData);

        string filePath = Application.persistentDataPath;

        using (_fileStream = new FileStream(filePath + FILE_NAME_JSON, FileMode.OpenOrCreate))
        {
            var bytes = Encoding.Unicode.GetBytes(jsonSaveData);
            await _fileStream.WriteAsync(bytes);
            _fileStream.Close();
            Debug.Log($"Json file saved at: {filePath + FILE_NAME_JSON}");

        }

        using (_streamWriter = new StreamWriter(filePath + FILE_NAME_TXT))
        {
            await _streamWriter.WriteAsync(jsonSaveData);
            _streamWriter.Close();
            Debug.Log($"Text file saved at: {filePath + FILE_NAME_TXT}");
        }
    }

    public void Dispose()
    {
        _streamWriter?.Close();
        _fileStream?.Close();
    }
}
