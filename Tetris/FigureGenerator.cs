﻿// See https://aka.ms/new-console-template for more information
using Tetris;

internal class FigureGenerator
{
    private int _x;
    private int _y;
    private char _c;

    private Random _rand = new Random();

    public FigureGenerator(int x, int y, char c)
    {
        _x = x;
        _y = y;
        _c = c;
    }

    internal Figure GetNewFigure()
    {
        if(_rand.Next(0, 2) == 0)
            return new Squery(_x, _y, _c);
        else
            return new Stick(_x, _y, _c);
    }
}