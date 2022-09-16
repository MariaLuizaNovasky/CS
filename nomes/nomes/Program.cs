using System;
using System.Collections;

class nomes
{

    static public void Main()
    {

        ArrayList My_list = new ArrayList();

        My_list.Add("Maria Luiza");
        My_list.Add("Christian");
        My_list.Add("Guilherme Prochnow");
        My_list.Add("Nicole");
        My_list.Add("Gabriele Bubbles");

        foreach (var elements in My_list)
        {
            Console.WriteLine(elements);
        }


    }
}