// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] arrayOne =  {"Be", "future", "or"};
int countOne = MeaningLessThreeSimb(arrayOne);
string[] resultOne =  ResultArray(arrayOne,countOne);

void PrintArray(string[] array) 
    {

        for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
        Console.WriteLine();
    }

int MeaningLessThreeSimb(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3) count++;
            }
        return count;
    }

string[] ResultArray(string[] array, int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    {
                        result[result.Length - count] = array[i];
                        count--;
                    }
            }
        return result;
    }

PrintArray(resultOne);
