using System;

public class clsZipCode
{
    public string ZipCode;
    public string State;
    public string City;
    public float Latitude;
    public float Longitude;

    public void Deserialize(string information)
    {
        string[] parsedInformation = information.Split('\t');

        ZipCode = parsedInformation[0];
        State = parsedInformation[1];
        City = parsedInformation[2];
        Latitude = float.Parse(parsedInformation[3]);
        Longitude = float.Parse(parsedInformation[4]);
    }
}