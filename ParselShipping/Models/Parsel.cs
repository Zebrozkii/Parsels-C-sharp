using System;

namespace ParselShipping.Models
{
  public class Parsel
  {
    private int _height;
    private int _width;
    private int _weight;
    private int _length;

    public Parsel (int height, int width, int length, int weight)
    {
      _height = height;
      _width = width;
      _length=length;
      _weight = weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public int GetLength()
    {
      return _length;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetWidth()
    {
      return _width;
    }

    public int Volume()
    {
      return _height * _width * _length;
    }

    public int CostToShip()
    {
      return this.Volume() * _weight;
    }
  }
}
