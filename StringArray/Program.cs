

string[] StringArray (string[] array)
{
    int rows = new Random().Next(3);
    string[]arr = new string [rows];
    for (int i = 0;i < rows;i++)
    {
        int index = new Random().Next(0,array.Length);
        arr[i] = array[index];

    }
    return arr;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
     
            Console.Write(array[i] + " ");
        
    }
        Console.WriteLine();
}


string[] stringarray = {":)","sdsds","dfd","f"};
ShowArray(stringarray);

string[] stringarray2 = StringArray(stringarray);
ShowArray(stringarray2);






