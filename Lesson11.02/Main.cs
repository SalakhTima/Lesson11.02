﻿class Main
{
    static void Main(string[] args)
    {
        int codeNumber = 0;
        do
            MenuTask.Menu(ref codeNumber);
        while (codeNumber != 7);
    }