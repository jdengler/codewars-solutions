//https://www.codewars.com/kata/52e88b39ffb6ac53a400022e

using System;

public class Kata
{
  public static string UInt32ToIP(uint ip)
  {
    string hexValue = ip.ToString("X");
    hexValue = (hexValue.Length != 8) ? hexValue.PadLeft(8,'0') : hexValue;

    string ipv4 = "";
    for(int i = 0; i < hexValue.Length; i+=2)
      ipv4 += Convert.ToInt32(hexValue.Substring(i, 2), 16) + ".";

    return ipv4.Trim('.');
  }
}
