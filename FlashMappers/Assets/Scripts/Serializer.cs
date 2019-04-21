using System;
using System.IO;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

public class Serializer
{
    public static T Load<T>(string filename) where T : class
    {
        if (File.Exists(filename))
        {
            try
            {
                using (Stream stream = File.OpenRead(filename))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    T temp = formatter.Deserialize(stream) as T;
                    stream.Close();
                    return temp;
                }
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
            }
        }
        return default(T);
    }

    public static void Save<T>(string filename, T data) where T : class
    {
        using (Stream stream = File.OpenWrite(filename))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
            stream.Close();
        }
    }
    public static string GetSavePath(string name)
    {
        return Path.Combine(Application.persistentDataPath, name + ".sav");
    }
    public static string GetPath(string name)
    {
        return Path.Combine(Application.persistentDataPath, name);
    }
}